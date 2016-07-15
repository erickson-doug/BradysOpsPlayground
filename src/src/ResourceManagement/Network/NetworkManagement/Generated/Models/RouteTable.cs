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
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// RouteTable resource
    /// </summary>
    public partial class RouteTable : TopLevelResource
    {
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private IList<Route> _routes;
        
        /// <summary>
        /// Optional. Gets or sets Routes in a Route Table
        /// </summary>
        public IList<Route> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }
        
        private IList<ResourceId> _subnets;
        
        /// <summary>
        /// Optional. Gets collection of references to subnets
        /// </summary>
        public IList<ResourceId> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RouteTable class.
        /// </summary>
        public RouteTable()
        {
            this.Routes = new LazyList<Route>();
            this.Subnets = new LazyList<ResourceId>();
        }
        
        /// <summary>
        /// Initializes a new instance of the RouteTable class with required
        /// arguments.
        /// </summary>
        public RouteTable(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
