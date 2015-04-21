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
        public int ID { get; set; }
        private static int i = 0;
        public DhcpdLease()
        {
            i++;
            this.ID = i;
        }
        public override string ToString()
        {
            return "Devicename: " + this.DeviceName + " ID: " + this.ID + " IPAddress: " + this.IPAddress + " MACAddress: " + this.MACAddress;
        }
    }
}
