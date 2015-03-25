using System;
using System.Collections;
using System.ComponentModel;
using System.Text;

namespace GM4D
{
    public class Settings : INotifyPropertyChanged 
    {
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
            this.IpRangeEndIsSet = false;
            this.HostNameIsSet = false;
            this.HostGatewayIsSet = false;
            this.NewHostIpIsSet = false;
            this.NewHostSubnetMaskIsSet = false;
            this.Interfaces = new ArrayList();
            this.NetCalcTool = new NetCalcTool();
        }
        #region eventhandling
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value));
            }
        }
        private void NotifyPropertyChanged(int value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value.ToString()));
            }
        }
        #endregion eventhandling
        #region interface selection
        public void selectInterface(int i)
        {
            if (i >= Interfaces.Count)
            {
                throw new IndexOutOfRangeException("Index for interface out of range. Index: " + i + " number of interfaces: " + Interfaces.Count);
            }
            HostNIC nic = (HostNIC)Interfaces[i];
            this.HostIP = nic.IPAddress;
            this.HostSubnetMask = nic.SubnetMask;
            this.HostSubnet = nic.SubnetIdentifier;
            this.HostHasStaticIp = nic.StaticIPAddress;
            this.SelectedInterface = i;
        }
        public ArrayList Interfaces { get; set; }
        private int selectedInterface;
        public int SelectedInterface
        {
            get
            {
                return this.selectedInterface;
            }
            private set
            {
                this.selectedInterface = value;
                NotifyPropertyChanged(this.SelectedInterface);
            }
        }
        #endregion interface selection
        #region host
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
                NotifyPropertyChanged(this.HostIP);
            }
        }
        public bool NewHostIpIsSet { get; private set; }
        private String newHostIP;
        public String NewHostIP
        {
            get
            {
                return this.newHostIP;
            }
            set
            {
                this.newHostIP = value;
                this.NewHostIpIsSet = true;
                NotifyPropertyChanged(this.NewHostIP);
            }
        }
        private bool hostHasStaticIp;
        public bool HostHasStaticIp 
        {
            get 
            {
                return this.hostHasStaticIp;
            } 
            set
            {
                this.hostHasStaticIp = value;
                if (hostHasStaticIp)
                {
                    this.OverviewDhcpStatus = "static";
                }
                else
                {
                    this.OverviewDhcpStatus = "dynamic";
                }
            }
        }
        public bool HostNameIsSet { get; private set; }
        private String hostName;
        public String HostName
        {
            get
            {
                return this.hostName;
            }
            set
            {
                this.hostName = value;
                this.HostNameIsSet = true;
                NotifyPropertyChanged(this.HostName);
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
                NotifyPropertyChanged(HostSubnetMask);
            }
        }
        public bool NewHostSubnetMaskIsSet { get; private set; }
        private String newHostSubnetMask;
        public String NewHostSubnetMask
        {
            get
            {
                return this.newHostSubnetMask;
            }
            set
            {
                this.newHostSubnetMask = value;
                this.NewHostSubnetMaskIsSet = true;
                NotifyPropertyChanged(NewHostSubnetMask);
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
                NotifyPropertyChanged(HostSubnet);
            }
        }
        public bool HostGatewayIsSet { get; private set; }
        private String hostGateway;
        public String HostGateway
        {
            get
            {
                return this.hostGateway;
            }
            set
            {
                this.hostGateway = value;
                this.HostGatewayIsSet = true;
                NotifyPropertyChanged(this.HostGateway);
            }
        }
        #endregion host
        #region network
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
                NotifyPropertyChanged(IpRangeStart);
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
                NotifyPropertyChanged(IpRangeEnd);
            }
        }
        public bool SubnetIsSet { get; private set;}
        private String subnet;
        public String Subnet
        {
            get
            {
                return this.subnet;
            }
            set
            {
                this.subnet = value;
                SubnetIsSet = true;
                NotifyPropertyChanged(Subnet);
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
                NotifyPropertyChanged(SubnetMask);
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
                NotifyPropertyChanged(Gateway);
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
                this.PrimaryDNSIsSet = true;
                NotifyPropertyChanged(PrimaryDNS);
            }
        }
        public bool SecondaryDNSIsSet { get; private set; }
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
                this.SecondaryDNSIsSet = true;
                NotifyPropertyChanged(SecondaryDNS);
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
                this.StaticLeasesIsSet = true;
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
                NotifyPropertyChanged(DefaultLeaseTime);
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
                NotifyPropertyChanged(MaxLeaseTime);
            }
        }
        public bool IsDHCPServerRunning { get; set; }
        #endregion network
        #region GUIStatus
        private string overviewDhcpStatus;
        public String OverviewDhcpStatus
        {
            get
            {
                return this.overviewDhcpStatus;
            }
            set
            {
                this.overviewDhcpStatus = value;
                NotifyPropertyChanged(this.OverviewDhcpStatus);
            }
        }
        private String overviewDhcpServerInstallStatus;
        public String OverviewDhcpServerInstallStatus
        {
            get
            {
                return this.overviewDhcpServerInstallStatus;
            }
            set
            {
                this.overviewDhcpServerInstallStatus = value;
                NotifyPropertyChanged(this.OverviewDhcpServerInstallStatus);
            }
        }
        private String overviewDhcpServerStatus;
        public String OverviewDhcpServerStatus
        {
            get
            {
                return this.overviewDhcpServerStatus;
            }
            set
            {
                this.overviewDhcpServerStatus = value;
                NotifyPropertyChanged(this.OverviewDhcpServerStatus);
            }
        }
        #endregion GUIStatus
        public NetCalcTool NetCalcTool { get; set; }

        public const string test = "this is a test";
    }
}
