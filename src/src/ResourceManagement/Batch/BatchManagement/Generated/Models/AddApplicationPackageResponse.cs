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
using Microsoft.Azure.Management.Batch.Models;

namespace Microsoft.Azure.Management.Batch.Models
{
    /// <summary>
    /// Response to an ApplicationOperations.AddApplicationPackage request.
    /// </summary>
    public partial class AddApplicationPackageResponse : AzureOperationResponse
    {
        private string _format;
        
        /// <summary>
        /// Optional. Gets or sets the format of the application package, if
        /// known.
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Required. Gets or sets the id of the application.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private System.DateTime? _lastActivationTime;
        
        /// <summary>
        /// Optional. Gets or sets the time at which the package was last
        /// activated, if the package is active.
        /// </summary>
        public System.DateTime? LastActivationTime
        {
            get { return this._lastActivationTime; }
            set { this._lastActivationTime = value; }
        }
        
        private PackageState _state;
        
        /// <summary>
        /// Required. Gets or sets the current state of the application package.
        /// </summary>
        public PackageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _storageUrl;
        
        /// <summary>
        /// Required. Gets or sets the URL to which the application package
        /// binary file should be uploaded.
        /// </summary>
        public string StorageUrl
        {
            get { return this._storageUrl; }
            set { this._storageUrl = value; }
        }
        
        private DateTime _storageUrlExpiry;
        
        /// <summary>
        /// Required. Gets or sets the UTC time at which the storage URL will
        /// expire.
        /// </summary>
        public DateTime StorageUrlExpiry
        {
            get { return this._storageUrlExpiry; }
            set { this._storageUrlExpiry = value; }
        }
        
        private string _version;
        
        /// <summary>
        /// Required. Gets or sets the version of the application.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AddApplicationPackageResponse
        /// class.
        /// </summary>
        public AddApplicationPackageResponse()
        {
        }
    }
}
