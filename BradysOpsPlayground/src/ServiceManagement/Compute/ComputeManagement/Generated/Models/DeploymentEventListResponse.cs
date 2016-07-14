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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Identifies the list of reboot events due to planned maintenance that
    /// impacted a deployment in the optionally provided timeframe.
    /// </summary>
    public partial class DeploymentEventListResponse : AzureOperationResponse
    {
        private string _continuationToken;
        
        /// <summary>
        /// Optional. Gets or sets the deployment event's continuation token
        /// value.
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }
        
        private IList<RebootEvent> _deploymentEvents;
        
        /// <summary>
        /// Optional. Gets or sets the list of reboot events.
        /// </summary>
        public IList<RebootEvent> DeploymentEvents
        {
            get { return this._deploymentEvents; }
            set { this._deploymentEvents = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentEventListResponse class.
        /// </summary>
        public DeploymentEventListResponse()
        {
            this.DeploymentEvents = new LazyList<RebootEvent>();
        }
    }
}
