using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    public partial class LoadingWindow : Form
    {
        public LoadingWindow()
        {
            InitializeComponent();
        }

        internal void OnProgressChange(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }
    }
}
