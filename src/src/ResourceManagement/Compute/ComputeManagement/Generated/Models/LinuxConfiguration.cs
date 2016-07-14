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
    /// Describes Windows Configuration of the OS Profile.
    /// </summary>
    public partial class LinuxConfiguration
    {
        private bool? _disablePasswordAuthentication;
        
        /// <summary>
        /// Optional. Gets or sets whether Authentication using user name and
        /// password is allowed or not
        /// </summary>
        public bool? DisablePasswordAuthentication
        {
            get { return this._disablePasswordAuthentication; }
            set { this._disablePasswordAuthentication = value; }
        }
        
        private SshConfiguration _sshConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets the SSH configuration for linux VMs
        /// </summary>
        public SshConfiguration SshConfiguration
        {
            get { return this._sshConfiguration; }
            set { this._sshConfiguration = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        public LinuxConfiguration()
        {
        }
    }
}
