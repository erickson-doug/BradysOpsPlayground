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

namespace Microsoft.Azure.Graph.RBAC.Models
{
    /// <summary>
    /// Active Directory service principal Password Credential information
    /// </summary>
    public partial class PasswordCredential
    {
        private DateTime _endDate;
        
        /// <summary>
        /// Optional. Gets or sets end date
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }
        
        private Guid _keyId;
        
        /// <summary>
        /// Optional. Gets or sets key Id
        /// </summary>
        public Guid KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }
        
        private DateTime _startDate;
        
        /// <summary>
        /// Optional. Gets or sets start date
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Gets or sets value
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PasswordCredential class.
        /// </summary>
        public PasswordCredential()
        {
        }
    }
}
