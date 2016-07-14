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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// The instance view of a virtual machine.
    /// </summary>
    public partial class VirtualMachineInstanceView : ResourceInstanceView
    {
        private BootDiagnosticsInstanceView _bootDiagnostics;
        
        /// <summary>
        /// Optional. Gets or sets the boot diagnostics.
        /// </summary>
        public BootDiagnosticsInstanceView BootDiagnostics
        {
            get { return this._bootDiagnostics; }
            set { this._bootDiagnostics = value; }
        }
        
        private IList<DiskInstanceView> _disks;
        
        /// <summary>
        /// Optional. Gets or sets the the disks information.
        /// </summary>
        public IList<DiskInstanceView> Disks
        {
            get { return this._disks; }
            set { this._disks = value; }
        }
        
        private IList<VirtualMachineExtensionInstanceView> _extensions;
        
        /// <summary>
        /// Optional. Gets or sets the extensions information.
        /// </summary>
        public IList<VirtualMachineExtensionInstanceView> Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }
        
        private int? _platformFaultDomain;
        
        /// <summary>
        /// Optional. Gets or sets the Fault Domain count.
        /// </summary>
        public int? PlatformFaultDomain
        {
            get { return this._platformFaultDomain; }
            set { this._platformFaultDomain = value; }
        }
        
        private int? _platformUpdateDomain;
        
        /// <summary>
        /// Optional. Gets or sets the Update Domain count.
        /// </summary>
        public int? PlatformUpdateDomain
        {
            get { return this._platformUpdateDomain; }
            set { this._platformUpdateDomain = value; }
        }
        
        private string _remoteDesktopThumbprint;
        
        /// <summary>
        /// Optional. Gets or sets the Remote desktop certificate thumbprint.
        /// </summary>
        public string RemoteDesktopThumbprint
        {
            get { return this._remoteDesktopThumbprint; }
            set { this._remoteDesktopThumbprint = value; }
        }
        
        private VirtualMachineAgentInstanceView _vMAgent;
        
        /// <summary>
        /// Optional. Gets or sets the VM Agent running on the virtual machine.
        /// </summary>
        public VirtualMachineAgentInstanceView VMAgent
        {
            get { return this._vMAgent; }
            set { this._vMAgent = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineInstanceView class.
        /// </summary>
        public VirtualMachineInstanceView()
        {
            this.Disks = new LazyList<DiskInstanceView>();
            this.Extensions = new LazyList<VirtualMachineExtensionInstanceView>();
        }
    }
}
