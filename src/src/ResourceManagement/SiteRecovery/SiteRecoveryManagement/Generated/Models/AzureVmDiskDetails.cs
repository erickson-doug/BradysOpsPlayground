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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Virtual Machine disk details.
    /// </summary>
    public partial class AzureVmDiskDetails
    {
        private string _lunId;
        
        /// <summary>
        /// Optional. Gets or sets LunId of the disk for the Azure VM.
        /// </summary>
        public string LunId
        {
            get { return this._lunId; }
            set { this._lunId = value; }
        }
        
        private string _maxSizeMB;
        
        /// <summary>
        /// Optional. Gets or sets max side in MB.
        /// </summary>
        public string MaxSizeMB
        {
            get { return this._maxSizeMB; }
            set { this._maxSizeMB = value; }
        }
        
        private string _targetDiskLocation;
        
        /// <summary>
        /// Optional. Gets or sets blob uri of the Azure disk.
        /// </summary>
        public string TargetDiskLocation
        {
            get { return this._targetDiskLocation; }
            set { this._targetDiskLocation = value; }
        }
        
        private string _targetDiskName;
        
        /// <summary>
        /// Optional. Gets or sets Azure disk name.
        /// </summary>
        public string TargetDiskName
        {
            get { return this._targetDiskName; }
            set { this._targetDiskName = value; }
        }
        
        private string _vhdId;
        
        /// <summary>
        /// Optional. Gets or sets the VHD id.
        /// </summary>
        public string VhdId
        {
            get { return this._vhdId; }
            set { this._vhdId = value; }
        }
        
        private string _vhdName;
        
        /// <summary>
        /// Optional. Gets or sets VHD name.
        /// </summary>
        public string VhdName
        {
            get { return this._vhdName; }
            set { this._vhdName = value; }
        }
        
        private string _vhdType;
        
        /// <summary>
        /// Optional. Gets or sets VHD type.
        /// </summary>
        public string VhdType
        {
            get { return this._vhdType; }
            set { this._vhdType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureVmDiskDetails class.
        /// </summary>
        public AzureVmDiskDetails()
        {
        }
    }
}
