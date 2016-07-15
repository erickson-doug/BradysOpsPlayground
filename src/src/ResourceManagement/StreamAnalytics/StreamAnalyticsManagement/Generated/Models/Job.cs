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
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The request required by the job operation.
    /// </summary>
    public partial class Job
    {
        private string _id;
        
        /// <summary>
        /// Optional. Gets the id of the stream analytics job resource.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Gets or sets the data center location of the stream
        /// analytics job.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the stream analytics job.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private JobProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the job properties.
        /// </summary>
        public JobProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets the tags of the stream analytics job.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets the type of the stream analytics job resource.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Job class with required arguments.
        /// </summary>
        public Job(string name, JobProperties properties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Name = name;
            this.Properties = properties;
        }
    }
}
