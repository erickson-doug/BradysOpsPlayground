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
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// Describes conditions applicable to the Input, Output, or the job
    /// overall, that warrant customer attention.
    /// </summary>
    public partial class Diagnostics
    {
        private IList<DiagnosticCondition> _conditions;
        
        /// <summary>
        /// Optional. Gets a collection of zero or more conditions applicable
        /// to the resource, or to the job overall, that warrant customer
        /// attention.
        /// </summary>
        public IList<DiagnosticCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Diagnostics class.
        /// </summary>
        public Diagnostics()
        {
            this.Conditions = new LazyList<DiagnosticCondition>();
        }
    }
}
