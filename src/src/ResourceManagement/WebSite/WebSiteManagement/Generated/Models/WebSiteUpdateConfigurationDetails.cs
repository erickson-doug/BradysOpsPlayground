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
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// The Update Web Site Configuration parameters.
    /// </summary>
    public partial class WebSiteUpdateConfigurationDetails
    {
        private bool? _alwaysOn;
        
        /// <summary>
        /// Optional. True if Always On functionality is enabled for the site;
        /// otherwise, false.
        /// </summary>
        public bool? AlwaysOn
        {
            get { return this._alwaysOn; }
            set { this._alwaysOn = value; }
        }
        
        private IDictionary<string, string> _appSettings;
        
        /// <summary>
        /// Optional. A set of name/value pairs that contain application
        /// settings for a site.
        /// </summary>
        public IDictionary<string, string> AppSettings
        {
            get { return this._appSettings; }
            set { this._appSettings = value; }
        }
        
        private string _autoSwapSlotName;
        
        /// <summary>
        /// Optional. Sets the slot name to swap with after successful
        /// deployment.
        /// </summary>
        public string AutoSwapSlotName
        {
            get { return this._autoSwapSlotName; }
            set { this._autoSwapSlotName = value; }
        }
        
        private IList<ConnectionStringInfo> _connectionStrings;
        
        /// <summary>
        /// Optional. Contains connection strings for database and other
        /// external resources.
        /// </summary>
        public IList<ConnectionStringInfo> ConnectionStrings
        {
            get { return this._connectionStrings; }
            set { this._connectionStrings = value; }
        }
        
        private IList<string> _defaultDocuments;
        
        /// <summary>
        /// Optional. Contains one or more string elements that list, in order
        /// of preference, the name of the file that a web site returns when
        /// the web site's domain name is requested by itself. For example, if
        /// the default document for http://contoso.com is default.htm, the
        /// page http://www.contoso.com/default.htm is returned when the
        /// browser is pointed to http://www.contoso.com.
        /// </summary>
        public IList<string> DefaultDocuments
        {
            get { return this._defaultDocuments; }
            set { this._defaultDocuments = value; }
        }
        
        private bool? _detailedErrorLoggingEnabled;
        
        /// <summary>
        /// Optional. True if detailed error logging is enabled; otherwise,
        /// false.
        /// </summary>
        public bool? DetailedErrorLoggingEnabled
        {
            get { return this._detailedErrorLoggingEnabled; }
            set { this._detailedErrorLoggingEnabled = value; }
        }
        
        private string _documentRoot;
        
        /// <summary>
        /// Optional. The document root.
        /// </summary>
        public string DocumentRoot
        {
            get { return this._documentRoot; }
            set { this._documentRoot = value; }
        }
        
        private IList<WebSiteUpdateConfigurationDetails.HandlerMapping> _handlerMappings;
        
        /// <summary>
        /// Optional. Specifies custom executable programs for handling
        /// requests for specific file name extensions.
        /// </summary>
        public IList<WebSiteUpdateConfigurationDetails.HandlerMapping> HandlerMappings
        {
            get { return this._handlerMappings; }
            set { this._handlerMappings = value; }
        }
        
        private bool? _httpLoggingEnabled;
        
        /// <summary>
        /// Optional. True if HTTP error logging is enabled; otherwise, false.
        /// </summary>
        public bool? HttpLoggingEnabled
        {
            get { return this._httpLoggingEnabled; }
            set { this._httpLoggingEnabled = value; }
        }
        
        private SiteLimits _limits;
        
        /// <summary>
        /// Optional. The per site limits.
        /// </summary>
        public SiteLimits Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }
        
        private int? _logsDirectorySizeLimit;
        
        /// <summary>
        /// Optional. The limit of the logs directory.
        /// </summary>
        public int? LogsDirectorySizeLimit
        {
            get { return this._logsDirectorySizeLimit; }
            set { this._logsDirectorySizeLimit = value; }
        }
        
        private Microsoft.Azure.Management.WebSites.Models.ManagedPipelineMode? _managedPipelineMode;
        
        /// <summary>
        /// Optional. Managed pipeline modes.
        /// </summary>
        public Microsoft.Azure.Management.WebSites.Models.ManagedPipelineMode? ManagedPipelineMode
        {
            get { return this._managedPipelineMode; }
            set { this._managedPipelineMode = value; }
        }
        
        private IDictionary<string, string> _metadata;
        
        /// <summary>
        /// Optional. Contains name/value pairs for source control or other
        /// information.
        /// </summary>
        public IDictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }
        
        private string _netFrameworkVersion;
        
        /// <summary>
        /// Optional. The .NET Framework version. Supported values are v2.0,
        /// v4.0 and v4.5.
        /// </summary>
        public string NetFrameworkVersion
        {
            get { return this._netFrameworkVersion; }
            set { this._netFrameworkVersion = value; }
        }
        
        private int? _numberOfWorkers;
        
        /// <summary>
        /// Optional. The number of web workers allotted to the web site. If
        /// the site mode is Free, this value is 1. If the site mode is
        /// Shared, this value can range from 1 through 6. If the site mode is
        /// Standard, this value can range from 1 through 10.
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }
        
        private string _phpVersion;
        
        /// <summary>
        /// Optional. Supported values are an empty string (an empty string
        /// disables PHP), 5.3, 5.4, 5.5 and 5.6.
        /// </summary>
        public string PhpVersion
        {
            get { return this._phpVersion; }
            set { this._phpVersion = value; }
        }
        
        private string _pythonVersion;
        
        /// <summary>
        /// Optional. Supported values are an empty string (an empty string
        /// disables Python), 2.7 and 3.4.
        /// </summary>
        public string PythonVersion
        {
            get { return this._pythonVersion; }
            set { this._pythonVersion = value; }
        }
        
        private bool? _remoteDebuggingEnabled;
        
        /// <summary>
        /// Optional. True remote debugging is enabled; otherwise, false.
        /// </summary>
        public bool? RemoteDebuggingEnabled
        {
            get { return this._remoteDebuggingEnabled; }
            set { this._remoteDebuggingEnabled = value; }
        }
        
        private RemoteDebuggingVersion _remoteDebuggingVersion;
        
        /// <summary>
        /// Optional. True remote debugging version.
        /// </summary>
        public RemoteDebuggingVersion RemoteDebuggingVersion
        {
            get { return this._remoteDebuggingVersion; }
            set { this._remoteDebuggingVersion = value; }
        }
        
        private bool? _requestTracingEnabled;
        
        /// <summary>
        /// Optional. True if request tracing is enabled; otherwise, false.
        /// </summary>
        public bool? RequestTracingEnabled
        {
            get { return this._requestTracingEnabled; }
            set { this._requestTracingEnabled = value; }
        }
        
        private System.DateTime? _requestTracingExpirationTime;
        
        /// <summary>
        /// Optional. Time remaining until request tracing expires.
        /// </summary>
        public System.DateTime? RequestTracingExpirationTime
        {
            get { return this._requestTracingExpirationTime; }
            set { this._requestTracingExpirationTime = value; }
        }
        
        private string _scmType;
        
        /// <summary>
        /// Optional. The source control method that the web site is using (for
        /// example, Local Git). If deployment from source control has not
        /// been set up for the web site, this value is None.
        /// </summary>
        public string ScmType
        {
            get { return this._scmType; }
            set { this._scmType = value; }
        }
        
        private bool? _use32BitWorkerProcess;
        
        /// <summary>
        /// Optional. True if 32-bit mode is enabled; otherwise, false.
        /// </summary>
        public bool? Use32BitWorkerProcess
        {
            get { return this._use32BitWorkerProcess; }
            set { this._use32BitWorkerProcess = value; }
        }
        
        private bool? _webSocketsEnabled;
        
        /// <summary>
        /// Optional. True if Web Sockets are enabled; otherwise, false.
        /// </summary>
        public bool? WebSocketsEnabled
        {
            get { return this._webSocketsEnabled; }
            set { this._webSocketsEnabled = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteUpdateConfigurationDetails
        /// class.
        /// </summary>
        public WebSiteUpdateConfigurationDetails()
        {
            this.AppSettings = new LazyDictionary<string, string>();
            this.ConnectionStrings = new LazyList<ConnectionStringInfo>();
            this.DefaultDocuments = new LazyList<string>();
            this.HandlerMappings = new LazyList<WebSiteUpdateConfigurationDetails.HandlerMapping>();
            this.Metadata = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Specifies a custom executable program for handling requests for
        /// specific file name extensions.
        /// </summary>
        public partial class HandlerMapping
        {
            private string _arguments;
            
            /// <summary>
            /// Optional. A string that contains optional arguments for the
            /// script processor specified by the
            /// SiteConfig.HandlerMappings.HandlerMapping.ScriptProcessor
            /// element.
            /// </summary>
            public string Arguments
            {
                get { return this._arguments; }
                set { this._arguments = value; }
            }
            
            private string _extension;
            
            /// <summary>
            /// Optional. A string that specifies the extension of the file
            /// type that the script processor will handle (for example,
            /// *.php).
            /// </summary>
            public string Extension
            {
                get { return this._extension; }
                set { this._extension = value; }
            }
            
            private string _scriptProcessor;
            
            /// <summary>
            /// Optional. The absolute path to the location of the executable
            /// file that will handle the files specified in the
            /// SiteConfig.HandlerMappings.HandlerMapping.Extension element.
            /// </summary>
            public string ScriptProcessor
            {
                get { return this._scriptProcessor; }
                set { this._scriptProcessor = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the HandlerMapping class.
            /// </summary>
            public HandlerMapping()
            {
            }
        }
    }
}
