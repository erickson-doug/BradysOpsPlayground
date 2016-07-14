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

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The parameters Azure uses to create the operating system disk for the
    /// virtual machine.
    /// </summary>
    public partial class OSVirtualHardDisk
    {
        private string _hostCaching;
        
        /// <summary>
        /// Optional. Specifies the platform caching behavior of the operating
        /// system disk blob for read/write efficiency.
        /// </summary>
        public string HostCaching
        {
            get { return this._hostCaching; }
            set { this._hostCaching = value; }
        }
        
        private string _iOType;
        
        /// <summary>
        /// Optional. Gets or sets the IO type.
        /// </summary>
        public string IOType
        {
            get { return this._iOType; }
            set { this._iOType = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. Specifies the friendly name of an operating system image
        /// in the image repository.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private Uri _mediaLink;
        
        /// <summary>
        /// Optional. Specifies the location of the operating system disk in
        /// Azure storage.
        /// </summary>
        public Uri MediaLink
        {
            get { return this._mediaLink; }
            set { this._mediaLink = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Specifies the name of an operating system image in the
        /// image repository.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _operatingSystem;
        
        /// <summary>
        /// Optional. The operating system running in the virtual machine.
        /// </summary>
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }
        
        private Uri _remoteSourceImageLink;
        
        /// <summary>
        /// Optional. Uri of the source OS image that will be copied to the
        /// customer’s storage account of VM creation.If RemoteSourceImageLink
        /// is specified, then MediaLink must also be specified.If
        /// RemoteSourceImageLink is specified, thenSourceIamgeName must not
        /// be specified.
        /// </summary>
        public Uri RemoteSourceImageLink
        {
            get { return this._remoteSourceImageLink; }
            set { this._remoteSourceImageLink = value; }
        }
        
        private int? _resizedSizeInGB;
        
        /// <summary>
        /// Optional. When an OS Image or a RemoteSourceImage is used to create
        /// an OSVirtualHardDisk, this parameter can be used to resize the new
        /// OSVirtualHardDisk to a larger size. ResizedSizeInGB must be larger
        /// than the underlying OS Image’s LogicalSizeInGB.
        /// </summary>
        public int? ResizedSizeInGB
        {
            get { return this._resizedSizeInGB; }
            set { this._resizedSizeInGB = value; }
        }
        
        private string _sourceImageName;
        
        /// <summary>
        /// Optional. Specifies the name of the source image that was used to
        /// provision the virtual machine.
        /// </summary>
        public string SourceImageName
        {
            get { return this._sourceImageName; }
            set { this._sourceImageName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OSVirtualHardDisk class.
        /// </summary>
        public OSVirtualHardDisk()
        {
        }
    }
}
