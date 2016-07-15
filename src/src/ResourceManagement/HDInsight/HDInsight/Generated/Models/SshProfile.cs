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
using Microsoft.Azure.Management.HDInsight.Models;

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class SshProfile
    {
        private IList<SshPublicKey> _sshPublicKeys;
        
        /// <summary>
        /// Optional. Gets or sets the list of SSH public keys.
        /// </summary>
        public IList<SshPublicKey> SshPublicKeys
        {
            get { return this._sshPublicKeys; }
            set { this._sshPublicKeys = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SshProfile class.
        /// </summary>
        public SshProfile()
        {
            this.SshPublicKeys = new LazyList<SshPublicKey>();
        }
    }
}
