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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Properties of a configure alert request.
    /// </summary>
    public partial class ConfigureAlertSettingsRequestProperties
    {
        private IList<string> _customEmailAddresses;
        
        /// <summary>
        /// Optional. The custom email address for sending emails.
        /// </summary>
        public IList<string> CustomEmailAddresses
        {
            get { return this._customEmailAddresses; }
            set { this._customEmailAddresses = value; }
        }
        
        private string _locale;
        
        /// <summary>
        /// Optional. The locale for the email notification.
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }
        
        private string _sendToOwners;
        
        /// <summary>
        /// Optional. A value indicating whether to send email to subscription
        /// owners.
        /// </summary>
        public string SendToOwners
        {
            get { return this._sendToOwners; }
            set { this._sendToOwners = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ConfigureAlertSettingsRequestProperties class.
        /// </summary>
        public ConfigureAlertSettingsRequestProperties()
        {
            this.CustomEmailAddresses = new LazyList<string>();
        }
    }
}
