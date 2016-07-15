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
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Management.Storage.Models
{
    /// <summary>
    /// The parameters to provide for the account.
    /// </summary>
    public partial class StorageAccountCreateParameters
    {
        private Microsoft.Azure.Management.Storage.Models.AccountType? _accountType;
        
        /// <summary>
        /// Required. Gets or sets the account type.
        /// </summary>
        public Microsoft.Azure.Management.Storage.Models.AccountType? AccountType
        {
            get { return this._accountType; }
            set { this._accountType = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Required. Gets or sets the location of the resource. This will be
        /// one of the supported and registered Azure Geo Regions (e.g. West
        /// US, East US, Southeast Asia, etc.). The geo region of a resource
        /// cannot be changed once it is created.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets a list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource (across resource groups). A maximum of 15 tags can be
        /// provided for a resource. Each tag must have a key no greater than
        /// 128 characters and value no greater than 256 characters.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        public StorageAccountCreateParameters()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class with required arguments.
        /// </summary>
        public StorageAccountCreateParameters(AccountType? accountType, string location)
            : this()
        {
            if (accountType == null)
            {
                throw new ArgumentNullException("accountType");
            }
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.AccountType = accountType;
            this.Location = location;
        }
    }
}
