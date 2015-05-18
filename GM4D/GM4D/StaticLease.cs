using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * Filename: StaticLease.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: static lease object, contains information about a static lease
 */
namespace GM4D
{
    /// <summary>
    /// static lease object, contains information about a static lease
    /// </summary>
    public class StaticLease
    {
        /// <summary>
        /// device name as string (free chosseable)
        /// </summary>
        public String DeviceName { get; set; }
        /// <summary>
        /// MAC address as string in format 00:00:00:00
        /// </summary>
        public String MACAddress { get; set; }
        /// <summary>
        /// IPv4 address as string
        /// </summary>
        public String IPAddress { get; set; }
        /// <summary>
        /// unique id of lease client
        /// </summary>
        public String ID { get; set; }
        /// <summary>
        /// static lease object, contains information about a static lease
        /// </summary>
        public StaticLease()
        {

        }
        public override string ToString()
        {
            return "Devicename: " + this.DeviceName + " ID: " + this.ID + " IPAddress: " + this.IPAddress + " MACAddress: " + this.MACAddress;
        }
    }
}
