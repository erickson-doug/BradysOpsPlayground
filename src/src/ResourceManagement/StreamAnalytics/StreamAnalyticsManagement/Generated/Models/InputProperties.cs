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
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of the input for the stream analytics job.
    /// </summary>
    public abstract partial class InputProperties
    {
        private Diagnostics _diagnostics;
        
        /// <summary>
        /// Optional. Gets conditions applicable to the Input, Output, or the
        /// job overall, that warrant customer attention.
        /// </summary>
        public Diagnostics Diagnostics
        {
            get { return this._diagnostics; }
            set { this._diagnostics = value; }
        }
        
        private string _etag;
        
        /// <summary>
        /// Optional. Gets or sets the etag of the input properties.
        /// </summary>
        public string Etag
        {
            get { return this._etag; }
            set { this._etag = value; }
        }
        
        private Serialization _serialization;
        
        /// <summary>
        /// Optional. Gets or sets the serialization configuration of the input.
        /// </summary>
        public Serialization Serialization
        {
            get { return this._serialization; }
            set { this._serialization = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets the type of the input property.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InputProperties class.
        /// </summary>
        public InputProperties()
        {
        }
    }
}
