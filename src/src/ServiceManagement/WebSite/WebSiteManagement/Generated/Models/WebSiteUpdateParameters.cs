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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// Parameters supplied to the Update Web Site operation.
    /// </summary>
    public partial class WebSiteUpdateParameters
    {
        private IList<string> _hostNames;
        
        /// <summary>
        /// Optional. An array of strings that contains the public host names
        /// for the web site, including custom domains. Important: When you
        /// add a custom domain in a PUT operation, be sure to include every
        /// host name that you want for the web site. To delete a custom
        /// domain name in a PUT operation, include all of the host names for
        /// the web site that you want to keep, but leave out the one that you
        /// want to delete.
        /// </summary>
        public IList<string> HostNames
        {
            get { return this._hostNames; }
            set { this._hostNames = value; }
        }
        
        private IList<WebSiteUpdateParameters.WebSiteHostNameSslState> _hostNameSslStates;
        
        /// <summary>
        /// Optional. SSL states of host names bound to the web site.
        /// </summary>
        public IList<WebSiteUpdateParameters.WebSiteHostNameSslState> HostNameSslStates
        {
            get { return this._hostNameSslStates; }
            set { this._hostNameSslStates = value; }
        }
        
        private string _serverFarm;
        
        /// <summary>
        /// Optional. String specifying the Server Farm (Web Hosting Plan)
        /// where to place the site. Server Farm must exist.
        /// </summary>
        public string ServerFarm
        {
            get { return this._serverFarm; }
            set { this._serverFarm = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. A string that describes the state of the web site.
        /// Possible values include Stopped, Running, or QuotaExceeded.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteUpdateParameters class.
        /// </summary>
        public WebSiteUpdateParameters()
        {
            this.HostNames = new LazyList<string>();
            this.HostNameSslStates = new LazyList<WebSiteUpdateParameters.WebSiteHostNameSslState>();
        }
        
        /// <summary>
        /// SSL state of a site's hostname.
        /// </summary>
        public partial class WebSiteHostNameSslState
        {
            private string _name;
            
            /// <summary>
            /// Required. The host name.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteSslState? _sslState;
            
            /// <summary>
            /// Required. The SSL state. Possible values are Disabled,
            /// SniEnabled, or IpBasedEnabled.
            /// </summary>
            public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteSslState? SslState
            {
                get { return this._sslState; }
                set { this._sslState = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. A string that contains the thumbprint of the SSL
            /// certificate.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            private bool _toUpdate;
            
            /// <summary>
            /// Required. Indicates whether the SSL state will be updated.
            /// </summary>
            public bool ToUpdate
            {
                get { return this._toUpdate; }
                set { this._toUpdate = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteHostNameSslState class.
            /// </summary>
            public WebSiteHostNameSslState()
            {
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteHostNameSslState class
            /// with required arguments.
            /// </summary>
            public WebSiteHostNameSslState(string name, WebSiteSslState? sslState, bool toUpdate)
                : this()
            {
                if (name == null)
                {
                    throw new ArgumentNullException("name");
                }
                if (sslState == null)
                {
                    throw new ArgumentNullException("sslState");
                }
                this.Name = name;
                this.SslState = sslState;
                this.ToUpdate = toUpdate;
            }
        }
    }
}
