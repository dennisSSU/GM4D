using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM4D
{
    class HostNIC
    {
        public HostNIC()
        {

        }
        public string Name { get; set; }
        public string Id { get; set; }
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
