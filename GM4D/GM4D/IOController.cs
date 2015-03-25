using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace GM4D
{
    class IOController
    {
        private Settings settings;
        private delegate void SaveSettingsToFileDelegate(String filename);
        public IOController(Settings _settings)
        {
            this.settings = _settings;
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
                "range " + settings.IpRangeStart + " " + settings.IpRangeEnd + ";" + Environment.NewLine;
            if (settings.GatewayIsSet)
            {
                dhcpConfig += "option gateway " + settings.Gateway + ";" + Environment.NewLine;
            }
            if (settings.PrimaryDNSIsSet)
            {
                dhcpConfig += "option domain-name-servers " + settings.PrimaryDNS;
                if (settings.SecondaryDNSIsSet)
                {
                    dhcpConfig += " " + settings.SecondaryDNS;
                }
                dhcpConfig += ";" + Environment.NewLine;
            }
            if (settings.StaticLeases.Count >= 1)
            {
                foreach (StaticLease l in settings.StaticLeases)
                {
                    dhcpConfig += "host " + l.DeviceName + " {" + Environment.NewLine +
                        "hardware ethernet " + l.MACAddress + ";" + Environment.NewLine +
                        "fixed-address " + l.IPAddress + ";" + Environment.NewLine +
                        "}" + Environment.NewLine;
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
        }

        public void GetHostInfo()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            foreach (NetworkInterface adapter in nics)
            {
                //check if adapter is up
                if (adapter.OperationalStatus != OperationalStatus.Up)
                {
                    continue;
                }
                //check if nic supports ipv4
                if (adapter.Supports(NetworkInterfaceComponent.IPv4) == false)
                {
                    continue;
                }
                // check if ipv4 setting are present
                if (adapter.GetIPProperties().GetIPv4Properties() == null)
                {
                    continue;
                }
                //create new HostNIC
                HostNIC nic = new HostNIC();
                nic.Name = adapter.Name;
                nic.Id = adapter.Id;
                nic.MacAddress = adapter.GetPhysicalAddress().ToString();
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
                            // IPv4Mask not implemented in mono (yet)
                            snetMask = unicastIPAddressInformation.IPv4Mask.ToString();
                        }
                        catch (NotImplementedException e)
                        {
                            // workaround to get subnetmask in unix using mono if IPv4Mask fails
                            snetMask = "";    
                            snetMask = SubnetMask.GetIPv4Mask(adapter.Name);
                        }
                        nic.SubnetMask = snetMask;
                    }
                }
                try
                {
                    IPAddressCollection dnsAddresses = adapter.GetIPProperties().DnsAddresses;
                    if (dnsAddresses.Count >= 1) nic.PrimaryDNS = dnsAddresses[0].ToString();
                    if (dnsAddresses.Count >= 2) nic.SecondaryDNS = dnsAddresses[0].ToString();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Errror in IOController getHostInfo - failed to get DNS server addresses - " + e);
                }
                NetCalcTool nct = settings.NetCalcTool;
                try
                {
                    nct.calculate(nic.IPAddress, nic.SubnetMask);
                    nic.SubnetIdentifier = nct.NetworkId;
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Errror in IOController getHostInfo - failed calculate network address - " + e);
                }
                settings.Interfaces.Add(nic);
                System.Console.WriteLine(nic);
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
                    Arguments = string.Format("-c \"service isc-dhcp-server status\"")
                };
                using (var p = System.Diagnostics.Process.Start(psi))
                {
                    if (p != null)
                    {
                        var strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        Console.WriteLine("\n\nGetDHCPServerStatus\n"+strOutput);
                        this.settings.OverviewDhcpServerStatus = strOutput.Split(' ')[1];
                        if (strOutput.Split(' ')[1].Contains("stop"))
                        {
                            this.settings.IsDHCPServerRunning = false;
                        }
                        else
                        {
                            this.settings.IsDHCPServerRunning = true;
                        }
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
                    Arguments = string.Format("-c \"service isc-dhcp-server start\"")
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
                    Arguments = string.Format("-c \"service isc-dhcp-server stop\"")
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
                throw new System.Exception("Error in IOController - StartDHCPServer - System is not a Unix environment");
            }
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
                    Arguments = string.Format("-c \"service isc-dhcp-server restart\"")
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
                throw new System.Exception("Error in IOController - StartDHCPServer - System is not a Unix environment");
            }
        }

        public void ReadDHCPDLeases()
        {

        }
    }
}