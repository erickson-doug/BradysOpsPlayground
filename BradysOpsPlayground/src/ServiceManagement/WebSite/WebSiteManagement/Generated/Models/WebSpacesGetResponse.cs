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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// The Get Web Space Details operation response.
    /// </summary>
    public partial class WebSpacesGetResponse : AzureOperationResponse
    {
        private WebSpaceAvailabilityState _availabilityState;
        
        /// <summary>
        /// Optional. The current availability state. Possible values are
        /// Normal or Limited.
        /// </summary>
        public WebSpaceAvailabilityState AvailabilityState
        {
            get { return this._availabilityState; }
            set { this._availabilityState = value; }
        }
        
        private int? _currentNumberOfWorkers;
        
        /// <summary>
        /// Optional. The current number of workers.
        /// </summary>
        public int? CurrentNumberOfWorkers
        {
            get { return this._currentNumberOfWorkers; }
            set { this._currentNumberOfWorkers = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.WorkerSizeOptions? _currentWorkerSize;
        
        /// <summary>
        /// Optional. The current worker size. Possible values are Small,
        /// Medium, or Large.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WorkerSizeOptions? CurrentWorkerSize
        {
            get { return this._currentWorkerSize; }
            set { this._currentWorkerSize = value; }
        }
        
        private string _geoLocation;
        
        /// <summary>
        /// Optional. The location of the datacenter for the web space.
        /// </summary>
        public string GeoLocation
        {
            get { return this._geoLocation; }
            set { this._geoLocation = value; }
        }
        
        private string _geoRegion;
        
        /// <summary>
        /// Optional. The geographical region where the web space is located.
        /// </summary>
        public string GeoRegion
        {
            get { return this._geoRegion; }
            set { this._geoRegion = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the web space.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _plan;
        
        /// <summary>
        /// Optional. The web space plan name.
        /// </summary>
        public string Plan
        {
            get { return this._plan; }
            set { this._plan = value; }
        }
        
        private WebSpaceStatus _status;
        
        /// <summary>
        /// Optional. The status of the Web Space. Possible values are Ready or
        /// Limited. Note: The Limited status occurs only if the datacenter is
        /// encountering an operational issue.
        /// </summary>
        public WebSpaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _subscription;
        
        /// <summary>
        /// Optional. The subscription ID.
        /// </summary>
        public string Subscription
        {
            get { return this._subscription; }
            set { this._subscription = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.WorkerSizeOptions? _workerSize;
        
        /// <summary>
        /// Optional. The worker size. Possible values are Small, Medium, and
        /// Large. For JSON, the equivalents are 0 = Small, 1 = Medium, and 2
        /// = Large.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WorkerSizeOptions? WorkerSize
        {
            get { return this._workerSize; }
            set { this._workerSize = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSpacesGetResponse class.
        /// </summary>
        public WebSpacesGetResponse()
        {
        }
    }
}
