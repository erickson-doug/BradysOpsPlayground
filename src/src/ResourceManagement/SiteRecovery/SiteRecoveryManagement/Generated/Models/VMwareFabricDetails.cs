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
    /// Store the extended details of the VMware fabric.
    /// </summary>
    public partial class VMwareFabricDetails : FabricSpecificDetails
    {
        private string _agentCount;
        
        /// <summary>
        /// Optional. The number of source and target servers configured to
        /// talk to this fabric.
        /// </summary>
        public string AgentCount
        {
            get { return this._agentCount; }
            set { this._agentCount = value; }
        }
        
        private string _agentVersion;
        
        /// <summary>
        /// Optional. The agent Version.
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }
        
        private long _availableMemoryInBytes;
        
        /// <summary>
        /// Optional. The available memory.
        /// </summary>
        public long AvailableMemoryInBytes
        {
            get { return this._availableMemoryInBytes; }
            set { this._availableMemoryInBytes = value; }
        }
        
        private long _availableSpaceInBytes;
        
        /// <summary>
        /// Optional. The available space.
        /// </summary>
        public long AvailableSpaceInBytes
        {
            get { return this._availableSpaceInBytes; }
            set { this._availableSpaceInBytes = value; }
        }
        
        private string _cpuLoad;
        
        /// <summary>
        /// Optional. The percentage of the CPU load.
        /// </summary>
        public string CpuLoad
        {
            get { return this._cpuLoad; }
            set { this._cpuLoad = value; }
        }
        
        private string _cpuLoadStatus;
        
        /// <summary>
        /// Optional. The CPU load status.
        /// </summary>
        public string CpuLoadStatus
        {
            get { return this._cpuLoadStatus; }
            set { this._cpuLoadStatus = value; }
        }
        
        private string _csServiceStatus;
        
        /// <summary>
        /// Optional. The CS service status.
        /// </summary>
        public string CsServiceStatus
        {
            get { return this._csServiceStatus; }
            set { this._csServiceStatus = value; }
        }
        
        private string _databaseServerLoad;
        
        /// <summary>
        /// Optional. The database server load.
        /// </summary>
        public string DatabaseServerLoad
        {
            get { return this._databaseServerLoad; }
            set { this._databaseServerLoad = value; }
        }
        
        private string _databaseServerLoadStatus;
        
        /// <summary>
        /// Optional. The database server load status.
        /// </summary>
        public string DatabaseServerLoadStatus
        {
            get { return this._databaseServerLoadStatus; }
            set { this._databaseServerLoadStatus = value; }
        }
        
        private string _hostName;
        
        /// <summary>
        /// Optional. The host name.
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. The IP address.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. The last heartbeat received from CS server.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private IList<MasterTargetServer> _masterTargetServers;
        
        /// <summary>
        /// Optional. The list of Master Target servers associated with the
        /// fabric.
        /// </summary>
        public IList<MasterTargetServer> MasterTargetServers
        {
            get { return this._masterTargetServers; }
            set { this._masterTargetServers = value; }
        }
        
        private string _memoryUsageStatus;
        
        /// <summary>
        /// Optional. The memory usage status.
        /// </summary>
        public string MemoryUsageStatus
        {
            get { return this._memoryUsageStatus; }
            set { this._memoryUsageStatus = value; }
        }
        
        private string _processServerCount;
        
        /// <summary>
        /// Optional. The number of process servers.
        /// </summary>
        public string ProcessServerCount
        {
            get { return this._processServerCount; }
            set { this._processServerCount = value; }
        }
        
        private IList<ProcessServer> _processServers;
        
        /// <summary>
        /// Optional. The list of Process Servers associated with the fabric.
        /// </summary>
        public IList<ProcessServer> ProcessServers
        {
            get { return this._processServers; }
            set { this._processServers = value; }
        }
        
        private string _protectedServers;
        
        /// <summary>
        /// Optional. The number of protected servers.
        /// </summary>
        public string ProtectedServers
        {
            get { return this._protectedServers; }
            set { this._protectedServers = value; }
        }
        
        private string _replicationPairCount;
        
        /// <summary>
        /// Optional. The number of replication pairs configured in this CS.
        /// </summary>
        public string ReplicationPairCount
        {
            get { return this._replicationPairCount; }
            set { this._replicationPairCount = value; }
        }
        
        private IList<RunAsAccount> _runAsAccounts;
        
        /// <summary>
        /// Optional. The list of RunAs accounts registered with the fabric.
        /// </summary>
        public IList<RunAsAccount> RunAsAccounts
        {
            get { return this._runAsAccounts; }
            set { this._runAsAccounts = value; }
        }
        
        private string _spaceUsageStatus;
        
        /// <summary>
        /// Optional. The space usage status.
        /// </summary>
        public string SpaceUsageStatus
        {
            get { return this._spaceUsageStatus; }
            set { this._spaceUsageStatus = value; }
        }
        
        private string _systemLoad;
        
        /// <summary>
        /// Optional. The percentage of the system load.
        /// </summary>
        public string SystemLoad
        {
            get { return this._systemLoad; }
            set { this._systemLoad = value; }
        }
        
        private string _systemLoadStatus;
        
        /// <summary>
        /// Optional. The system load status.
        /// </summary>
        public string SystemLoadStatus
        {
            get { return this._systemLoadStatus; }
            set { this._systemLoadStatus = value; }
        }
        
        private long _totalMemoryInBytes;
        
        /// <summary>
        /// Optional. The total memory.
        /// </summary>
        public long TotalMemoryInBytes
        {
            get { return this._totalMemoryInBytes; }
            set { this._totalMemoryInBytes = value; }
        }
        
        private long _totalSpaceInBytes;
        
        /// <summary>
        /// Optional. The total space.
        /// </summary>
        public long TotalSpaceInBytes
        {
            get { return this._totalSpaceInBytes; }
            set { this._totalSpaceInBytes = value; }
        }
        
        private string _versionStatus;
        
        /// <summary>
        /// Optional. The version status.
        /// </summary>
        public string VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }
        
        private string _webLoad;
        
        /// <summary>
        /// Optional. The web load.
        /// </summary>
        public string WebLoad
        {
            get { return this._webLoad; }
            set { this._webLoad = value; }
        }
        
        private string _webLoadStatus;
        
        /// <summary>
        /// Optional. The web load status.
        /// </summary>
        public string WebLoadStatus
        {
            get { return this._webLoadStatus; }
            set { this._webLoadStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareFabricDetails class.
        /// </summary>
        public VMwareFabricDetails()
        {
            this.MasterTargetServers = new LazyList<MasterTargetServer>();
            this.ProcessServers = new LazyList<ProcessServer>();
            this.RunAsAccounts = new LazyList<RunAsAccount>();
        }
    }
}
