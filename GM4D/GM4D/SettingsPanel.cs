using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    class SettingsPanel : FlowLayoutPanel
    {
        private System.Windows.Forms.TableLayoutPanel settings_panelInput;
        private System.Windows.Forms.Label ipRangeStart_lblInfo;
        private System.Windows.Forms.Label ipRangeEnd_lbl;
        private System.Windows.Forms.Label ipRangeEnd_lblInfo;
        private System.Windows.Forms.Label ipRangeStart_lbl;
        private System.Windows.Forms.Label subnetMask_lbl;
        private System.Windows.Forms.Label gateway_lbl;
        private System.Windows.Forms.Label subnetMask_Info;
        private System.Windows.Forms.Label gateway_lblInfo;
        private System.Windows.Forms.TableLayoutPanel settings_panelInfo;
        private System.Windows.Forms.Label hostIP_lbl;
        private System.Windows.Forms.Label hostSubnetMask_lbl;
        private System.Windows.Forms.TextBox hostSubnetMask_tb;
        private System.Windows.Forms.Label hostIP_lblInfo;
        private System.Windows.Forms.Label hostSubnetMask_lblInfo;
        private System.Windows.Forms.TextBox hostIP_tb;
        private IPAddressControlLib.IPAddressControl ipRangeEnd_input;
        private IPAddressControlLib.IPAddressControl ipRangeStart_input;
        private IPAddressControlLib.IPAddressControl subnetMask_input;
        private IPAddressControlLib.IPAddressControl gateway_input;
        private System.Windows.Forms.ErrorProvider ipRange_validationStatus_error;
        private System.Windows.Forms.ErrorProvider ipRange_validationStatus_ok;
        public SettingsPanel()
        {

        }
    }
}
