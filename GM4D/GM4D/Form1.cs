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
            this.settings.IsDHCPServerInstalledChangedEvt += OnIsDHCPServerInstalledChange;
            this.settings.IsDHCPServerRunningChangedEvt += OnIsDHCPServerRunningChange;
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
            settingsValidateAllInputs();
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
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        /// <summary>
        /// input validation for host subnet mask input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overview_validateSubnetMaskInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }

        private void overview_hostip_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.overview_setHostIp_panel.Visible = true;
                ((Button)sender).Enabled = false;
                if (this.settings.HostIpIsSet && this.settings.HostSubnetMaskIsSet)
                {
                    this.overview_setHostIp_ip_ipinput.Text = this.settings.HostIP;
                    this.overview_setHostIp_subnetmask_ipinput.Text = this.settings.HostSubnetMask;
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }

        private void overview_setHostIp_set_btn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void overview_setHostIp_cancel_btn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }

        private void overview_dhcpServer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ioController.InstallDHCPServer();
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Failed to install DHCP server");
            }
        }
        private void overview_dhcpDeamon_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.settings.IsDHCPServerRunning)
                {
                    try
                    {
                        this.ioController.StopDHCPServer();
                    }
                    catch (Exception exc)
                    {
                        IOController.Log(this, exc.Message, IOController.Flag.error);
                        MessageBox.Show("StopDHCPServer failed");
                    }
                }
                else
                {
                    try
                    {
                        this.ioController.StartDHCPServer();
                    }
                    catch (Exception exc)
                    {
                        IOController.Log(this, exc.Message, IOController.Flag.error);
                        MessageBox.Show(exc.Message, "StartDHCPServer failed");
                    }
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        public void OnIsDHCPServerInstalledChange(object sender, PropertyChangedEventArgs e)
        {
            if (this.overview_dhcpServer_btn.InvokeRequired)
            {
                changeDhcpServerInstallButtonCallback cb = new changeDhcpServerInstallButtonCallback(changeDhcpServerInstallButton);
                this.Invoke(cb);
            }
            else
            {
                changeDhcpServerInstallButton();
            }
        }
        private delegate void changeDhcpServerInstallButtonCallback();
        private void changeDhcpServerInstallButton()
        {
            try
            {
                if (this.settings.IsDHCPServerInstalled)
                {
                    this.overview_dhcpServer_btn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        public void OnIsDHCPServerRunningChange(object sender, PropertyChangedEventArgs e)
        {
            if (this.overview_dhcpDeamon_btn.InvokeRequired)
            {
                changeDhcpServerRunningButtonCallback cb = new changeDhcpServerRunningButtonCallback(changeDhcpServerRunningButton);
                this.Invoke(cb);
            }
            else
            {
                changeDhcpServerRunningButton();
            }
        }
        private delegate void changeDhcpServerRunningButtonCallback();
        private void changeDhcpServerRunningButton()
        {
            try
            {
                if (this.settings.IsDHCPServerRunning)
                {
                    this.overview_dhcpDeamon_btn.Text = "stop";
                    this.overview_dhcpDeamon_status_lbl.Text = "running";
                }
                else
                {
                    this.overview_dhcpDeamon_btn.Text = "start";
                    this.overview_dhcpDeamon_status_lbl.Text = "stopped";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        #endregion OverviewPanel

        #region SettingsPanel
        private void settings_validateIpInput(object sender, EventArgs e)
        {
            try
            {
                this.statusRequired.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                System.Net.IPAddress ipAddress;
                if (System.Net.IPAddress.TryParse(((IPAddressControlLib.IPAddressControl)sender).Text, out ipAddress))
                {
                    if (settings.HostNetCalcTool.CheckSameSubnet(ipAddress.ToString(), settings.HostIP, settings.HostSubnet))
                    {
                        this.validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                        this.validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "valid IP address");
                        this.ipRangeStart_lblInfo.Text = "";
                        this.settings.IpRangeStart = ipAddress.ToString();
                        calculateSubnetId();
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }

        private void settings_validateIpRangeEndInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void settings_validateSubnetInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void calculateSubnetId()
        {
            // automatically calculate and set subnet id
            if (this.settings.IpRangeStartIsSet && this.settings.SubnetMaskIsSet)
            {
                try
                {
                    this.settings.DHCPNetCalcTool.calculate(this.settings.IpRangeStart, this.settings.SubnetMask);
                    this.settings.Subnet = this.settings.DHCPNetCalcTool.NetworkId;
                    this.subnet_input.Text = this.settings.Subnet;
                    this.settings_validateSubnetInput(this.subnet_input, new EventArgs());
                }
                catch
                {
                    IOController.Log(this,"subnet calculation failed",IOController.Flag.error);
                }
            }
        }
        private void settings_validateSubnetMaskInput(object sender, EventArgs e)
        {
            try
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
                    calculateSubnetId();
                }
                else
                {
                    validationStatus_ok.SetError((IPAddressControlLib.IPAddressControl)sender, "");
                    validationStatus_error.SetError((IPAddressControlLib.IPAddressControl)sender, "please enter valid IP address");
                    this.subnetMask_lblInfo.Text = "address is not a valid ip address";
                }
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void settings_validateGatewayInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void settings_validatePrimaryDNSInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }

        private void settings_validateSecondaryDNSInput(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
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
            try
            {
                this.ipRangeStart_input.Text = this.settings.IpRangeStart;
                this.ipRangeStart_input.Refresh();
                this.ipRangeEnd_input.Text = this.settings.IpRangeEnd;
                this.ipRangeEnd_input.Refresh();
                this.subnetMask_input.Text = this.settings.SubnetMask;
                this.subnetMask_input.Refresh();
                this.gateway_input.Text = this.settings.Gateway;
                this.gateway_input.Refresh();
                this.primaryDNS_input.Text = this.settings.PrimaryDNS;
                this.primaryDNS_input.Refresh();
                this.secondaryDNS_input.Text = this.settings.SecondaryDNS;
                this.secondaryDNS_input.Refresh();
                this.subnet_input.Text = this.settings.Subnet;
                this.subnet_input.Refresh();
                settingsValidateAllInputs();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void settingsValidateAllInputs()
        {
            // Control.Validate() is not implemented yet in Mono
            this.ipRangeStart_input.Validate();
            this.ipRangeEnd_input.Validate();
            this.subnetMask_input.Validate();
            this.gateway_input.Validate();
            this.primaryDNS_input.Validate();
            this.secondaryDNS_input.Validate();
            this.subnet_input.Validate();
            this.ipRangeStart_input.Validate();
            // workaround by setting focus
            this.ipRangeStart_input.Focus();
            this.ipRangeEnd_input.Focus();
            this.subnetMask_input.Focus();
            this.gateway_input.Focus();
            this.primaryDNS_input.Focus();
            this.secondaryDNS_input.Focus();
            this.subnet_input.Focus();
            this.ipRangeStart_input.Focus();
        }
        #endregion SettingsPanel

        #region MenuBottomPanel
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while saving file. See log for details.");
            }
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                ioController.SaveSettingsFile(((SaveFileDialog)sender).FileName);
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while saving file. See log for details.");
            }
        }
        private void menuBottom_btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while loading file. See log for details.");
            }
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                ioController.LoadSettingsFile(((OpenFileDialog)sender).FileName);
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Error while opening file. See log for details.");
            }
        }

        private void menuBottom_btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                ioController.ApplySettingsToDHCPServer();
            }
            catch (System.Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("Exception while applying settings. See log for details.");
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
                IOController.Log(this, ex.Message, IOController.Flag.error);
                MessageBox.Show("The file /etc/dhcp/dhcpd.conf could not be loaded. See log for details.");
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

        #region StaticLeases
        public void StaticLeases_ListView_update(object sender, PropertyChangedEventArgs e)
        {
            if (this.staticLeases_listview.InvokeRequired)
            {
                updateStaticLeasesListViewCallback uc = new updateStaticLeasesListViewCallback(updateStaticLeasesListView);
                this.Invoke(uc);
            }
            else
            {
                updateStaticLeasesListView();
            }
        }
        private delegate void updateStaticLeasesListViewCallback();
        private void updateStaticLeasesListView()
        {
            try
            {
                IOController.Log(this, "updateStaticLeasesListView", IOController.Flag.debug);
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
            catch (Exception ex)
            {
                IOController.Log(this, "updateStaticLeasesListView FAILED: " + ex.Message, IOController.Flag.error);
            }
        }
        private void staticLeases_input_btn_add_Click(object sender, EventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewAddCallback cb = new staticLeasesListViewAddCallback(staticLeasesListViewAdd);
                this.Invoke(cb);
            }
            else
            {
                staticLeasesListViewAdd();
            }
        }
        private delegate void staticLeasesListViewAddCallback();
        private void staticLeasesListViewAdd()
        {
            try
            {
                IOController.Log(this, "called", IOController.Flag.debug);
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private string listviewitemid;
        private int listviewindex;
        private bool staticLeaseEditing = false;
        private void ListViewEditClick(object sender, ListViewColumnMouseEventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewEditCallback cb = new staticLeasesListViewEditCallback(staticLeasesListViewEdit);
                this.Invoke(cb, e);
            }
            else
            {
                staticLeasesListViewEdit(e);
            }
            
        }
        private delegate void staticLeasesListViewEditCallback(ListViewColumnMouseEventArgs e);
        private void staticLeasesListViewEdit(ListViewColumnMouseEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void staticLeases_input_btn_saveEdit_Click(object sender, EventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewSaveEditCallback cb = new staticLeasesListViewSaveEditCallback(staticLeasesListViewSaveEdit);
                this.Invoke(cb);
            }
            else
            {
                staticLeasesListViewSaveEdit();
            }
        }
        private delegate void staticLeasesListViewSaveEditCallback();
        private void staticLeasesListViewSaveEdit()
        {
            try
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        private void ListViewDeleteClick(object sender, ListViewColumnMouseEventArgs e)
        {
            if (this.staticLeases_panelMain.InvokeRequired)
            {
                staticLeasesListViewDeleteCallback cb = new staticLeasesListViewDeleteCallback(staticLeasesListViewDelete);
                this.Invoke(cb, e);
            }
            else
            {
                staticLeasesListViewDelete(e);
            }
        }
        private delegate void staticLeasesListViewDeleteCallback(ListViewColumnMouseEventArgs e);
        private void staticLeasesListViewDelete(ListViewColumnMouseEventArgs e)
        {
            try
            {
                IOController.Log(this, "ListViewDeleteClick Item.Index: " + e.Item.Index, IOController.Flag.debug);
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }

        #endregion StaticLeases

        #region DhcpdLeases
        public void OnSettingsDhcpdLeasesChange(object sender, PropertyChangedEventArgs e)
        {
            if (this.clients_dhcpdLeases_listView.InvokeRequired)
            {
                updateDhcpdLeasesListViewCallback uc = new updateDhcpdLeasesListViewCallback(updateDhcpdLeasesListView);
                this.Invoke(uc);
            }
            else
            {
                updateDhcpdLeasesListView();
            }
        }
        private delegate void updateDhcpdLeasesListViewCallback();
        private void updateDhcpdLeasesListView()
        {
            IOController.Log(this, "called", IOController.Flag.debug);
            try
            {
                clients_dhcpdLeases_listView.Items.Clear();
                foreach (KeyValuePair<string, DhcpdLease> entry in this.settings.DhcpdLeases)
                {
                    DhcpdLease dhcpdLease = entry.Value;
                    if (dhcpdLease.LeaseState == "active")
                    {
                        ListViewItem item = new ListViewItem(dhcpdLease.MACAddress);
                        item.SubItems.Add(dhcpdLease.DeviceName);
                        item.SubItems.Add(dhcpdLease.IPAddress);
                        item.SubItems.Add(dhcpdLease.LeaseStart);
                        item.SubItems.Add(dhcpdLease.LeaseEnd);
                        item.SubItems.Add("add static lease");
                        clients_dhcpdLeases_listView.Items.Add(item);
                    }
                }
                clients_dhcpdLeases_listView.Refresh();
            }
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
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
            catch (Exception ex)
            {
                IOController.Log(this, ex.Message, IOController.Flag.error);
            }
        }
        #endregion DhcpdLeases

    }
}
