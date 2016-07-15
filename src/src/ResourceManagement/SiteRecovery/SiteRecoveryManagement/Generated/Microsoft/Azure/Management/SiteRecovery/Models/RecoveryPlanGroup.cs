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
    /// Recovery plan group object.
    /// </summary>
    public partial class RecoveryPlanGroup
    {
        private IList<RecoveryPlanAction> _endGroupActions;
        
        /// <summary>
        /// Optional. Recovery plan end group actions.
        /// </summary>
        public IList<RecoveryPlanAction> EndGroupActions
        {
            get { return this._endGroupActions; }
            set { this._endGroupActions = value; }
        }
        
        private string _groupType;
        
        /// <summary>
        /// Required. Group type.
        /// </summary>
        public string GroupType
        {
            get { return this._groupType; }
            set { this._groupType = value; }
        }
        
        private IList<RecoveryPlanProtectedItem> _replicationProtectedItems;
        
        /// <summary>
        /// Optional. List of protected items.
        /// </summary>
        public IList<RecoveryPlanProtectedItem> ReplicationProtectedItems
        {
            get { return this._replicationProtectedItems; }
            set { this._replicationProtectedItems = value; }
        }
        
        private IList<RecoveryPlanAction> _startGroupActions;
        
        /// <summary>
        /// Optional. Recovery plan start group actions.
        /// </summary>
        public IList<RecoveryPlanAction> StartGroupActions
        {
            get { return this._startGroupActions; }
            set { this._startGroupActions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroup class.
        /// </summary>
        public RecoveryPlanGroup()
        {
            this.EndGroupActions = new LazyList<RecoveryPlanAction>();
            this.ReplicationProtectedItems = new LazyList<RecoveryPlanProtectedItem>();
            this.StartGroupActions = new LazyList<RecoveryPlanAction>();
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroup class with
        /// required arguments.
        /// </summary>
        public RecoveryPlanGroup(string groupType)
            : this()
        {
            if (groupType == null)
            {
                throw new ArgumentNullException("groupType");
            }
            this.GroupType = groupType;
        }
    }
}
