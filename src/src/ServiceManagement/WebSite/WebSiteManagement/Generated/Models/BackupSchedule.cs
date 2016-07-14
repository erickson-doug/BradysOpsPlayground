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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// Defines a backup schedule for a website.
    /// </summary>
    public partial class BackupSchedule
    {
        private int _frequencyInterval;
        
        /// <summary>
        /// Optional. The frequency of backups.
        /// </summary>
        public int FrequencyInterval
        {
            get { return this._frequencyInterval; }
            set { this._frequencyInterval = value; }
        }
        
        private FrequencyUnit _frequencyUnit;
        
        /// <summary>
        /// Optional. Units for FrequencyInterval - e.g. Day or Hour
        /// </summary>
        public FrequencyUnit FrequencyUnit
        {
            get { return this._frequencyUnit; }
            set { this._frequencyUnit = value; }
        }
        
        private bool _keepAtLeastOneBackup;
        
        /// <summary>
        /// Optional. Retention policy deletes backups after predefined number
        /// of days. If this is true, there will be always at least one backup
        /// left. regardless of the policy. If false, all backups can be
        /// deleted.
        /// </summary>
        public bool KeepAtLeastOneBackup
        {
            get { return this._keepAtLeastOneBackup; }
            set { this._keepAtLeastOneBackup = value; }
        }
        
        private System.DateTime? _lastExecutionTime;
        
        /// <summary>
        /// Optional. The last time when this schedule started a backup, Null
        /// if didn't start anything yet.
        /// </summary>
        public System.DateTime? LastExecutionTime
        {
            get { return this._lastExecutionTime; }
            set { this._lastExecutionTime = value; }
        }
        
        private int _retentionPeriodInDays;
        
        /// <summary>
        /// Optional. Backups older N days (N defined by this value) will be
        /// automatically deleted.
        /// </summary>
        public int RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }
        
        private System.DateTime? _startTime;
        
        /// <summary>
        /// Optional. When this schedule should start backing up the site. Null
        /// means immediately.
        /// </summary>
        public System.DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupSchedule class.
        /// </summary>
        public BackupSchedule()
        {
        }
    }
}
