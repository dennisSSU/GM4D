﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM4D
{
    public class StaticLease
    {
        public String DeviceName { get; set; }
        public String MACAddress { get; set; }
        public String IPAddress { get; set; }
        public String ID { get; set; }
        public StaticLease()
        {

        }
        public override string ToString()
        {
            return "Devicename: " + this.DeviceName + " ID: " + this.ID + " IPAddress: " + this.IPAddress + " MACAddress: " + this.MACAddress;
        }
    }
}
