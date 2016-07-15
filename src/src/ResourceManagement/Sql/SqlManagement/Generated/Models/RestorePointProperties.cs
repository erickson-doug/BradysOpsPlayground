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

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database restore point.
    /// </summary>
    public partial class RestorePointProperties
    {
        private System.DateTime? _earliestRestoreDate;
        
        /// <summary>
        /// Optional. Earliest restore time. Populated when restorePointType =
        /// DISCRETE. Null otherwise.
        /// </summary>
        public System.DateTime? EarliestRestoreDate
        {
            get { return this._earliestRestoreDate; }
            set { this._earliestRestoreDate = value; }
        }
        
        private System.DateTime? _restorePointCreationDate;
        
        /// <summary>
        /// Optional. Restore point creation time. Populated when
        /// restorePointType = CONTINUOUS. Null otherwise.
        /// </summary>
        public System.DateTime? RestorePointCreationDate
        {
            get { return this._restorePointCreationDate; }
            set { this._restorePointCreationDate = value; }
        }
        
        private string _restorePointType;
        
        /// <summary>
        /// Optional. Gets the restore point type of the Azure SQL Database
        /// restore point.
        /// </summary>
        public string RestorePointType
        {
            get { return this._restorePointType; }
            set { this._restorePointType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RestorePointProperties class.
        /// </summary>
        public RestorePointProperties()
        {
        }
    }
}
