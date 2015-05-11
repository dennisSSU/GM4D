using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
/* File: NetCalcTool.cs
 * Author: Dennis Stodko
 * Year: 2015
 * Description: This class is a collection of functions to calculate IP addresses
 */
namespace GM4D
{
    public class NetCalcTool
    {
        public string Ip { get; private set; }
        public string FirstIp { get; private set; }
        public string LastIp { get; private set; }
        public string Broadcast { get; private set; }
        public string NetworkId { get; private set; }
        public int SubnetBits { get; private set; }
        public string SubnetMask { get; private set; }
        private IPAddress ipAddressIP;
        private IPAddress subnetMaskIP;
        private IPAddress networkAddressIP;
        public NetCalcTool() { }
        public void calculate(string ipAddress, string subnetMask)
        {
            if (IPAddress.TryParse(ipAddress, out ipAddressIP) && IPAddress.TryParse(subnetMask, out subnetMaskIP))
            {
                this.Ip = ipAddress;
                this.SubnetBits = stringMaskToBits(subnetMask);
                this.SubnetMask = subnetMask;
                calcBroadcastAndLastIp();
                calcNetworkAndFirstIp();
            }
            else
            {
                throw new ArgumentException("arguments not valid ip addresses");
            }
        }
        /// <summary>
        /// calculates the broadcast address and last usable IP address of a subnet
        /// </summary>
        private void calcBroadcastAndLastIp()
        {
            byte[] byteAddress;
            byte[] ipAdressBytes = ipAddressIP.GetAddressBytes();
            byte[] subnetMaskBytes = subnetMaskIP.GetAddressBytes();
            byteAddress = new byte[ipAdressBytes.Length];
            for (int i = 0; i < byteAddress.Length; i++)
            {
                byteAddress[i] = (byte)(ipAdressBytes[i] | (subnetMaskBytes[i] ^ 255));
            }
            IPAddress broadAddress = new IPAddress(byteAddress);
            this.Broadcast = broadAddress.ToString(); ;
            byteAddress[3]--;
            IPAddress LastIpAddress = new IPAddress(byteAddress);
            this.LastIp = LastIpAddress.ToString();
        }
        /// <summary>
        /// calculates the network address and first usable IP address of a subnet
        /// </summary>
        private void calcNetworkAndFirstIp()
        {
            byte[] byteAddress;
            byte[] ipAdressBytes = ipAddressIP.GetAddressBytes();
            byte[] subnetMaskBytes = subnetMaskIP.GetAddressBytes();
            byteAddress = new byte[ipAdressBytes.Length];
            for (int i = 0; i < byteAddress.Length; i++)
            {
                byteAddress[i] = (byte)(ipAdressBytes[i] & (subnetMaskBytes[i]));
            }
            networkAddressIP = new IPAddress(byteAddress);
            this.NetworkId = networkAddressIP.ToString();
            byteAddress[3]++;
            IPAddress firstIpAddress = new IPAddress(byteAddress);
            this.FirstIp = firstIpAddress.ToString();
        }
        /// <summary>
        /// returns the networks address of a given IPv4 address and subnet mask
        /// </summary>
        /// <param name="ipAddress">IPv4 address</param>
        /// <param name="subnetMask">Subnet Mask</param>
        /// <returns></returns>
        private IPAddress getNetworkAddress(IPAddress ipAddress, IPAddress subnetMask)
        {
            byte[] byteAddress;
            byte[] ipAdressBytes = ipAddress.GetAddressBytes();
            byte[] subnetMaskBytes = subnetMask.GetAddressBytes();
            if (ipAdressBytes.Length != subnetMaskBytes.Length)
            {
                throw new ArgumentException("ip address and subnet mask do not match");
            }
            byteAddress = new byte[ipAdressBytes.Length];
            for (int i = 0; i < byteAddress.Length; i++)
            {
                byteAddress[i] = (byte)(ipAdressBytes[i] & (subnetMaskBytes[i]));
            }
            networkAddressIP = new IPAddress(byteAddress);
            return networkAddressIP;
        }
        /// <summary>
        /// checks if two IP addresses are in the same subnet, return true/false
        /// </summary>
        /// <param name="ipAddress1">first IPv4 address</param>
        /// <param name="ipAddress2">second IPv4 address</param>
        /// <param name="subnetMask">subnet mask</param>
        /// <returns></returns>
        public bool CheckSameSubnet(string ipAddress1, string ipAddress2, string subnetMask)
        {
            IPAddress ipAddr1;
            IPAddress ipAddr2;
            IPAddress snetMask;
            if (IPAddress.TryParse(ipAddress1, out ipAddr1) && IPAddress.TryParse(ipAddress2, out ipAddr2) && IPAddress.TryParse(subnetMask, out snetMask))
            {
                try
                {
                    IPAddress network1 = getNetworkAddress(ipAddr1, snetMask);
                    IPAddress network2 = getNetworkAddress(ipAddr2, snetMask);
                    return network1.Equals(network2);
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentException("arguments not valid ip addresses");
            }
        }
        private int stringMaskToBits(String mask)
        {
            int totalBits = 0;
            foreach (string octet in mask.Split('.'))
            {
                byte octetByte = byte.Parse(octet);
                while (octetByte != 0)
                {
                    totalBits += octetByte & 1;
                    octetByte >>= 1;
                }
            }
            return totalBits;
        }
    }
}
