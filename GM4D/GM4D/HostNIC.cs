using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * Filename: HostNIC.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: object to store all related information for a host network interface
 */
namespace GM4D
{
    /// <summary>
    /// object representing a host network interface
    /// </summary>
    public class HostNIC
    {
        /// <summary>
        /// object representing a host network interface
        /// </summary>
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
        /// <summary>
        /// name of the interface
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// unique id of the interface
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// type of the interface (e.g. loopback...)
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// IPv4 enabled status
        /// </summary>
        public bool Ipv4Enabled { get; set; }
        /// <summary>
        /// IPv4 address as string
        /// </summary>
        public string IPAddress { get; set; }
        /// <summary>
        /// boll if the ip address is confiogured static (static = true)
        /// </summary>
        public bool StaticIPAddress { get; set; } 
        /// <summary>
        /// IPv4 subnet address as string
        /// </summary>
        public string SubnetIdentifier { get; set; }
        /// <summary>
        /// IPv4 subnet mask as string
        /// </summary>
        public string SubnetMask { get; set; }
        /// <summary>
        /// MAC address in format (00:00:00:00)
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// IPv4 address of primary DNS
        /// </summary>
        public string PrimaryDNS { get; set; }
        /// <summary>
        /// IPv4 address of secondary DNS
        /// </summary>
        public string SecondaryDNS { get; set; }
        /// <summary>
        /// IPv4 address of gateway
        /// </summary>
        public string Gateway { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + " ID: " + Id + " IPAddress: " + IPAddress + " Static: " + StaticIPAddress + " NetworkAddress: " + SubnetIdentifier + " SubnetMask: " + SubnetMask + " MACAddress: " + MacAddress + " DNS1: " + PrimaryDNS + " DNS2: " + SecondaryDNS + " Gateway: " + Gateway;
        }
    }
}
