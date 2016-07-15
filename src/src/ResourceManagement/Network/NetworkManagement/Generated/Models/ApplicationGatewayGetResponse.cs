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
using Microsoft.Azure;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Response of a GET ApplicationGateway operation
    /// </summary>
    public partial class ApplicationGatewayGetResponse : AzureOperationResponse
    {
        private ApplicationGateway _applicationGateway;
        
        /// <summary>
        /// Optional. Gets a ApplicationGateway in a resource group
        /// </summary>
        public ApplicationGateway ApplicationGateway
        {
            get { return this._applicationGateway; }
            set { this._applicationGateway = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayGetResponse
        /// class.
        /// </summary>
        public ApplicationGatewayGetResponse()
        {
        }
    }
}
