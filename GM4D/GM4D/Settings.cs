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
            this.staticLeases = new System.Collections.Generic.Dictionary<String, StaticLease>();
            this.dhcpdLeases = new System.Collections.Generic.Dictionary<String, DhcpdLease>();
            this.Interfaces = new ArrayList();
            this.HostNetCalcTool = new NetCalcTool();
            this.DHCPNetCalcTool = new NetCalcTool();
            ClearDHCPSettings();
            ClearHostSettings();
        }
        public void ClearDHCPSettings()
        {
            this.ipRangeStart = "";
            this.IpRangeStartIsSet = false;
            this.IpRangeEnd = "";
            this.IpRangeEndIsSet = false;
            this.Subnet = "";
            this.SubnetIsSet = false;
            this.SubnetMask = "";
            this.SubnetMaskIsSet = false;
            this.Gateway = "";
            this.GatewayIsSet = false;
            this.PrimaryDNS = "";
            this.PrimaryDNSIsSet = false;
            this.SecondaryDNS = "";
            this.SecondaryDNSIsSet = false;
            this.StaticLeases.Clear();
            this.StaticLeasesIsSet = false;
            this.DefaultLeaseTime = 600;
            this.DefaultLeaseTimeIsSet = false;
            this.MaxLeaseTime = 7200;
            this.MaxLeaseTimeIsSet = false;

        }
        public void ClearHostSettings()
        {
            this.HostIpIsSet = false;
            this.HostSubnetMaskIsSet = false;
            this.HostSubnetIsSet = false;
            this.HostNameIsSet = false;
            this.HostGatewayIsSet = false;
            this.NewHostIpIsSet = false;
            this.NewHostSubnetMaskIsSet = false;
        }
        //################################################################### eventhandling
        #region eventhandling
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler DhcpdLeasesChangedEvt;
        public event PropertyChangedEventHandler StaticLeasesChangedEvt;
        public event PropertyChangedEventHandler IsDHCPServerRunningChangedEvt;
        public event PropertyChangedEventHandler IsDHCPServerInstalledChangedEvt;
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
        //################################################################### interface selection
        #region interface selection
        public void selectInterface(int i)
        {
            if (i > (Interfaces.Count-1))
            {
                throw new IndexOutOfRangeException("Index for interface out of range. Index: " + i + " number of interfaces: " + Interfaces.Count);
            }
            HostNIC nic = (HostNIC)Interfaces[i];
            this.HostIP = nic.IPAddress;
            this.HostSubnetMask = nic.SubnetMask;
            this.HostSubnet = nic.SubnetIdentifier;
            this.HostHasStaticIp = nic.StaticIPAddress;
            this.SelectedInterface = i;
            IOController.Log(this, nic.ToString(), IOController.Flag.status);
        }
        private ArrayList interfaces;
        public ArrayList Interfaces 
        {
            get
            {
                return this.interfaces;
            }
            private set
            {
                this.interfaces = value;
            }
        }
        public void AddInterface(HostNIC nic)
        {
            this.interfaces.Add(nic);
            IOController.Log(this, "Added Interface:\n" + nic.ToString() + "\n", IOController.Flag.status);
        }
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
                IOController.Log(this, " " + this.selectedInterface, IOController.Flag.status);
            }
        }
        #endregion interface selection
        //################################################################### host
        #region host
        public NetCalcTool HostNetCalcTool { get; set; }

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
                IOController.Log(this, this.hostIP, IOController.Flag.debug);
            }
        }
        public bool NewHostIpIsSet { get; set; }
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
                IOController.Log(this, this.newHostIP, IOController.Flag.debug);
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
                IOController.Log(this, this.hostName, IOController.Flag.debug);
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
                IOController.Log(this, this.hostSubnetMask, IOController.Flag.debug);
            }
        }
        public bool NewHostSubnetMaskIsSet { get; set; }
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
                IOController.Log(this, this.newHostSubnetMask, IOController.Flag.debug);
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
                IOController.Log(this, this.hostSubnet, IOController.Flag.debug);
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
                IOController.Log(this, this.hostGateway, IOController.Flag.debug);
            }
        }
        #endregion host
        //################################################################### network
        #region network
        public NetCalcTool DHCPNetCalcTool { get; set; }
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
                IOController.Log(this, this.ipRangeStart, IOController.Flag.debug);
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
                if (this.GatewayIsSet)
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
                if (value.Length > 3)
                {
                    this.gateway = value;
                    this.GatewayIsSet = true;
                    NotifyPropertyChanged(this.Gateway);
                }
                else
                {
                    this.GatewayIsSet = false;
                }
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
                if (value.Length > 3)
                {
                    this.primaryDNS = value;
                    this.PrimaryDNSIsSet = true;
                    NotifyPropertyChanged(PrimaryDNS);
                }
                else
                {
                    this.PrimaryDNSIsSet = false;
                }
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
                if (value.Length > 3)
                {
                    this.secondaryDNS = value;
                    this.SecondaryDNSIsSet = true;
                    NotifyPropertyChanged(SecondaryDNS);
                }
                else
                {
                    this.SecondaryDNSIsSet = false;
                }
            }
        }
        public bool StaticLeasesIsSet { get; private set; }
        private System.Collections.Generic.Dictionary<String, StaticLease> staticLeases;
        public System.Collections.Generic.Dictionary<String, StaticLease> StaticLeases
        {
            get
            {
                return this.staticLeases;
            }
            private set
            {
                this.staticLeases = value;
                StaticLeasesChangedEvt(this, new PropertyChangedEventArgs("StaticLeases"));
            }
        }
        public System.Collections.Generic.Dictionary<String, StaticLease> GetStaticLeases()
        {
                return this.staticLeases;
        }
        public void AddStaticLease(StaticLease staticLease)
        {
            this.staticLeases[staticLease.ID] = staticLease;
            this.StaticLeasesIsSet = true;
            StaticLeasesChangedEvt(this, new PropertyChangedEventArgs("StaticLeases"));
        }
        public void RemoveStaticLease(string ID)
        {
            this.staticLeases.Remove(ID);
            StaticLeasesChangedEvt(this, new PropertyChangedEventArgs("StaticLeases"));
            if (this.staticLeases.Count <= 0)
            {
                this.StaticLeasesIsSet = false;
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
        //################################################################### StaticLeases
        public bool DhcpdLeasesIsSet { get; private set; }
        private System.Collections.Generic.Dictionary<String, DhcpdLease> dhcpdLeases;
        public System.Collections.Generic.Dictionary<String, DhcpdLease> DhcpdLeases
        {
            get
            {
                return this.dhcpdLeases;
            }
            set
            {
                this.dhcpdLeases = value;
                if (DhcpdLeasesChangedEvt != null)
                {
                    DhcpdLeasesChangedEvt(this.dhcpdLeases, new PropertyChangedEventArgs("DhcpdLeases"));
                }
                IOController.Log(this, "DhcpdLeases set", IOController.Flag.debug);
            }
        }
        public void AddDhcpdLease(DhcpdLease dhcpdLease)
        {
            this.dhcpdLeases.Add(dhcpdLease.MACAddress, dhcpdLease);
            DhcpdLeasesChangedEvt(this.dhcpdLeases, new PropertyChangedEventArgs("DhcpdLeases"));
        }
        public void RemoveDhcpdLease(string macaddress)
        {
            this.dhcpdLeases.Remove(macaddress);
            DhcpdLeasesChangedEvt(this.dhcpdLeases, new PropertyChangedEventArgs("DhcpdLeases"));
        }
        #endregion network
        //################################################################### GUIStatus
        #region GUIStatus
        private bool isDHCPServerRunning;
        public bool IsDHCPServerRunning 
        {
            get 
            {
                return this.isDHCPServerRunning;
            }
            set 
            {
                this.isDHCPServerRunning = value;
                if (IsDHCPServerRunningChangedEvt != null)
                {
                    IsDHCPServerRunningChangedEvt(this.isDHCPServerRunning, new PropertyChangedEventArgs("IsDHCPServerRunning"));
                }
            } 
        }
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
        private bool isDHCPServerInstalled;
        public bool IsDHCPServerInstalled
        {
            get
            {
                return this.isDHCPServerInstalled;
            }
            set
            {
                this.isDHCPServerInstalled = value;
                if (IsDHCPServerInstalledChangedEvt != null)
                {
                    IsDHCPServerInstalledChangedEvt(this.isDHCPServerInstalled, new PropertyChangedEventArgs("IsDHCPServerInstalled"));
                }
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
    }
}
