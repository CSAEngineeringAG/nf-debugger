﻿//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//


namespace nanoFramework.Tools.Debugger
{
    public class NetworkConfigurationBase
    {
        /// <summary>
        /// This is the marker placeholder for this configuration block
        /// 4 bytes length.
        /// </summary>
        public byte[] Marker;

        /// <summary>
        /// MAC address for the network interface
        /// </summary>
        public byte[] MacAddress;

        /// <summary>
        /// Network IPv4 address as 32-bit unsigned integer
        /// </summary>
        public uint IPv4Address;

        /// <summary>
        /// Network IPv4 subnet mask as 32-bit unsigned integer 
        /// </summary>
        public uint IPv4NetMask;

        /// <summary>
        /// Network gateway IPv4 address as 32-bit unsigned integer 
        /// </summary>
        public uint IPv4GatewayAddress;

        /// <summary>
        /// DNS server 1 IPv4 address as 32-bit unsigned integer 
        /// </summary>
        public uint IPv4DNS1Address;

        /// <summary>
        /// DNS server 2 IPv4 address as 32-bit unsigned integer 
        /// </summary>
        public uint IPv4DNS2Address;

        /// <summary>
        /// Network IPv6 address as an array of 4 32-bit unsigned integers 
        /// </summary>
        public uint[] IPv6Address;

        /// <summary>
        // Network IPv6 subnet mask as an array of 4 32-bit unsigned integers
        /// </summary>
        public uint[] IPv6NetMask;

        /// <summary>
        /// Network gateway IPv6 address as an array of 4 32-bit unsigned integers
        /// </summary>
        public uint[] IPv6GatewayAddress;

        /// <summary>
        /// DNS server 1 IPv6 address as an array of 4 32-bit unsigned integers 
        /// </summary>
        public uint[] IPv6DNS1Address;

        /// <summary>
        /// DNS server 2 IPv6 address as an array of 4 32-bit unsigned integers
        /// </summary>
        public uint[] IPv6DNS2Address;

        /// <summary>
        /// Address mode (static, DHCP or auto IP)
        /// </summary>
        public byte StartupAddressMode;
    }
}