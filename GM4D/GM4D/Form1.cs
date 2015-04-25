using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    partial class MainWindow : Form
    {
        #region Main
        private Settings settings;
        private IOController ioController;
        /// <summary>
        /// constructor for MainWindow
        /// </summary>
        /// <param name="_settings"></param>
        /// <param name="_ioCOntroller"></param>
        public MainWindow(Settings _settings, IOController _ioCOntroller)
        {
            InitializeComponent();
            this.settings = _settings;
            this.ioController = _ioCOntroller;
            this.settings.DhcpdLeasesChangedEvt += this.OnSettingsDhcpdLeasesChange;
            this.settings.StaticLeasesChangedEvt += this.StaticLeases_ListView_update;
            this.ioController.SettingsFileLoadedEvt += this.OnSettingsFileLoaded;
            this.ioController.UserIsSUChanged += this.OnUserIsSUChanged;
            this.ioController.OsIsUnixChanged += this.OnOsIsUnixChanged;
        }

        private void OnOsIsUnixChanged(object sender, EventArgs e)
        {
            if (!this.ioController.OsIsUnix)
            {
                MessageBox.Show("The current environment is not a Unix environment. Not all functions will be working.", "No Unix environment");
            }
        }

        private void OnUserIsSUChanged(object sender, EventArgs e)
        {
            if (!this.ioController.UserIsSU)
            {
                MessageBox.Show("Some features require root privilleges. Please run the application with sudo privilleges e.g. 'gksudo mono GM4D.exe'.", "No root privilleges");
            }
        }

        /// <summary>
        /// funtion called automatically after the MainWindow has loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MainWindow_Load(object sender, EventArgs e)
        {
            this.statusRequired.SetError(this.ipRangeStart_input, "this field is required");
            this.statusRequired.SetError(this.subnet_input, "this field is required");
            this.statusRequired.SetError(this.ipRangeEnd_input, "this field is required");
            this.statusRequired.SetError(this.subnetMask_input, "this field is required");
            //set source of databindings source
            this.settingsBindingSource.DataSource = settings;
            //listview staticleases
            ListViewExtender lve = new ListViewExtender(staticLeases_listview);
            ListViewButtonColumn lvbcEdit = new ListViewButtonColumn(4);
            lvbcEdit.Click += ListViewEditClick;
            lvbcEdit.FixedWidth = true;
            lve.AddColumn(lvbcEdit);
            ListViewButtonColumn lvbcDelete = new ListViewButtonColumn(5);
            lvbcDelete.Click += ListViewDeleteClick;
            lvbcDelete.FixedWidth = true;
            lve.AddColumn(lvbcDelete);
            //listview clients
            ListViewExtender clients_lve = new ListViewExtender(clients_dhcpdLeases_listView);
            ListViewButtonColumn clients_lvbc_addStatic = new ListViewButtonColumn(5);
            clients_lvbc_addStatic.Click += ClientsListviewAddStaticClick;
            clients_lvbc_addStatic.FixedWidth = true;
            clients_lve.AddColumn(clients_lvbc_addStatic);
        }
        #endregion Main

        #region MenuPanel
        private enum views {none,overview, settings, staticLeases, clients};
        private void switchView(views view)
        {
            this.overview_panelMain.Visible = false;
            this.settings_panelMain.Visible = false;
            this.staticLeases_panelMain.Visible = false;
            this.clients_panelMain.Visible = false;
            switch (view)
            {
                case views.overview: 
                    this.overview_panelMain.Visible = true;
                    break;
                case views.settings: 
                    this.settings_panelMain.Visible = true;
                    break;
                case views.staticLeases: 
                    this.staticLeases_panelMain.Visible = true;
                    break;
                case views.clients: 
                    this.clients_panelMain.Visible = true;
                    break;
                default: break;
            }
        }
        // region for the menue button handler

        /// <summary>
        /// first menue button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOverview_Click(object sender, EventArgs e)
        {
            switchView(views.overview);
        }
        /// <summary>
        /// second menue button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBasicSettings_Click(object sender, EventArgs e)
        {
            switchView(views.settings);
        }
        /// <summary>
        /// third menue button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStaticLeases_Click(object sender, EventArgs e)
        {
            switchView(views.staticLeases);
        }
        /// <summary>
        /// fourth menue button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClients_Click(object sender, EventArgs e)
        {
            switchView(views.clients);
        }
        #endregion MenuPanel

        #region OverviewPanel
        /// <summary>
        /// input validation for host ip address input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_validateIpInput(object sender, EventArgs e)
        {
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.settings.NewHostIP = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
            }
        }
        /// <summary>
        /// input validation for host subnet mask input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_validateSubnetMaskInput(object sender, EventArgs e)
        {
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid subnet mask");
                this.settings.NewHostSubnetMask = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid subnet mask");
            }
        }

        private void overview_hostip_btn_Click(object sender, EventArgs e)
        {
            this.overview_setHostIp_panel.Visible = true;
            ((Button)sender).Enabled = false;
            if (this.settings.HostIpIsSet && this.settings.HostSubnetMaskIsSet)
            {
                this.overview_setHostIp_ip_ipinput.Text = this.settings.HostIP;
                this.overview_setHostIp_subnetmask_ipinput.Text = this.settings.HostSubnetMask;
            }
        }

        private void overview_setHostIp_set_btn_Click(object sender, EventArgs e)
        {
            this.overview_setHostIp_ip_ipinput.Focus();
            this.overview_setHostIp_subnetmask_ipinput.Focus();
            this.overview_panelMain.Focus();
            if (this.settings.NewHostIpIsSet && this.settings.NewHostSubnetMaskIsSet)
            {
                try
                {
                    this.ioController.SetNewHostIp();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("This is only supported on a Unix machine.", exc.Message);
                }
                this.overview_hostip_btn.Enabled = true;
                this.overview_setHostIp_panel.Visible = false;
                this.validationStatus_error.SetError(this.overview_setHostIp_ip_ipinput, "");
                this.validationStatus_ok.SetError(this.overview_setHostIp_ip_ipinput, "");
                this.validationStatus_error.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
                this.validationStatus_ok.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
            }
            else
            {
                MessageBox.Show("Please enter valid IP address and subnetmask before saving");
            }
        }
        private void overview_setHostIp_cancel_btn_Click(object sender, EventArgs e)
        {
            this.overview_hostip_btn.Enabled = true;
            this.overview_setHostIp_panel.Visible = false;
            this.settings.NewHostIpIsSet = false;
            this.settings.NewHostSubnetMaskIsSet = false;
            this.overview_setHostIp_ip_ipinput.Clear();
            this.overview_setHostIp_subnetmask_ipinput.Clear();
            this.validationStatus_error.SetError(this.overview_setHostIp_ip_ipinput, "");
            this.validationStatus_ok.SetError(this.overview_setHostIp_ip_ipinput, "");
            this.validationStatus_error.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
            this.validationStatus_ok.SetError(this.overview_setHostIp_subnetmask_ipinput, "");
        }

        private void overview_dhcpServer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ioController.InstallDHCPServer();
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Failed to install DHCP server");
            }
        }

       

        private void overview_dhcpDeamon_btn_Click(object sender, EventArgs e)
        {
            if (this.settings.IsDHCPServerRunning)
            {
                try
                {
                    this.ioController.StopDHCPServer();
                    ((Button)sender).Text = "start";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "StopDHCPServer failed");
                }
            }
            else
            {
                try
                {
                    this.ioController.StartDHCPServer();
                    ((Button)sender).Text = "stop";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "StartDHCPServer failed");
                }
            }
        }
        #endregion OverviewPanel

        #region SettingsPanel
        private void settings_validateIpInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender,"");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                if (settings.HostNetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.HostIP, settings.HostSubnet))
                {
                    this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                    this.ipRangeStart_lblInfo.Text = "";
                    this.settings.IpRangeStart = ipAddress.ToString();
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.ipRangeStart_lblInfo.Text = "address is not in the same subnet as host ip";
                }
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.ipRangeStart_lblInfo.Text = "address is not a valid ip address";
            }
        }

        private void settings_validateIpRangeEndInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.ipRangeEnd_lblInfo.Text = "";
                this.settings.IpRangeEnd = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.ipRangeEnd_lblInfo.Text = "address is not a valid ip address";
            }
        }
        private void settings_validateSubnetInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.subnet_lblInfo.Text = "";
                this.settings.Subnet = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.subnet_lblInfo.Text = "address is not a valid ip address";
            }
        }
        private void settings_validateSubnetMaskInput(object sender, EventArgs e)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            System.Net.IPAddress ipAddress;
            // check if ip address is valid
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.subnetMask_lblInfo.Text = "";
                this.settings.SubnetMask = ipAddress.ToString();
                // automatically calculate and set subnet id
                if (this.settings.IpRangeStartIsSet)
                {
                    this.settings.DHCPNetCalcTool.calculate(this.settings.IpRangeStart, this.settings.SubnetMask);
                    this.settings.Subnet = this.settings.DHCPNetCalcTool.NetworkId;
                    this.settings_validateSubnetInput(this.subnet_input, new EventArgs());
                }
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.subnetMask_lblInfo.Text = "address is not a valid ip address";
            }
        }
        private void settings_validateGatewayInput(object sender, EventArgs e)
        {
            if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.gateway_lblInfo.Text = "";
                return;
            }
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.gateway_lblInfo.Text = "";
                this.settings.Gateway = ipAddress.ToString();
            }
            else
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.gateway_lblInfo.Text = "address is not a valid ip address";
            }
        }
        private void settings_validatePrimaryDNSInput(object sender, EventArgs e)
        {
            if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.primaryDNS_lblInfo.Text = "";
                return;
            }
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.primaryDNS_lblInfo.Text = "";
                this.settings.PrimaryDNS = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.primaryDNS_lblInfo.Text = "address is not a valid ip address";
            }
        }

        private void settings_validateSecondaryDNSInput(object sender, EventArgs e)
        {
            if (((IPAddressControlLib.IPAddressControl)sender).Text == "...")
            {
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.secondaryDNS_lblInfo.Text = "";
                return;
            }
            System.Net.IPAddress ipAddress;
            if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
            {
                this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                this.secondaryDNS_lblInfo.Text = "";
                this.settings.SecondaryDNS = ipAddress.ToString();
            }
            else
            {
                validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                this.secondaryDNS_lblInfo.Text = "address is not a valid ip address";
            }
        }
        public void OnSettingsFileLoaded(object sender, EventArgs ea)
        {
            if (this.settings_panelMain.InvokeRequired)
            {
                refreshSettingsCallback rc = new refreshSettingsCallback(refreshSettings);
                this.Invoke(rc);
            }
            else
            {
                refreshSettings();    
            }
        }
        private delegate void refreshSettingsCallback();
        private void refreshSettings()
        {
            this.ipRangeStart_input.Text = this.settings.IpRangeStart;
            this.ipRangeStart_input.Refresh();
            this.ipRangeStart_input.Focus();
            this.ipRangeEnd_input.Text = this.settings.IpRangeEnd;
            this.ipRangeEnd_input.Refresh();
            this.ipRangeEnd_input.Focus();
            this.subnetMask_input.Text = this.settings.SubnetMask;
            this.subnetMask_input.Refresh();
            this.subnetMask_input.Focus();
            this.gateway_input.Text = this.settings.Gateway;
            this.gateway_input.Refresh();
            this.gateway_input.Focus();
            this.primaryDNS_input.Text = this.settings.PrimaryDNS;
            this.primaryDNS_input.Refresh();
            this.primaryDNS_input.Focus();
            this.secondaryDNS_input.Text = this.settings.SecondaryDNS;            
            this.secondaryDNS_input.Refresh();
            this.secondaryDNS_input.Focus();
            this.subnet_input.Text = this.settings.Subnet;
            this.subnet_input.Refresh();
            this.subnet_input.Focus();
            this.ipRangeStart_input.Focus();
        }
        #endregion SettingsPanel

        #region MenuBottomPanel
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ioController.SaveSettingsFile(((SaveFileDialog)sender).FileName);
        }
        private void menuBottom_btnLoad_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ioController.LoadSettingsFile(((OpenFileDialog)sender).FileName);
        }

        private void menuBottom_btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                ioController.ApplySettingsToDHCPServer();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("This feature requires a Unix environment!");
            }
            
        }
        private void menuBottom_loadFromDhcp_Click(object sender, EventArgs e)
        {
            try
            {
                this.ioController.LoadSettingsFile("/etc/dhcp/dhcpd.conf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file /etc/dhcp/dhcpd.conf could not be loaded.\n" + ex.Message, "Failed to load dhcpd.conf");
            }
        }
        #endregion MenuBottomPanel

        #region Validation
        private void setValidationError (object sender, string message)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, message);
        }
        private void setValidationOk(object sender, string message)
        {
            this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
            this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, message);
        }
        #endregion Validation

        #region External
        public void ShowMessageBox(String text, String title)
        {
            MessageBox.Show(text, title);
        }
        #endregion External

        #region StaticLeases
        public void StaticLeases_ListView_update(object sender, PropertyChangedEventArgs e)
        {
            System.Console.WriteLine("StaticLeases_ListView_update");
            this.staticLeases_listview.Items.Clear();
            foreach (KeyValuePair<string, StaticLease> entry in this.settings.GetStaticLeases())
            {
                StaticLease staticLease = entry.Value;
                ListViewItem lvi = this.staticLeases_listview.Items.Add("" + staticLease.ID);
                lvi.SubItems.Add(staticLease.DeviceName);
                lvi.SubItems.Add(staticLease.MACAddress);
                lvi.SubItems.Add(staticLease.IPAddress);
                lvi.SubItems.Add("edit");
                lvi.SubItems.Add("delete");
            }
        }
        private void staticLeases_input_btn_add_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("staticLeases_input_btn_add_Click");
            StaticLease staticLease = new StaticLease();
            staticLease.IPAddress = staticLeases_input_tb_ip.Text;
            staticLease.MACAddress = staticLeases_input_tb_mac.Text;
            staticLease.DeviceName = staticLeases_input_tb_name.Text;
            staticLease.ID = (this.settings.GetStaticLeases().Count + 1).ToString();
            this.settings.AddStaticLease(staticLease);
            staticLeases_input_tb_name.Clear();
            staticLeases_input_tb_mac.Clear();
            staticLeases_input_tb_ip.Clear();
        }
        private string listviewitemid;
        private int listviewindex;
        private bool staticLeaseEditing = false;
        private void ListViewEditClick(object sender, ListViewColumnMouseEventArgs e)
        {
            staticLeaseEditing = true;
            listviewitemid = e.Item.Text;
            listviewindex = e.Item.Index;
            staticLeases_input_tb_name.Text = e.Item.SubItems[1].Text;
            staticLeases_input_tb_mac.Text = e.Item.SubItems[2].Text;
            System.Net.IPAddress ip;
            if (System.Net.IPAddress.TryParse(e.Item.SubItems[3].Text, out ip))
            {
                staticLeases_input_tb_ip.IPAddress = ip;
            }
            this.staticLeases_input_btn_add.Click -= staticLeases_input_btn_add_Click;            
            this.staticLeases_input_btn_add.Click += staticLeases_input_btn_saveEdit_Click;
        }
        private void staticLeases_input_btn_saveEdit_Click(object sender, EventArgs e)
        {
            StaticLease staticLease = new StaticLease();
            staticLease.IPAddress = staticLeases_input_tb_ip.Text;
            staticLease.MACAddress = staticLeases_input_tb_mac.Text;
            staticLease.DeviceName = staticLeases_input_tb_name.Text;
            staticLease.ID = listviewitemid;
            this.settings.AddStaticLease(staticLease);
            staticLeases_input_tb_name.Clear();
            staticLeases_input_tb_mac.Clear();
            staticLeases_input_tb_ip.Clear();
            this.staticLeases_input_btn_add.Click += staticLeases_input_btn_add_Click;
            this.staticLeases_input_btn_add.Click -= staticLeases_input_btn_saveEdit_Click;
            listviewitemid = null;
            staticLeaseEditing = false;
        }
        private void ListViewDeleteClick(object sender, ListViewColumnMouseEventArgs e)
        {
            System.Console.WriteLine("ListViewDeleteClick Item.Index: " + e.Item.Index);
            this.settings.RemoveStaticLease(e.Item.Text);
            if (staticLeaseEditing)
            {
                staticLeases_input_tb_name.Clear();
                staticLeases_input_tb_mac.Clear();
                staticLeases_input_tb_ip.Clear();
                this.staticLeases_input_btn_add.Click += staticLeases_input_btn_add_Click;
                this.staticLeases_input_btn_add.Click -= staticLeases_input_btn_saveEdit_Click;
                listviewitemid = null;
                staticLeaseEditing = false;
            }
        }
        #endregion StaticLeases
        #region DhcpdLeases
        public void OnSettingsDhcpdLeasesChange(object sender, PropertyChangedEventArgs e)
        {
            System.Console.WriteLine(System.DateTime.Now + " OnSettingsDhcpdLeasesChange called");
            updateDhcpdLeasesListView();
        }
        private void updateDhcpdLeasesListView()
        {
            clients_dhcpdLeases_listView.Items.Clear();
            foreach (KeyValuePair<string, DhcpdLease> entry in this.settings.DhcpdLeases)
            {
                DhcpdLease dhcpdLease = entry.Value;
                ListViewItem item = new ListViewItem(dhcpdLease.MACAddress);
                item.SubItems.Add(dhcpdLease.DeviceName);
                item.SubItems.Add(dhcpdLease.IPAddress);
                item.SubItems.Add(dhcpdLease.LeaseStart);
                item.SubItems.Add(dhcpdLease.LeaseEnd);
                item.SubItems.Add("add static lease");
                clients_dhcpdLeases_listView.Items.Add(item);
            }
            clients_dhcpdLeases_listView.Refresh();
        }
        public void ClientsListviewAddStaticClick(object sender, ListViewColumnMouseEventArgs e)
        {
            try
            {
                DhcpdLease dhcpLease = this.settings.DhcpdLeases[e.Item.Text];
                this.staticLeases_input_tb_ip.Text = dhcpLease.IPAddress;
                this.staticLeases_input_tb_mac.Text = dhcpLease.MACAddress;
                this.staticLeases_input_tb_name.Text = dhcpLease.DeviceName;
                switchView(views.staticLeases);
            }
            catch (Exception exep)
            {
                System.Console.WriteLine("ClientsListviewAddStaticClick " + exep.Message);
            }
        }
        #endregion DhcpdLeases

        
    }
}
