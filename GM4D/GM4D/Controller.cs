using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace GM4D
{
    class Controller
    {
        private MainWindow mainWindow;
        private Settings settings;
        private IOController ioController;
        public Controller()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            this.settings = new Settings();
            this.ioController = new IOController(this.settings);
            this.mainWindow = new MainWindow(this.settings, this.ioController);
        }

        public void Run()
        {
            mainWindow.Shown += mainWindow_Shown;
            System.Windows.Forms.Application.Run(mainWindow);
        }

        private void mainWindow_Shown(object sender, EventArgs e)
        {
            this.ioController.GetHostInfo();
            settings.selectInterface(0);
            try
            {
                this.ioController.GetDHCPServerInstallStatus();
                this.ioController.GetDHCPServerStatus();
            }
            catch (Exception exc)
            {
                mainWindow.ShowMessageBox(exc.Message,"Failed to get DHCP server status");
            }
        }


    }
}
