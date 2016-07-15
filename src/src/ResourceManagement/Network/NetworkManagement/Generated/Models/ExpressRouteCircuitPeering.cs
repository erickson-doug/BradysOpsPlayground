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
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Peering in a ExpressRouteCircuit resource
    /// </summary>
    public partial class ExpressRouteCircuitPeering : ChildResource
    {
        private int _azureASN;
        
        /// <summary>
        /// Optional. Gets or sets the azure ASN
        /// </summary>
        public int AzureASN
        {
            get { return this._azureASN; }
            set { this._azureASN = value; }
        }
        
        private ExpressRouteCircuitPeeringConfig _microsoftPeeringConfig;
        
        /// <summary>
        /// Optional. Gets or sets the mircosoft peering config
        /// </summary>
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig
        {
            get { return this._microsoftPeeringConfig; }
            set { this._microsoftPeeringConfig = value; }
        }
        
        private int _peerASN;
        
        /// <summary>
        /// Optional. Gets or sets the peer ASN
        /// </summary>
        public int PeerASN
        {
            get { return this._peerASN; }
            set { this._peerASN = value; }
        }
        
        private string _peeringType;
        
        /// <summary>
        /// Optional. Gets or sets PeeringType
        /// </summary>
        public string PeeringType
        {
            get { return this._peeringType; }
            set { this._peeringType = value; }
        }
        
        private string _primaryAzurePort;
        
        /// <summary>
        /// Optional. Gets or sets the primary port
        /// </summary>
        public string PrimaryAzurePort
        {
            get { return this._primaryAzurePort; }
            set { this._primaryAzurePort = value; }
        }
        
        private string _primaryPeerAddressPrefix;
        
        /// <summary>
        /// Optional. Gets or sets the primary address prefix
        /// </summary>
        public string PrimaryPeerAddressPrefix
        {
            get { return this._primaryPeerAddressPrefix; }
            set { this._primaryPeerAddressPrefix = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _secondaryAzurePort;
        
        /// <summary>
        /// Optional. Gets or sets the secondary port
        /// </summary>
        public string SecondaryAzurePort
        {
            get { return this._secondaryAzurePort; }
            set { this._secondaryAzurePort = value; }
        }
        
        private string _secondaryPeerAddressPrefix;
        
        /// <summary>
        /// Optional. Gets or sets the secondary address prefix
        /// </summary>
        public string SecondaryPeerAddressPrefix
        {
            get { return this._secondaryPeerAddressPrefix; }
            set { this._secondaryPeerAddressPrefix = value; }
        }
        
        private string _sharedKey;
        
        /// <summary>
        /// Optional. Gets or sets the shared key
        /// </summary>
        public string SharedKey
        {
            get { return this._sharedKey; }
            set { this._sharedKey = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Gets or sets state of Peering
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private ExpressRouteCircuitStats _stats;
        
        /// <summary>
        /// Optional. Gets or peering stats
        /// </summary>
        public ExpressRouteCircuitStats Stats
        {
            get { return this._stats; }
            set { this._stats = value; }
        }
        
        private int _vlanId;
        
        /// <summary>
        /// Optional. Gets or sets the vlan id
        /// </summary>
        public int VlanId
        {
            get { return this._vlanId; }
            set { this._vlanId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeering class.
        /// </summary>
        public ExpressRouteCircuitPeering()
        {
        }
    }
}
