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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Response for ListVirtualNetworkGateways Api service call
    /// </summary>
    public partial class VirtualNetworkGatewayListResponse : AzureOperationResponse
    {
        private string _nextLink;
        
        /// <summary>
        /// Optional. Gets the URL to get the next set of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<VirtualNetworkGateway> _virtualNetworkGateways;
        
        /// <summary>
        /// Optional. Gets List of VirtualNetworkGateways that exists in a
        /// resource group
        /// </summary>
        public IList<VirtualNetworkGateway> VirtualNetworkGateways
        {
            get { return this._virtualNetworkGateways; }
            set { this._virtualNetworkGateways = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayListResponse
        /// class.
        /// </summary>
        public VirtualNetworkGatewayListResponse()
        {
            this.VirtualNetworkGateways = new LazyList<VirtualNetworkGateway>();
        }
    }
}
