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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// InMageAzureV2 failover input.
    /// </summary>
    public partial class RecoveryPlanInMageAzureV2FailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        private string _recoveryPointType;
        
        /// <summary>
        /// Required. Recovery point type.
        /// </summary>
        public string RecoveryPointType
        {
            get { return this._recoveryPointType; }
            set { this._recoveryPointType = value; }
        }
        
        private string _vaultLocation;
        
        /// <summary>
        /// Required. Vault location.
        /// </summary>
        public string VaultLocation
        {
            get { return this._vaultLocation; }
            set { this._vaultLocation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanInMageAzureV2FailoverInput class.
        /// </summary>
        public RecoveryPlanInMageAzureV2FailoverInput()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanInMageAzureV2FailoverInput class with required
        /// arguments.
        /// </summary>
        public RecoveryPlanInMageAzureV2FailoverInput(string vaultLocation, string recoveryPointType)
            : this()
        {
            if (vaultLocation == null)
            {
                throw new ArgumentNullException("vaultLocation");
            }
            if (recoveryPointType == null)
            {
                throw new ArgumentNullException("recoveryPointType");
            }
            this.VaultLocation = vaultLocation;
            this.RecoveryPointType = recoveryPointType;
        }
    }
}
