using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM4D
{
    class StaticLease
    {
        public String DeviceName { get; set; }
        public String MACAddress { get; set; }
        public String IPAddress { get; set; }
        public int ID { get; set; }
        public StaticLease(int _id, String _DeviceName, String _MACAddress, String _IPAddress)
        {
            this.ID = _id;
            this.DeviceName = _DeviceName;
            this.MACAddress = _MACAddress;
            this.IPAddress = _IPAddress;
        }
    }
}
