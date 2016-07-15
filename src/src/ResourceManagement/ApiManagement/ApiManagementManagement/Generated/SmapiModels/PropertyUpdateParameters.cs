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

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Parameters supplied to the Update Property operation.
    /// </summary>
    public partial class PropertyUpdateParameters
    {
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets Unique name of Property. Must be between 1
        /// to 256 characters long.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private bool? _secret;
        
        /// <summary>
        /// Optional. Gets or sets the value which determines the value should
        /// be encrypted or not. Default value is false.
        /// </summary>
        public bool? Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }
        
        private IList<string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets Collection of tags associated with a
        /// property.
        /// </summary>
        public IList<string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Gets or sets the Value of the Property. Must be between 1
        /// to 4096 characters long.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PropertyUpdateParameters class.
        /// </summary>
        public PropertyUpdateParameters()
        {
            this.Tags = new LazyList<string>();
        }
    }
}
