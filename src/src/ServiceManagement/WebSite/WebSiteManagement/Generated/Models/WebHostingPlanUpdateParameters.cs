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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// Parameters supplied to the Update Web Web Hosting Plan operation.
    /// </summary>
    public partial class WebHostingPlanUpdateParameters
    {
        private string _adminSiteName;
        
        /// <summary>
        /// Optional. The admin site. The admin site is used to deploy site
        /// extensions or contents shared by all site in the plan.
        /// </summary>
        public string AdminSiteName
        {
            get { return this._adminSiteName; }
            set { this._adminSiteName = value; }
        }
        
        private int? _numberOfWorkers;
        
        /// <summary>
        /// Optional. The requested number of workers.
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }
        
        private SkuOptions _sKU;
        
        /// <summary>
        /// Optional. SKU of the Web hosting plan.
        /// </summary>
        public SkuOptions SKU
        {
            get { return this._sKU; }
            set { this._sKU = value; }
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
        /// Initializes a new instance of the WebHostingPlanUpdateParameters
        /// class.
        /// </summary>
        public WebHostingPlanUpdateParameters()
        {
        }
    }
}
