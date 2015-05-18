using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
/* 
 * Filename: Settings.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: storage object, contains host settings, network settings and GUI settings
 */
namespace GM4D
{
    /// <summary>
    /// storage object, contains host settings, network settings and GUI settings
    /// </summary>
    public class Settings : INotifyPropertyChanged
    {
        // main region (constructor etc.)
        #region main
        //################################################################### main
        /// <summary>
        /// storage object, contains host settings, network settings and GUI settings
        /// </summary>
        public Settings()
        {
            this.staticLeases = new System.Collections.Generic.Dictionary<String, StaticLease>();
            this.dhcpdLeases = new System.Collections.Generic.Dictionary<String, DhcpdLease>();
            this.Interfaces = new ArrayList();
            this.HostNetCalcTool = new NetCalcTool();
            this.DHCPNetCalcTool = new NetCalcTool();
            ClearDHCPSettings();
            ClearHostSettings();
            this.overviewDhcpServerInstallStatus = "no status";
            this.overviewDhcpServerStatus = "no status";
        }
        /// <summary>
        /// cleares all DHCP related settings and set the isset properties to false
        /// </summary>
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
        /// <summary>
        /// cleares all host related settings and set the isset properties to false
        /// </summary>
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
        #endregion main
        // region for event handling
        #region eventhandling
        //################################################################### eventhandling
        /// <summary>
        /// occures when a property of settings changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// occurs when dhcpd leases change
        /// </summary>
        public event PropertyChangedEventHandler DhcpdLeasesChangedEvt;
        /// <summary>
        /// occurs when static leases change
        /// </summary>
        public event PropertyChangedEventHandler StaticLeasesChangedEvt;
        /// <summary>
        /// occurs when dhcp running status changes
        /// </summary>
        public event PropertyChangedEventHandler IsDHCPServerRunningChangedEvt;
        /// <summary>
        /// occurs when dhcp install status changes
        /// </summary>
        public event PropertyChangedEventHandler IsDHCPServerInstalledChangedEvt;
        /// <summary>
        /// occurs when interface is added
        /// </summary>
        public event PropertyChangedEventHandler InterfaceAddedEvt;
        /// <summary>
        /// raises the propertychanged event for string properties
        /// </summary>
        /// <param name="value">name of property</param>
        private void NotifyPropertyChanged(String value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value));
            }
        }
        /// <summary>
        /// raises the propertychanged event for int properties
        /// </summary>
        /// <param name="value">property name</param>
        private void NotifyPropertyChanged(int value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value.ToString()));
            }
        }
        #endregion eventhandling
        // region for interface selection
        #region interface selection
        //################################################################### interface selection
        /// <summary>
        /// selects the inface with the given index 
        /// </summary>
        /// <param name="i">index of the interface</param>
        public void SelectInterface(int i)
        {
            if (i < Interfaces.Count)
            {
                IOController.Log(this, "SelectInterface called index:" + i, IOController.Flag.debug);
                HostNIC nic = (HostNIC)Interfaces[i];
                this.HostIP = nic.IPAddress;
                this.HostSubnetMask = nic.SubnetMask;
                this.HostSubnet = nic.SubnetIdentifier;
                this.HostHasStaticIp = nic.StaticIPAddress;
                this.HostGateway = nic.Gateway;
                this.SelectedInterfaceIndex = i;
                this.SelectedInterfaceID = nic.Id;
                IOController.Log(this, "SelectInterface ID" + nic.Id, IOController.Flag.debug);
                this.OverviewSelectedInterfaceName = nic.Name;
                IOController.Log(this, nic.ToString(), IOController.Flag.status);
            }
            else
            {
                IOController.Log(this, "SelectInterface IndexOutOfRange index:" + i, IOController.Flag.error);
            }
        }
        private ArrayList interfaces;
        /// <summary>
        /// arraylist of all interfaces as HostNIC objects
        /// </summary>
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
        /// <summary>
        /// adds a new HoatNIC to the arraylist
        /// </summary>
        /// <param name="nic">interface as HostNIC</param>
        public void AddInterface(HostNIC nic)
        {
            this.interfaces.Add(nic);
            IOController.Log(this, "Added Interface at " + (this.interfaces.Count - 1) + ":\n" + nic.ToString() + "\n", IOController.Flag.status);
            if (InterfaceAddedEvt != null)
            {
                InterfaceAddedEvt(this.interfaces, new PropertyChangedEventArgs("InterfaceAdded"));
            }
        }
        /// <summary>
        /// ID of the currently selected interface
        /// </summary>
        public string SelectedInterfaceID { get; set; }
        private int selectedInterfaceIndex;
        /// <summary>
        /// index of the currently selected interface
        /// </summary>
        public int SelectedInterfaceIndex
        {
            get
            {
                return this.selectedInterfaceIndex;
            }
            private set
            {
                this.selectedInterfaceIndex = value;
                NotifyPropertyChanged(this.selectedInterfaceIndex);
                IOController.Log(this, " " + this.SelectedInterfaceIndex, IOController.Flag.status);
            }
        }
        #endregion interface selection
        // region for host related settings
        #region host
        //################################################################### host
        /// <summary>
        /// netcalctool for host related calculations
        /// </summary>
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
                if (value.Length > 0)
                {
                    this.hostName = value;
                    this.HostNameIsSet = true;
                }
                else
                {
                    this.HostNameIsSet = false;
                }
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
                System.Net.IPAddress ip;
                if (System.Net.IPAddress.TryParse(value, out ip))
                {
                    this.hostSubnetMask = ip.ToString();
                    this.HostSubnetMaskIsSet = true;
                }
                else
                {
                    this.HostSubnetMaskIsSet = false;
                }
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
                System.Net.IPAddress ip;
                if (System.Net.IPAddress.TryParse(value, out ip))
                {
                    this.newHostSubnetMask = ip.ToString();
                    this.NewHostSubnetMaskIsSet = true;
                }
                else
                {
                    this.NewHostSubnetMaskIsSet = false;
                }
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
                System.Net.IPAddress ip;
                if (System.Net.IPAddress.TryParse(value, out ip))
                {
                    this.hostSubnet = ip.ToString();
                    this.HostSubnetIsSet = true;
                }
                else
                {
                    this.HostSubnetIsSet = false;
                }
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
                System.Net.IPAddress ip;
                if (System.Net.IPAddress.TryParse(value, out ip))
                {
                    this.hostGateway = ip.ToString();
                    this.HostGatewayIsSet = true;
                }
                else
                {
                    this.HostGatewayIsSet = false;
                }
                NotifyPropertyChanged(this.HostGateway);
                IOController.Log(this, this.hostGateway, IOController.Flag.debug);
            }
        }
        #endregion host
        // region for settings related to dhcp server network
        #region network
        //################################################################### network
        /// <summary>
        /// netcalctool for dhcp related calculations
        /// </summary>
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
                if (value.Length > 7)
                {
                    this.ipRangeStart = value;
                    this.IpRangeStartIsSet = true;
                    
                }
                else
                {
                    this.IpRangeStartIsSet = true;
                }
                NotifyPropertyChanged(IpRangeStart);
                IOController.Log(this, value, IOController.Flag.debug);
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
        /// <summary>
        /// dictionary collection of static leases as StaticLease objects
        /// </summary>
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
        /// <summary>
        /// returns all satic leases
        /// </summary>
        /// <returns></returns>
        public System.Collections.Generic.Dictionary<String, StaticLease> GetStaticLeases()
        {
                return this.staticLeases;
        }
        /// <summary>
        /// adds a new static lease to the dictionary collection
        /// </summary>
        /// <param name="staticLease">StaticLease object</param>
        public void AddStaticLease(StaticLease staticLease)
        {
            this.staticLeases[staticLease.MACAddress] = staticLease;
            this.StaticLeasesIsSet = true;
            StaticLeasesChangedEvt(this, new PropertyChangedEventArgs("StaticLeases"));
        }
        /// <summary>
        /// removes a static lease from the collection
        /// </summary>
        /// <param name="MacAdress">mac address of lease to remove</param>
        public void RemoveStaticLease(string MacAdress)
        {
            this.staticLeases.Remove(MacAdress);
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
        /// <summary>
        /// dictionary collection of all issued leases as DhcpdLease objects
        /// </summary>
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
        /// <summary>
        /// adds a new DhcpdLease to the collection
        /// </summary>
        /// <param name="dhcpdLease">DhcpdLease object</param>
        public void AddDhcpdLease(DhcpdLease dhcpdLease)
        {
            this.dhcpdLeases.Add(dhcpdLease.MACAddress, dhcpdLease);
            DhcpdLeasesChangedEvt(this.dhcpdLeases, new PropertyChangedEventArgs("DhcpdLeases"));
        }
        /// <summary>
        /// removes a lease from the collection
        /// </summary>
        /// <param name="macaddress">Mac address of lease to remove</param>
        public void RemoveDhcpdLease(string macaddress)
        {
            this.dhcpdLeases.Remove(macaddress);
            DhcpdLeasesChangedEvt(this.dhcpdLeases, new PropertyChangedEventArgs("DhcpdLeases"));
        }
        #endregion network
        // region for GUI specific settings
        #region GUIStatus
        //################################################################### GUIStatus
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
        /// <summary>
        /// install status of dhcp server as string for the gui
        /// </summary>
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
        /// <summary>
        /// status of dhcp server as string for the gui
        /// </summary>
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
        private string overviewSelectedInterfaceName;
        /// <summary>
        /// selected interface as string for the gui
        /// </summary>
        public string OverviewSelectedInterfaceName
        {
            get
            {
                return this.overviewSelectedInterfaceName;
            }
            set
            {
                this.overviewSelectedInterfaceName = value;
                NotifyPropertyChanged(this.overviewSelectedInterfaceName);
            }
        }
        #endregion GUIStatus
    }
}
