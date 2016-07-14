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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// The Create Virtual Machine operation response.
    /// </summary>
    public partial class VirtualMachineCreateOrUpdateResponse : ComputeOperationResponse
    {
        private VirtualMachine _virtualMachine;
        
        /// <summary>
        /// Optional. Gets or sets details of the Virtual Machine.
        /// </summary>
        public VirtualMachine VirtualMachine
        {
            get { return this._virtualMachine; }
            set { this._virtualMachine = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineCreateOrUpdateResponse class.
        /// </summary>
        public VirtualMachineCreateOrUpdateResponse()
        {
        }
    }
}
