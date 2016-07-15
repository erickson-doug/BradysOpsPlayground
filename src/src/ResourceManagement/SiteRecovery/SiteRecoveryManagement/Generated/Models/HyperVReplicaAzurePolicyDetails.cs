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
    /// HyperV Replica Azure Policy Details.
    /// </summary>
    public partial class HyperVReplicaAzurePolicyDetails : PolicyProviderSettingsDetails
    {
        private string _activeStorageAccountId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ActiveStorageAccountId
        {
            get { return this._activeStorageAccountId; }
            set { this._activeStorageAccountId = value; }
        }
        
        private int _applicationConsistentSnapshotFrequencyInHours;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int ApplicationConsistentSnapshotFrequencyInHours
        {
            get { return this._applicationConsistentSnapshotFrequencyInHours; }
            set { this._applicationConsistentSnapshotFrequencyInHours = value; }
        }
        
        private string _encryption;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }
        
        private System.TimeSpan? _onlineReplicationStartTime;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public System.TimeSpan? OnlineReplicationStartTime
        {
            get { return this._onlineReplicationStartTime; }
            set { this._onlineReplicationStartTime = value; }
        }
        
        private int _recoveryPointHistoryDurationInHours;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int RecoveryPointHistoryDurationInHours
        {
            get { return this._recoveryPointHistoryDurationInHours; }
            set { this._recoveryPointHistoryDurationInHours = value; }
        }
        
        private int _replicationInterval;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int ReplicationInterval
        {
            get { return this._replicationInterval; }
            set { this._replicationInterval = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzurePolicyDetails
        /// class.
        /// </summary>
        public HyperVReplicaAzurePolicyDetails()
        {
        }
    }
}
