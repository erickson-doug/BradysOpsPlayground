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
    /// Onprem disk details data.
    /// </summary>
    public partial class InMageDiskDetails
    {
        private string _diskConfiguration;
        
        /// <summary>
        /// Optional. Disk Configuration.
        /// </summary>
        public string DiskConfiguration
        {
            get { return this._diskConfiguration; }
            set { this._diskConfiguration = value; }
        }
        
        private string _diskId;
        
        /// <summary>
        /// Optional. Disk ID.
        /// </summary>
        public string DiskId
        {
            get { return this._diskId; }
            set { this._diskId = value; }
        }
        
        private string _diskName;
        
        /// <summary>
        /// Optional. Disk Name.
        /// </summary>
        public string DiskName
        {
            get { return this._diskName; }
            set { this._diskName = value; }
        }
        
        private string _diskSizeInMB;
        
        /// <summary>
        /// Optional. Disk size in MB.
        /// </summary>
        public string DiskSizeInMB
        {
            get { return this._diskSizeInMB; }
            set { this._diskSizeInMB = value; }
        }
        
        private string _diskType;
        
        /// <summary>
        /// Optional. Disk Type.
        /// </summary>
        public string DiskType
        {
            get { return this._diskType; }
            set { this._diskType = value; }
        }
        
        private IList<DiskVolumeDetails> _volumeList;
        
        /// <summary>
        /// Optional. Volumes of the Disk.
        /// </summary>
        public IList<DiskVolumeDetails> VolumeList
        {
            get { return this._volumeList; }
            set { this._volumeList = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InMageDiskDetails class.
        /// </summary>
        public InMageDiskDetails()
        {
            this.VolumeList = new LazyList<DiskVolumeDetails>();
        }
    }
}
