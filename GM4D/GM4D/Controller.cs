using System;
using System.Collections.Generic;
using System.Text;

namespace GM4D
{
    class Controller
    {
        private MainWindow mainWindow;
        private Settings settings;
        public Controller()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            this.settings = new Settings();
            this.mainWindow = new MainWindow(this.settings);
        }

        public void Run()
        {
            System.Windows.Forms.Application.Run(mainWindow);
        }
    }
}
