using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM4D
{
    static class InputValidation
    {
        public static bool validateIpAddress(String ip)
        {
            System.Net.IPAddress ipAddress;
            return System.Net.IPAddress.TryParse(ip, out ipAddress);
        }
        public static bool validatingIpAddress(object sender, System.Windows.Forms.ErrorProvider statusError, System.Windows.Forms.ErrorProvider statusOK)
        {
            IPAddressControlLib.IPAddressControl input = (IPAddressControlLib.IPAddressControl)sender;
            System.Net.IPAddress ip;
            if (!System.Net.IPAddress.TryParse(input.Text, out ip))
            {
                statusOK.Clear();
                statusError.SetError(input, "please enter a valid IP address");
                return false;
            }
            return true;
        }

        public static void validatedIpAddress(object sender, System.Windows.Forms.ErrorProvider statusError, System.Windows.Forms.ErrorProvider statusOK)
        {
            IPAddressControlLib.IPAddressControl input = (IPAddressControlLib.IPAddressControl)sender;
            statusError.Clear();
            statusOK.SetError(input, "valid IP address");
        }
    }
}
