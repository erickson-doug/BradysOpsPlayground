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

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Contains FQDN of the DNS record associated with the public IP address
    /// </summary>
    public partial class PublicIpAddressDnsSettings
    {
        private string _domainNameLabel;
        
        /// <summary>
        /// Optional. Gets or sets the Domain name label.The concatenation of
        /// the domain name label and the regionalized DNS zone make up the
        /// fully qualified domain name associated with the public IP address.
        /// If a domain name label is specified, an A DNS record is created
        /// for the public IP in the Microsoft Azure DNS system.
        /// </summary>
        public string DomainNameLabel
        {
            get { return this._domainNameLabel; }
            set { this._domainNameLabel = value; }
        }
        
        private string _fqdn;
        
        /// <summary>
        /// Optional. Gets the FQDN, Fully qualified domain name of the A DNS
        /// record associated with the public IP. This is the concatenation of
        /// the domainNameLabel and the regionalized DNS zone.
        /// </summary>
        public string Fqdn
        {
            get { return this._fqdn; }
            set { this._fqdn = value; }
        }
        
        private string _reverseFqdn;
        
        /// <summary>
        /// Optional. Gets or Sests the Reverse FQDN. A user-visible, fully
        /// qualified domain name that resolves to this public IP address. If
        /// the reverseFqdn is specified, then a PTR DNS record is created
        /// pointing from the IP address in the in-addr.arpa domain to the
        /// reverse FQDN.
        /// </summary>
        public string ReverseFqdn
        {
            get { return this._reverseFqdn; }
            set { this._reverseFqdn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PublicIpAddressDnsSettings class.
        /// </summary>
        public PublicIpAddressDnsSettings()
        {
        }
    }
}
