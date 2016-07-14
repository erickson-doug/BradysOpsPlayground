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
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// Represents the properties of a Web Hosting Plan.
    /// </summary>
    public partial class WebHostingPlanProperties
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
        
        private int _numberOfWorkers;
        
        /// <summary>
        /// Optional. The instance count, which is the number of virtual
        /// machines dedicated to the Web Hosting Plan. Supported values are
        /// positive integers.
        /// </summary>
        public int NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }
        
        private SkuOptions _sku;
        
        /// <summary>
        /// Optional. The Web Hosting Plan SKU.
        /// </summary>
        public SkuOptions Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private WorkerSizeOptions _workerSize;
        
        /// <summary>
        /// Optional. The instance size. Possible values are Small, Medium, or
        /// Large.
        /// </summary>
        public WorkerSizeOptions WorkerSize
        {
            get { return this._workerSize; }
            set { this._workerSize = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebHostingPlanProperties class.
        /// </summary>
        public WebHostingPlanProperties()
        {
        }
    }
}
