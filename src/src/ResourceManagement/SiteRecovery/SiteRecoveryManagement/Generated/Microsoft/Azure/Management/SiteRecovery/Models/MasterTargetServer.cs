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
    /// The details of a Master Target server.
    /// </summary>
    public partial class MasterTargetServer
    {
        private string _agentVersion;
        
        /// <summary>
        /// Optional. The version of the scout component on the server.
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }
        
        private IList<DataStore> _dataStores;
        
        /// <summary>
        /// Optional. The data stores in the fabric.
        /// </summary>
        public IList<DataStore> DataStores
        {
            get { return this._dataStores; }
            set { this._dataStores = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. The server Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. The IP address of the server.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. The last heartbeat received from the server.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The server name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _osType;
        
        /// <summary>
        /// Optional. The OS type of the server.
        /// </summary>
        public string OsType
        {
            get { return this._osType; }
            set { this._osType = value; }
        }
        
        private IList<RetentionVolume> _retentionVolumes;
        
        /// <summary>
        /// Optional. The retention volumes of Master target Server.
        /// </summary>
        public IList<RetentionVolume> RetentionVolumes
        {
            get { return this._retentionVolumes; }
            set { this._retentionVolumes = value; }
        }
        
        private string _versionStatus;
        
        /// <summary>
        /// Optional. The version status
        /// </summary>
        public string VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MasterTargetServer class.
        /// </summary>
        public MasterTargetServer()
        {
            this.DataStores = new LazyList<DataStore>();
            this.RetentionVolumes = new LazyList<RetentionVolume>();
        }
    }
}
