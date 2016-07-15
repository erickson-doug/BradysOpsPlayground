// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// The different connection types that a virtual network gateway can have.
    /// </summary>
    public static partial class VirtualNetworkGatewayConnectionType
    {
        /// <summary>
        /// Virtual network gateway connection type:IPsec
        /// </summary>
        public const string IPsec = "IPsec";
        
        /// <summary>
        /// Virtual network gateway connection type:Vnet2Vnet
        /// </summary>
        public const string Vnet2Vnet = "Vnet2Vnet";
        
        /// <summary>
        /// Virtual network gateway dedicated connection type:ExpressRoute
        /// </summary>
        public const string ExpressRoute = "ExpressRoute";
        
        /// <summary>
        /// Virtual network gateway connection type:VPNClient
        /// </summary>
        public const string VPNClient = "VPNClient";
    }
}
