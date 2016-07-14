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
    /// Restore request to either a new or an existing site.
    /// </summary>
    public partial class RestoreRequest
    {
        private bool _adjustConnectionStrings;
        
        /// <summary>
        /// Optional. If the restore operation also restores a database along
        /// with the website and the database is on a different server than
        /// when the original site h
        /// </summary>
        public bool AdjustConnectionStrings
        {
            get { return this._adjustConnectionStrings; }
            set { this._adjustConnectionStrings = value; }
        }
        
        private string _blobName;
        
        /// <summary>
        /// Optional. The blob name where the backup is stored. E.g.
        /// mysite1_20140203.zip
        /// </summary>
        public string BlobName
        {
            get { return this._blobName; }
            set { this._blobName = value; }
        }
        
        private IList<DatabaseBackupSetting> _databases;
        
        /// <summary>
        /// Optional. Database settings for backup.
        /// </summary>
        public IList<DatabaseBackupSetting> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }
        
        private bool _ignoreConflictingHostNames;
        
        /// <summary>
        /// Optional. When restoring a site, custom domains might conflict with
        /// other site in the same datacenter. If this value is true, such
        /// hostnames will be ignored during restore. If this is false, the
        /// restore operation will fail on such conflict.
        /// </summary>
        public bool IgnoreConflictingHostNames
        {
            get { return this._ignoreConflictingHostNames; }
            set { this._ignoreConflictingHostNames = value; }
        }
        
        private bool _overwrite;
        
        /// <summary>
        /// Optional. True if the restore operation will be used for overwrite
        /// an existing site; false otherwise.
        /// </summary>
        public bool Overwrite
        {
            get { return this._overwrite; }
            set { this._overwrite = value; }
        }
        
        private string _storageAccountUrl;
        
        /// <summary>
        /// Optional. SAS URL for a container in a storage account. E.g.
        /// https://NAME.blob.core.windows.net/CONTAINERNAME/?sv=2012-02-12&st=2013-12-05T19%3A30%3A45Z&se=2017-12-04T19%3A30%3A45Z&sr=c&sp=rwdl&sig=abcdefABCDEFabcdef0123456789
        /// </summary>
        public string StorageAccountUrl
        {
            get { return this._storageAccountUrl; }
            set { this._storageAccountUrl = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RestoreRequest class.
        /// </summary>
        public RestoreRequest()
        {
            this.Databases = new LazyList<DatabaseBackupSetting>();
        }
    }
}
