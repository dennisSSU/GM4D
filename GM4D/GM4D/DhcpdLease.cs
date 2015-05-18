using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * Filename: DhcpdLease.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: object for leases issued by the dhcpd service
 */
namespace GM4D
{
    /// <summary>
    /// object for leases issued by the dhcpd service
    /// </summary>
    public class DhcpdLease
    {
        /// <summary>
        /// hostname of the device (optional)
        /// </summary>
        public String DeviceName { get; set; }
        /// <summary>
        /// unique hardware (MAC) address as string in format "00:00:00:00"
        /// </summary>
        public String MACAddress { get; set; }
        /// <summary>
        /// IP address as string
        /// </summary>
        public String IPAddress { get; set; }
        /// <summary>
        /// lease start, date/time as string in format "YYYY/MM/DD hh:mm:ss"
        /// </summary>
        public String LeaseStart { get; set; }
        /// <summary>
        /// lease end, date/time as string in format "YYYY/MM/DD hh:mm:ss"
        /// </summary>
        public String LeaseEnd { get; set; }
        /// <summary>
        /// binding state from dhcpd.leases ("actice" if in use or "free" if not)
        /// </summary>
        public String LeaseState { get; set; }
        public DhcpdLease()
        {

        }
        public override string ToString()
        {
            return "Devicename: " + this.DeviceName + " IPAddress: " + this.IPAddress + " MACAddress: " + this.MACAddress + " LeaseStart: " + this.LeaseStart + " LeaseEnd: " + this.LeaseEnd + " LeaseActive: " + this.LeaseState;
        }
    }
}
