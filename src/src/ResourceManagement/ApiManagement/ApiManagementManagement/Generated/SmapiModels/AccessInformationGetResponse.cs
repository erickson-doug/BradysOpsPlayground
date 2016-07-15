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
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Get Tenant Access Information operation response details.
    /// </summary>
    public partial class AccessInformationGetResponse : AzureOperationResponse
    {
        private string _eTag;
        
        /// <summary>
        /// Optional. Gets or sets ETag value.
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }
        
        private AccessInformationContract _value;
        
        /// <summary>
        /// Optional. Gets or sets result of the Get Tenant Access Information
        /// operation.
        /// </summary>
        public AccessInformationContract Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AccessInformationGetResponse
        /// class.
        /// </summary>
        public AccessInformationGetResponse()
        {
        }
    }
}
