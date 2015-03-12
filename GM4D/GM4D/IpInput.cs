using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    public partial class IpInput : UserControl
    {
        public IpInput()
        {
            InitializeComponent();
            this.Required = false;
        }
        public bool Required { get; set; }
        public Image ImgRequired { get; set; }
        public Image ImgError { get; set; }
        public Image ImgOk { get; set; }

        private void validateIpAddress(object sender, CancelEventArgs e)
        {
            if (this.block1.Text == "" && this.block2.Text == "" && this.block3.Text == "" && this.block4.Text == "")
            {
                if (this.Required) 
                {
                    this.status.Image = ImgRequired;
                    this.hint.SetHelpString(this.status, "this field is required");
                    this.hint.SetShowHelp(this.status, true);
                }
                else
                {
                    this.status.Image.Dispose();
                    this.hint.Dispose();
                }

            }

        }
    }
}
