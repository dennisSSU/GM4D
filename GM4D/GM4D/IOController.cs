using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace GM4D
{
    class IOController
    {
        private Settings settings;
        private delegate void SaveSettingsToFileDelegate(string filename);
        private delegate ArrayList ReadDhcpdLeasesFileDelegate(string filename);
        public IOController(Settings _settings)
        {
            this.settings = _settings;
            this.initiateDhcpdLeasesFileWatcher();
        }

        public void SaveSettingsFile(String filename)
        {
            SaveSettingsToFileDelegate saveSettingsToFileDelegate = null;
            saveSettingsToFileDelegate = new SaveSettingsToFileDelegate(writeSettingsToFile);
            IAsyncResult saveSettingsToFileResult = saveSettingsToFileDelegate.BeginInvoke(filename, SaveSettingsToFileComplete, null);
        }
        private void writeSettingsToFile(String filename)
        {
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename);
            streamWriter.Write(CreateConfig());
            streamWriter.Flush();
            streamWriter.Close();
        }

        public String CreateConfig()
        {
            String dhcpConfig = "#dhcpd.conf created by GM4D tool" + Environment.NewLine +
                "default-lease-time " + settings.DefaultLeaseTime + ";" + Environment.NewLine +
                "max-lease-time " + settings.MaxLeaseTime + ";" + Environment.NewLine;
            if (settings.HostSubnetMaskIsSet)
            {
                dhcpConfig += "option subnet-mask " + settings.HostSubnetMask + ";" + Environment.NewLine;
            }
            dhcpConfig += "subnet " + settings.Subnet + " netmask " + settings.SubnetMask + " {" + Environment.NewLine +
                "   range " + settings.IpRangeStart + " " + settings.IpRangeEnd + ";" + Environment.NewLine;
            if (settings.GatewayIsSet)
            {
                dhcpConfig += "   option routers " + settings.Gateway + ";" + Environment.NewLine;
            }
            if (settings.PrimaryDNSIsSet)
            {
                dhcpConfig += "   option domain-name-servers " + settings.PrimaryDNS;
                if (settings.SecondaryDNSIsSet)
                {
                    dhcpConfig += ", " + settings.SecondaryDNS;
                }
                dhcpConfig += ";" + Environment.NewLine;
            }
            if (settings.StaticLeases.Count >= 1)
            {
                foreach (KeyValuePair<String, StaticLease> entry in settings.StaticLeases)
                {
                    dhcpConfig += "   host " + entry.Value.DeviceName + " {" + Environment.NewLine +
                        "      hardware ethernet " + entry.Value.MACAddress + ";" + Environment.NewLine +
                        "      fixed-address " + entry.Value.IPAddress + ";" + Environment.NewLine +
                        "   }" + Environment.NewLine;
                }
            }
            dhcpConfig += "}";
            return dhcpConfig;
        } 
        public static void SaveSettingsToFileComplete(IAsyncResult result)
        {
        }

        public void LoadSettingsFile(String filename)
        {

        }

        public void SetNewHostIp()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {
                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo ifconfig " + ((HostNIC)this.settings.Interfaces[this.settings.SelectedInterface]).Id + " " + this.settings.NewHostIP + " netmask " + this.settings.NewHostSubnetMask + "\"")
                };

                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    if (p != null)
                    {
                        var strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                    }
                }
                GetHostInfo();
            }
            else
            {
                throw new System.Exception("Error in IOController - ApplySettingsToDHCPServer - System is not a Unix environment");
            }
        }

        public void InstallDHCPServer()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {

                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo apt-get install isc-dhcp-server\"")
                };

                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    if (p != null)
                    {
                        var strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                    }
                }
            }
            else
            {
                throw new System.Exception("Error in IOController - ApplySettingsToDHCPServer - System is not a Unix environment");
            }
        }

        public void ApplySettingsToDHCPServer()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {

                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo mv " + Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d /etc/dhcp/dhcpd.conf\"")
                };

                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    if (p != null)
                    {
                        var strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                    }
                }
            }
            else
            {
                throw new System.Exception("Error in IOController - ApplySettingsToDHCPServer - System is not a Unix environment");
            }
            if (this.settings.IsDHCPServerRunning)
            {
                this.RestartDHCPServer();
            }
        }

        public void GetHostInfo()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            NetCalcTool nct = settings.NetCalcTool;
            // loop through all network interfaces
            foreach (NetworkInterface adapter in nics)
            {
                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + " nic: " + adapter.Name +" type: " + adapter.NetworkInterfaceType);
                //check if interface is loopback
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    //skip if loopback
                    continue;
                }
                //check if adapter is up
                if (adapter.OperationalStatus != OperationalStatus.Up)
                {
                    Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + " nic: " + adapter.Name + " type: " + adapter.NetworkInterfaceType + " status " + adapter.OperationalStatus);
                    //if not up skip this interface
                    continue;
                }
                //create new HostNIC
                HostNIC nic = new HostNIC();
                //get name, id, hardware address, interface type
                nic.Name = adapter.Name;
                nic.Id = adapter.Id;
                nic.MacAddress = adapter.GetPhysicalAddress().ToString();
                nic.Type = adapter.NetworkInterfaceType.ToString();
                //get ipv4 status
                nic.Ipv4Enabled = adapter.Supports(NetworkInterfaceComponent.IPv4);
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    nic.StaticIPAddress = !adapter.GetIPProperties().GetIPv4Properties().IsDhcpEnabled;
                    // get gateway addresses and set first if present
                    GatewayIPAddressInformationCollection gateways = adapter.GetIPProperties().GatewayAddresses;
                    if (gateways.Count > 0)
                    {
                        nic.Gateway = gateways[0].Address.ToString();
                    }
                    // get unicast addresses
                    foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                    {
                        // check if ipv4 address
                        if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            // set ip adress
                            nic.IPAddress = unicastIPAddressInformation.Address.ToString();
                            // get subnet mask
                            String snetMask;
                            try
                            {
                                // IPv4Mask not implemented in mono at current state
                                snetMask = unicastIPAddressInformation.IPv4Mask.ToString();
                            }
                            catch (NotImplementedException e)
                            {
                                // workaround to get subnetmask in unix environment with mono using the custom SubnetMask class 
                                snetMask = "";
                                snetMask = SubnetMask.GetIPv4Mask(adapter.Name);
                            }
                            nic.SubnetMask = snetMask;
                        }
                    }
                    //try to get the dns addresses of adapter
                    try
                    {
                        IPAddressCollection dnsAddresses = adapter.GetIPProperties().DnsAddresses;
                        if (dnsAddresses.Count >= 1) nic.PrimaryDNS = dnsAddresses[0].ToString();
                        if (dnsAddresses.Count >= 2) nic.SecondaryDNS = dnsAddresses[0].ToString();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + "Errror in IOController getHostInfo - failed to get DNS server addresses - " + e);
                    }
                    //calculate network id 
                    try
                    {
                        nct.calculate(nic.IPAddress, nic.SubnetMask);
                        nic.SubnetIdentifier = nct.NetworkId;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Errror in IOController getHostInfo - failed calculate network address - " + e);
                    }
                }
                //add NIC to settings
                settings.AddInterface(nic);
            }
        }

        public void GetDHCPServerInstallStatus()
        {
            this.settings.OverviewDhcpServerInstallStatus = "not installed";
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {
                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \" dpkg-query -s isc-dhcp-server | head -n2 | tail -n1 | cut -f3 -d' '\"")
                };
                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    if (p != null)
                    {
                        var strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        if (strOutput.Length == 3)
                        {
                            this.settings.OverviewDhcpServerInstallStatus = "installed";
                        }
                    }
                }
            }
            else
            {
                throw new System.Exception("Error in IOController - getDHCPServerInstallStatus - System is not a Unix environment");
            }
        }

        public void GetDHCPServerStatus()
        {
            this.settings.OverviewDhcpServerStatus = "no status";
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {
                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo service isc-dhcp-server status\"")
                };
                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    if (p != null)
                    {
                        var strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        Console.WriteLine("GetDHCPServerStatus "+strOutput);
                        if (strOutput.Split(' ')[1].Contains("start"))
                        {
                            this.settings.IsDHCPServerRunning = true;
                            var strStatus = strOutput.Split(' ')[1];
                            strStatus = strStatus.Remove(strStatus.IndexOf(','));
                            this.settings.OverviewDhcpServerStatus = strStatus;
                            
                        }
                        else if (strOutput.Split(' ')[1].Contains("stop"))
                        {
                            this.settings.IsDHCPServerRunning = false;
                            this.settings.IsDHCPServerRunning = true;
                            var strStatus = strOutput.Split(' ')[1];
                            this.settings.OverviewDhcpServerStatus = strStatus;
                        }
                        else
                        {
                            this.settings.IsDHCPServerRunning = false;
                            throw new System.Exception("Error in IOController - GetDHCPServerStatus - Unknown status" + strOutput);
                        }
                        Console.WriteLine("settings.OverviewDhcpServerStatus " + this.settings.OverviewDhcpServerStatus);
                        Console.WriteLine("settings.IsDHCPServerRunning " + this.settings.IsDHCPServerRunning);
                    }
                }
            }
            else
            {
                throw new System.Exception("Error in IOController - GetDHCPServerStatus - System is not a Unix environment");
            }
        }

        public void StartDHCPServer()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {
                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo service isc-dhcp-server start\"")
                };
                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    var strOutput = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    Console.WriteLine("\n\nStartDHCPServer\n" + strOutput);
                }
                GetDHCPServerStatus();
            }
            else
            {
                throw new System.Exception("Error in IOController - StartDHCPServer - System is not a Unix environment");
            }
        }
        public void StopDHCPServer()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {
                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo service isc-dhcp-server stop\"")
                };
                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    var strOutput = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    Console.WriteLine("\n\nStopDHCPServer\n" + strOutput);
                }
            }
            else
            {
                throw new System.Exception("Error in IOController - StopDHCPServer - System is not a Unix environment");
            }
            GetDHCPServerStatus();
        }
        public void RestartDHCPServer()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
            {
                SaveSettingsFile(Environment.CurrentDirectory.ToString() + "/dhcpd.gm4d");
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-c \"gksudo service isc-dhcp-server restart\"")
                };
                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    var strOutput = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    Console.WriteLine("\n\nRestartDHCPServer\n" + strOutput);
                }
            }
            else
            {
                throw new System.Exception("Error in IOController - RestartDHCPServer - System is not a Unix environment");
            }
            GetDHCPServerStatus();
        }
        public FileSystemWatcher DhcpdLeasesFileWatcher { get; set; }
        private void initiateDhcpdLeasesFileWatcher()
        {
            if (File.Exists("/var/lib/dhcp/dhcpd.leases"))
            {
                System.Console.WriteLine("initiateDhcpdLeasesFileWatcher File.Exists = true for /var/lib/dhcp/dhcpd.leases");
                // create a new FileSystemWatcher
                this.DhcpdLeasesFileWatcher = new FileSystemWatcher();
                string path = Path.Combine("/","var", "lib", "dhcp");
                System.Console.WriteLine("path to watch: " + path);
                // set path
                this.DhcpdLeasesFileWatcher.Path = path;
                // watch for changes in LastAccess and LastWrite times
                this.DhcpdLeasesFileWatcher.NotifyFilter = NotifyFilters.LastWrite;
                // only watch a specific file
                this.DhcpdLeasesFileWatcher.Filter = "dhcpd.leases";
                // add event handler
                this.DhcpdLeasesFileWatcher.Changed += new FileSystemEventHandler(OnDhcpdLeasesChanged);
                // start watching.
                this.DhcpdLeasesFileWatcher.EnableRaisingEvents = true;
            }
        }

        // eventhandler for filewatcher
        private void OnDhcpdLeasesChanged(object source, FileSystemEventArgs e)
        {
            System.Console.WriteLine("OnDhcpdLeasesChanged: " + e.FullPath.ToString());
            this.ReadDhcpdLeasesFile(e.FullPath);
        }
        
        private void ReadDhcpdLeasesFile(string filename)
        {
            System.Console.WriteLine("ReadDhcpdLeasesFile filename: " + filename);
            ReadDhcpdLeasesFileDelegate readDhcpdLeasesFileDelegate = new ReadDhcpdLeasesFileDelegate(ProcessDhcpdLeasesFile);
            IAsyncResult readDhcpdLeasesFileResult = readDhcpdLeasesFileDelegate.BeginInvoke(filename, parseDhcpdLeasesFile, null);
        }

        private ArrayList ProcessDhcpdLeasesFile(string filename)
        {
            System.Console.WriteLine("ProcessDhcpdLeasesFile filename: " + filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine(filename + " does not exist");
                return null;
            }
            using (StreamReader sr = File.OpenText(filename))
            {
                string input;
                ArrayList filecontent = new ArrayList();
                while ((input = sr.ReadLine()) != null)
                {
                    filecontent.Add(input);
                }
                return filecontent;
            }
        }

        private void parseDhcpdLeasesFile(IAsyncResult result)
        {
            AsyncResult aResult = (AsyncResult)result;
            ReadDhcpdLeasesFileDelegate readDhcpdLeasesFileDelegate = (ReadDhcpdLeasesFileDelegate)aResult.AsyncDelegate;
            ArrayList filecontent = readDhcpdLeasesFileDelegate.EndInvoke(result);
            System.Console.WriteLine("parseDhcpdLeasesFile filecontent: " + filecontent.ToString());
            ArrayList dhcpdLeasesList = new ArrayList();
            DhcpdLease dhcpdLease = new DhcpdLease();
            try
            {
                foreach (string line in filecontent)
                {
                    if (line.StartsWith("lease"))
                    {
                        dhcpdLease = new DhcpdLease();
                        int endindex = line.IndexOf("{") - 1;
                        int startindex = 6;
                        dhcpdLease.IPAddress = line.Substring(startindex, endindex - startindex);
                    }
                    else if (line.Contains("hardware ethernet"))
                    {
                        int endindex = line.IndexOf(";");
                        int startindex = line.IndexOf("hardware ethernet") + 18;
                        dhcpdLease.MACAddress = line.Substring(startindex, endindex - startindex);
                    }
                    else if (line.Contains("client-hostname"))
                    {
                        int endindex = line.IndexOf(";");
                        int startindex = line.IndexOf("client-hostname") + 16;
                        dhcpdLease.DeviceName = line.Substring(startindex, endindex - startindex);
                    }
                    else if (line.Contains("starts"))
                    {
                        int endindex = line.IndexOf(";");
                        int startindex = line.IndexOf("starts") + 9;
                        dhcpdLease.LeaseStart = line.Substring(startindex, endindex - startindex);
                    }
                    else if (line.Contains("ends"))
                    {
                        int endindex = line.IndexOf(";");
                        int startindex = line.IndexOf("ends") + 7;
                        dhcpdLease.LeaseEnd = line.Substring(startindex, endindex - startindex);
                    }
                    else if (line.Contains("}"))
                    {
                        dhcpdLeasesList.Add(dhcpdLease);
                        System.Console.WriteLine("new dhcpdLease: " + dhcpdLease.ToString());
                    }
                }
                this.settings.DhcpdLeases = dhcpdLeasesList;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("parseDhcpdLeasesFile ERROR " + e.ToString());
            }
        }
    }
}