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
using Microsoft.Azure.Management.Batch.Models;

namespace Microsoft.Azure.Management.Batch.Models
{
    /// <summary>
    /// Parameters supplied to the Update operation.
    /// </summary>
    public partial class BatchAccountUpdateParameters
    {
        private AccountBaseProperties _properties;
        
        /// <summary>
        /// Optional. The properties of the account.
        /// </summary>
        public AccountBaseProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. The user specified tags associated with the account.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BatchAccountUpdateParameters
        /// class.
        /// </summary>
        public BatchAccountUpdateParameters()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
    }
}
