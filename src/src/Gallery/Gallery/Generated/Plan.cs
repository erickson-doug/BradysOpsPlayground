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

namespace Microsoft.Azure.Gallery
{
    /// <summary>
    /// A gallery item plan.
    /// </summary>
    public partial class Plan
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the plan description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets the plan display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _planIdentifier;
        
        /// <summary>
        /// Optional. Gets or sets the plan identifier.
        /// </summary>
        public string PlanIdentifier
        {
            get { return this._planIdentifier; }
            set { this._planIdentifier = value; }
        }
        
        private string _summary;
        
        /// <summary>
        /// Optional. Gets or sets the plan summary.
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan()
        {
        }
    }
}
