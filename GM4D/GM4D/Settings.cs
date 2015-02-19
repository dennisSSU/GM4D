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

        public Settings()
        {
            this.HostIP = "192.168.1.2";
        }
    }
}
