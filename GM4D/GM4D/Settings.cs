using System;
using System.Collections.Generic;
using System.Text;

namespace GM4D
{
    public class Settings
    {
        public bool HostIpIsSet { get; private set; }
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
                this.HostIpIsSet = true;
            }
        }
        public bool HostSubnetMaskIsSet { get; private set; }
        private String hostSubnetMask;
        public String HostSubnetMask
        {
            get
            {
                return this.hostSubnetMask;
            }
            set
            {
                this.hostSubnetMask = value;
                this.HostSubnetMaskIsSet = true;
            }
        }
        public bool HostSubnetIsSet { get; private set; }
        private String hostSubnet;
        public String HostSubnet
        {
            get
            {
                return this.hostSubnet;
            }
            set
            {
                this.hostSubnet = value;
                this.HostSubnetIsSet = true;
            }
        }
        public bool IpRangeStartIsSet { get; private set; }
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
                this.IpRangeStartIsSet = true;
            }
        }
        public bool IpRangeEndIsSet { get; private set; }
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
                this.IpRangeEndIsSet = true;
            }
        }
        public bool SubnetIsSet { get; private set;}
        private String subnet;
        public String Subnet
        {
            get
            {
                if (SubnetIsSet)
                {
                    return this.subnet;
                }
                else
                {
                    return this.hostSubnet;
                }
            }
            set
            {
                this.subnet = value;
                SubnetIsSet = true;
            }
        }
        public bool SubnetMaskIsSet { get; private set; }
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
                this.SubnetMaskIsSet = true;
            }
        }
        public bool GatewayIsSet { get; private set; }
        private String gateway;
        public String Gateway
        {
            get
            {
                if (GatewayIsSet)
                {
                    return this.gateway;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                this.gateway = value;
                GatewayIsSet = true;
            }
        }
        public bool PrimaryDNSIsSet { get; private set; }
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
        public bool SecondaryDNSIsSet { get; private set; }
        private String secondaryDNS;
        public String SecondaryDNS
        {
            get
            {
                if (SecondaryDNSIsSet)
                {
                    return this.secondaryDNS;
                }
                else{
                    return "8.8.4.4";
                }
            }
            set
            {
                this.secondaryDNS = value;
                SecondaryDNSIsSet = true;
            }
        }
        public bool StaticLeasesIsSet { get; private set; }
        private System.Collections.ArrayList staticLeases;
        public System.Collections.ArrayList StaticLeases
        {
            get
            {
                if (StaticLeasesIsSet)
                {
                    return this.staticLeases;
                }
                else
                {
                    return new System.Collections.ArrayList {""};
                }
            }
            set
            {
                this.staticLeases = value;
                StaticLeasesIsSet = true;
            }
        }
        public bool DefaultLeaseTimeIsSet { get; private set; }
        private int defaultLeaseTime;
        public int DefaultLeaseTime
        {
            get
            {
                if (DefaultLeaseTimeIsSet)
                {
                    return this.defaultLeaseTime;
                }
                else
                {
                    return 600;
                }
            }
            set
            {
                this.defaultLeaseTime = value;
                DefaultLeaseTimeIsSet = true;
            }
        }
        public bool MaxLeaseTimeIsSet { get; private set; }
        private int maxLeaseTime;
        public int MaxLeaseTime
        {
            get
            {
                if (MaxLeaseTimeIsSet)
                {
                    return this.maxLeaseTime;
                }
                else
                {
                    return 7200;
                }
            }
            set
            {
                this.maxLeaseTime = value;
                MaxLeaseTimeIsSet = true;
            }
        }
        public Settings()
        {
            this.staticLeases = new System.Collections.ArrayList();
            this.PrimaryDNSIsSet = false;
            this.SecondaryDNSIsSet = false;
            this.StaticLeasesIsSet = false;
            this.SubnetIsSet = false;
            this.SubnetMaskIsSet = false;
            this.MaxLeaseTimeIsSet = false;
            this.GatewayIsSet = false;
            this.DefaultLeaseTimeIsSet = false;
            this.HostIpIsSet = false;
            this.HostSubnetMaskIsSet = false;
            this.HostSubnetIsSet = false;
            this.IpRangeStartIsSet = false;
            this.IpRangeEndIsSet = true;
        }
    }
}
