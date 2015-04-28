using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM4D
{
    public class HostNIC
    {
        public HostNIC()
        {
            this.Name = "";
            this.Id = "";
            this.Type = "";
            this.Ipv4Enabled = false;
            this.IPAddress = "";
            this.StaticIPAddress = false;
            this.SubnetIdentifier = "";
            this.SubnetMask = "";
            this.MacAddress = "";
            this.PrimaryDNS = "";
            this.SecondaryDNS = "";
            this.Gateway = "";
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public bool Ipv4Enabled { get; set; }
        public string IPAddress { get; set; }
        public bool StaticIPAddress { get; set; } 
        public string SubnetIdentifier { get; set; }
        public string SubnetMask { get; set; }
        public string MacAddress { get; set; }
        public string PrimaryDNS { get; set; }
        public string SecondaryDNS { get; set; }
        public string Gateway { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " ID: " + Id + " IPAddress: " + IPAddress + " Static: " + StaticIPAddress + " NetworkAddress: " + SubnetIdentifier + " SubnetMask: " + SubnetMask + " MACAddress: " + MacAddress + " DNS1: " + PrimaryDNS + " DNS2: " + SecondaryDNS + " Gateway: " + Gateway;
        }
    }
}
