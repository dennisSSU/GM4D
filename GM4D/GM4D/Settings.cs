using System;
using System.Collections.Generic;
using System.Text;

namespace GM4D
{
    public class Settings
    {
        private String hostIP;
        public String HostIP
        {
            get
            {
                return this.hostIP;
            }
            set
            {
                this.hostIP = value;
            }
        }

        private String ipRangeStart;
        public String IpRangeStart
        {
            get
            {
                return this.ipRangeStart;
            }
            set
            {
                this.ipRangeStart = value;
            }
        }

        private String ipRangeEnd;
        public String IpRangeEnd
        {
            get
            {
                return this.ipRangeEnd;
            }
            set
            {
                this.ipRangeEnd = value;
            }
        }

        private String subnetMask;
        public String SubnetMask
        {
            get
            {
                return this.subnetMask;
            }
            set
            {
                this.subnetMask = value;
            }
        }

        private String networkID;
        public String NetworkID
        {
            get
            {
                return this.networkID;
            }
            set
            {
                this.networkID = value;
            }
        }

        private String gateway;
        public String Gateway
        {
            get
            {
                return this.gateway;
            }
            set
            {
                this.gateway = value;
            }
        }

        private String primaryDNS;
        public String PrimaryDNS
        {
            get
            {
                return this.primaryDNS;
            }
            set
            {
                this.primaryDNS = value;
            }
        }

        private String secondaryDNS;
        public String SecondaryDNS
        {
            get
            {
                return this.secondaryDNS;
            }
            set
            {
                this.secondaryDNS = value;
            }
        }

        private System.Collections.ArrayList staticLeases;
        public System.Collections.ArrayList StaticLeases
        {
            get
            {
                return this.staticLeases;
            }
            set
            {
                this.staticLeases = value;
            }
        }
        public Settings()
        {
            this.staticLeases = new System.Collections.ArrayList();
        }
    }
}
