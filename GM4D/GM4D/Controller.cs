using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                this.ioController.InitShell();
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("Controller ioController.InitShell " + exc.Message);
            }
            try
            {
                this.ioController.GetHostInfo();
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("Controller ioController.GetHostInfo " + exc.Message);
            }
            if (settings.Interfaces.Count > 0) settings.selectInterface(0);
            try
            {
                this.ioController.GetDHCPServerInstallStatus();
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("Controller GetDHCPServerInstallStatus " + exc.Message);
            }
            try
            {
                this.ioController.GetDHCPServerStatus();
            }    
            catch (Exception exc)
            {
                System.Console.WriteLine("Controller GetDHCPServerStatus " + exc.Message);
            } 
            try
            {
                this.ioController.InitiateDhcpdLeasesFileWatcher();
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("Controller InitiateDhcpdLeasesFileWatcher " + exc.Message);
            }

        }
    }
}
