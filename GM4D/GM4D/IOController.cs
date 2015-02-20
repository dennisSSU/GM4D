using System;
using System.Collections.Generic;
using System.Linq;
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
            IAsyncResult saveSettingsToFileResult = saveSettingsToFileDelegate.BeginInvoke(filename, saveSettingsToFileComplete, null);
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
            dhcpConfig += "}";
            return dhcpConfig;
        } 
        public static void saveSettingsToFileComplete(IAsyncResult result)
        {
        }

        public void LoadSettingsFile(String filename)
        {

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
                throw new System.Exception("not a Unix environment");
            }
        }
    }
}
