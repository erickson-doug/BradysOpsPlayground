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
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    public abstract partial class WebJobBase
    {
        private string _error;
        
        /// <summary>
        /// Optional. The error if there was one.
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        private string _extraInfoUrl;
        
        /// <summary>
        /// Optional. The extra information url.
        /// </summary>
        public string ExtraInfoUrl
        {
            get { return this._extraInfoUrl; }
            set { this._extraInfoUrl = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _runCommand;
        
        /// <summary>
        /// Optional. The run command.
        /// </summary>
        public string RunCommand
        {
            get { return this._runCommand; }
            set { this._runCommand = value; }
        }
        
        private WebJobType _type;
        
        /// <summary>
        /// Optional. The type.
        /// </summary>
        public WebJobType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private Uri _url;
        
        /// <summary>
        /// Optional. The url.
        /// </summary>
        public Uri Url
        {
            get { return this._url; }
            set { this._url = value; }
        }
        
        private bool _usingSdk;
        
        /// <summary>
        /// Optional. True if the job is using the WebJobs SDK otherwise false.
        /// </summary>
        public bool UsingSdk
        {
            get { return this._usingSdk; }
            set { this._usingSdk = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebJobBase class.
        /// </summary>
        public WebJobBase()
        {
        }
    }
}
