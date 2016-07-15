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

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Parameters supplied to the Update OpenID Connect Provider operation.
    /// </summary>
    public partial class OpenidConnectProviderUpdateContract
    {
        private string _clientId;
        
        /// <summary>
        /// Optional. Gets or sets Client ID of developer console which is the
        /// client application.
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }
        
        private string _clientSecret;
        
        /// <summary>
        /// Optional. Gets or sets Client Secret of developer console which is
        /// the client application.
        /// </summary>
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets User-friendly description of OpenID Connect
        /// Provider.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _metadataEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets Metadata endpoint URI.
        /// </summary>
        public string MetadataEndpoint
        {
            get { return this._metadataEndpoint; }
            set { this._metadataEndpoint = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets User-friendly OpenID Connect Provider name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// OpenidConnectProviderUpdateContract class.
        /// </summary>
        public OpenidConnectProviderUpdateContract()
        {
        }
    }
}
