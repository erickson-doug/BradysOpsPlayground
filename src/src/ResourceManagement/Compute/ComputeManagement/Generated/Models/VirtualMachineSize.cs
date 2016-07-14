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

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes the properties of a VM size.
    /// </summary>
    public partial class VirtualMachineSize
    {
        private int? _maxDataDiskCount;
        
        /// <summary>
        /// Optional. Gets or sets the Maximum number of data disks allowed by
        /// a VM size.
        /// </summary>
        public int? MaxDataDiskCount
        {
            get { return this._maxDataDiskCount; }
            set { this._maxDataDiskCount = value; }
        }
        
        private int _memoryInMB;
        
        /// <summary>
        /// Optional. Gets or sets the Memory size supported by a VM size.
        /// </summary>
        public int MemoryInMB
        {
            get { return this._memoryInMB; }
            set { this._memoryInMB = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the VM size name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int _numberOfCores;
        
        /// <summary>
        /// Optional. Gets or sets the Number of cores supported by a VM size.
        /// </summary>
        public int NumberOfCores
        {
            get { return this._numberOfCores; }
            set { this._numberOfCores = value; }
        }
        
        private int _oSDiskSizeInMB;
        
        /// <summary>
        /// Optional. Gets or sets the OS disk size allowed by a VM size.
        /// </summary>
        public int OSDiskSizeInMB
        {
            get { return this._oSDiskSizeInMB; }
            set { this._oSDiskSizeInMB = value; }
        }
        
        private int _resourceDiskSizeInMB;
        
        /// <summary>
        /// Optional. Gets or sets the Resource disk size allowed by a VM size.
        /// </summary>
        public int ResourceDiskSizeInMB
        {
            get { return this._resourceDiskSizeInMB; }
            set { this._resourceDiskSizeInMB = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        public VirtualMachineSize()
        {
        }
    }
}
