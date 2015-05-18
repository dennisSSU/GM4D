using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* 
 * Filename: LoadingWindow.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: loading window, show process bar of the background worker loading all settings
 */
namespace GM4D
{
    /// <summary>
    /// loading window, show process bar of the background worker loading all settings
    /// </summary>
    public partial class LoadingWindow : Form
    {
        /// <summary>
        /// loading window, show process bar of the background worker loading all settings
        /// </summary>
        public LoadingWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// changes the progress bar progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">ProgressChangedEventArgs</param>
        internal void OnProgressChange(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }
    }
}
