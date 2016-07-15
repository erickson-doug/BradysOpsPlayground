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
    /// Http listener of application gateway
    /// </summary>
    public partial class ApplicationGatewayHttpListener : ChildResource
    {
        private ResourceId _frontendIPConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets frontend IP configuration resource of
        /// application gateway
        /// </summary>
        public ResourceId FrontendIPConfiguration
        {
            get { return this._frontendIPConfiguration; }
            set { this._frontendIPConfiguration = value; }
        }
        
        private ResourceId _frontendPort;
        
        /// <summary>
        /// Optional. Gets or sets frontend port resource of application
        /// gateway
        /// </summary>
        public ResourceId FrontendPort
        {
            get { return this._frontendPort; }
            set { this._frontendPort = value; }
        }
        
        private string _protocol;
        
        /// <summary>
        /// Optional. Gets or sets the protocol
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the http listener
        /// resource Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private ResourceId _sslCertificate;
        
        /// <summary>
        /// Optional. Gets or sets ssl certificate resource of application
        /// gateway
        /// </summary>
        public ResourceId SslCertificate
        {
            get { return this._sslCertificate; }
            set { this._sslCertificate = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        public ApplicationGatewayHttpListener()
        {
        }
    }
}
