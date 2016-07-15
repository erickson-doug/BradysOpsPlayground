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

namespace Microsoft.Azure.Management.Dns.Models
{
    /// <summary>
    /// An SOA record.
    /// </summary>
    public partial class SoaRecord
    {
        private string _email;
        
        /// <summary>
        /// Required. Gets or sets the email for this record.
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        
        private uint _expireTime;
        
        /// <summary>
        /// Required. Gets or sets the expire time for this record.
        /// </summary>
        public uint ExpireTime
        {
            get { return this._expireTime; }
            set { this._expireTime = value; }
        }
        
        private string _host;
        
        /// <summary>
        /// Optional. Gets or sets the domain name of the authoritative name
        /// server, without a temrinating dot.
        /// </summary>
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }
        
        private uint _minimumTtl;
        
        /// <summary>
        /// Required. Gets or sets the minimum TTL value for this record.
        /// </summary>
        public uint MinimumTtl
        {
            get { return this._minimumTtl; }
            set { this._minimumTtl = value; }
        }
        
        private uint _refreshTime;
        
        /// <summary>
        /// Required. Gets or sets the refresh value for this record.
        /// </summary>
        public uint RefreshTime
        {
            get { return this._refreshTime; }
            set { this._refreshTime = value; }
        }
        
        private uint _retryTime;
        
        /// <summary>
        /// Required. Gets or sets the retry time for this record.
        /// </summary>
        public uint RetryTime
        {
            get { return this._retryTime; }
            set { this._retryTime = value; }
        }
        
        private uint _serialNumber;
        
        /// <summary>
        /// Required. Gets or sets the serial number for this record.
        /// </summary>
        public uint SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SoaRecord class.
        /// </summary>
        public SoaRecord()
        {
        }
    }
}
