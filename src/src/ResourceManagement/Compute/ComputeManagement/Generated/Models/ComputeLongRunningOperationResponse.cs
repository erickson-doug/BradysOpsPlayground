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
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// The Compute service response for long-running operations.
    /// </summary>
    public partial class ComputeLongRunningOperationResponse : AzureOperationResponse
    {
        private System.DateTimeOffset? _endTime;
        
        /// <summary>
        /// Optional. Gets the operation end time
        /// </summary>
        public System.DateTimeOffset? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private ApiError _error;
        
        /// <summary>
        /// Optional. Gets the operation error, if any occurred.
        /// </summary>
        public ApiError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        private string _output;
        
        /// <summary>
        /// Optional. Operation output data (raw JSON)
        /// </summary>
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }
        
        private DateTimeOffset _startTime;
        
        /// <summary>
        /// Optional. Gets the operation start time
        /// </summary>
        public DateTimeOffset StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private ComputeOperationStatus _status;
        
        /// <summary>
        /// Optional. Gets the operation status.
        /// </summary>
        public ComputeOperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _trackingOperationId;
        
        /// <summary>
        /// Optional. Gets the operation identifier.
        /// </summary>
        public string TrackingOperationId
        {
            get { return this._trackingOperationId; }
            set { this._trackingOperationId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ComputeLongRunningOperationResponse class.
        /// </summary>
        public ComputeLongRunningOperationResponse()
        {
        }
    }
}
