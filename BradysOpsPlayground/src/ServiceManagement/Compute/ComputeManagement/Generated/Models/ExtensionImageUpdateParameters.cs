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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Update Extension Image operation.
    /// </summary>
    public partial class ExtensionImageUpdateParameters : ExtensionImageRegisterParameters
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionImageUpdateParameters
        /// class.
        /// </summary>
        public ExtensionImageUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ExtensionImageUpdateParameters
        /// class with required arguments.
        /// </summary>
        public ExtensionImageUpdateParameters(string providerNameSpace, string type, string version)
            : this()
        {
            if (providerNameSpace == null)
            {
                throw new ArgumentNullException("providerNameSpace");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (version == null)
            {
                throw new ArgumentNullException("version");
            }
            this.ProviderNameSpace = providerNameSpace;
            this.Type = type;
            this.Version = version;
        }
    }
}
