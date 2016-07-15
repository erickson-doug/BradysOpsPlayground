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
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Management.Storage.Models
{
    /// <summary>
    /// Describes Storage Resource Usage.
    /// </summary>
    public partial class Usage
    {
        private int _currentValue;
        
        /// <summary>
        /// Required. Gets the current count of the allocated resources in the
        /// subscription.
        /// </summary>
        public int CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
        }
        
        private int _limit;
        
        /// <summary>
        /// Required. Gets the maximum count of the resources that can be
        /// allocated in the subscription.
        /// </summary>
        public int Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }
        
        private UsageName _name;
        
        /// <summary>
        /// Required. Gets the name of the type of usage.
        /// </summary>
        public UsageName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private UsageUnit _unit;
        
        /// <summary>
        /// Required. Gets the unit of measurement.
        /// </summary>
        public UsageUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage()
        {
        }
    }
}
