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

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class ConnectivityEndpoint
    {
        private string _location;
        
        /// <summary>
        /// Optional. Gets or sets the location of the endpoint.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the endpoint.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int _port;
        
        /// <summary>
        /// Optional. Gets or sets the port to connect to.
        /// </summary>
        public int Port
        {
            get { return this._port; }
            set { this._port = value; }
        }
        
        private string _protocol;
        
        /// <summary>
        /// Optional. Gets or sets the protocol of the endpoint.
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ConnectivityEndpoint class.
        /// </summary>
        public ConnectivityEndpoint()
        {
        }
    }
}
