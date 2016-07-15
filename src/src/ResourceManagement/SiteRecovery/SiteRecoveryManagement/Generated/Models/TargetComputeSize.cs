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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a target Compute Size object.
    /// </summary>
    public partial class TargetComputeSize
    {
        private int _cpuCoresCount;
        
        /// <summary>
        /// Optional. The value for the CPU cores count.
        /// </summary>
        public int CpuCoresCount
        {
            get { return this._cpuCoresCount; }
            set { this._cpuCoresCount = value; }
        }
        
        private IList<ComputeSizeErrorDetails> _error;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<ComputeSizeErrorDetails> Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. The value for the target Compute Size friendly name
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _highIopsSupported;
        
        /// <summary>
        /// Optional. Indicates whether the role size supports high Iops.
        /// </summary>
        public string HighIopsSupported
        {
            get { return this._highIopsSupported; }
            set { this._highIopsSupported = value; }
        }
        
        private int _maxDataDiskCount;
        
        /// <summary>
        /// Optional. The value for the max data disk count.
        /// </summary>
        public int MaxDataDiskCount
        {
            get { return this._maxDataDiskCount; }
            set { this._maxDataDiskCount = value; }
        }
        
        private int _maxNicsCount;
        
        /// <summary>
        /// Optional. The value for the max Nics count.
        /// </summary>
        public int MaxNicsCount
        {
            get { return this._maxNicsCount; }
            set { this._maxNicsCount = value; }
        }
        
        private double _memoryInGB;
        
        /// <summary>
        /// Optional. The value for the memory in GB.
        /// </summary>
        public double MemoryInGB
        {
            get { return this._memoryInGB; }
            set { this._memoryInGB = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The value for the target Compute Size name
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TargetComputeSize class.
        /// </summary>
        public TargetComputeSize()
        {
            this.Error = new LazyList<ComputeSizeErrorDetails>();
        }
    }
}
