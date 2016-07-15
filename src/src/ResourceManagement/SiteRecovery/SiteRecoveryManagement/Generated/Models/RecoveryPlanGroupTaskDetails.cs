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
    /// The definition of recovery plan group task details object.
    /// </summary>
    public partial class RecoveryPlanGroupTaskDetails : GroupTaskDetails
    {
        private string _groupId;
        
        /// <summary>
        /// Required. Group Identifier.
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Name of recovery plan group task.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _rpGroupType;
        
        /// <summary>
        /// Required. Group type.
        /// </summary>
        public string RpGroupType
        {
            get { return this._rpGroupType; }
            set { this._rpGroupType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroupTaskDetails
        /// class.
        /// </summary>
        public RecoveryPlanGroupTaskDetails()
        {
        }
    }
}
