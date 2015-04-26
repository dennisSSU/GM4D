using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM4D
{
    public class DhcpdLease
    {
        public String DeviceName { get; set; }
        public String MACAddress { get; set; }
        public String IPAddress { get; set; }
        public String LeaseStart { get; set; }
        public String LeaseEnd { get; set; }
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
