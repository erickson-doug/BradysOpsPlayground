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

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Server Administrator.
    /// </summary>
    public partial class ServerAdministratorProperties
    {
        private string _administratorType;
        
        /// <summary>
        /// Optional. Gets the type of Azure SQL Server Administrator.
        /// </summary>
        public string AdministratorType
        {
            get { return this._administratorType; }
            set { this._administratorType = value; }
        }
        
        private string _login;
        
        /// <summary>
        /// Optional. Gets the Azure SQL Server Administrator Login Value.
        /// </summary>
        public string Login
        {
            get { return this._login; }
            set { this._login = value; }
        }
        
        private Guid _sid;
        
        /// <summary>
        /// Optional. Gets the Azure SQL Server Administrator Sid.
        /// </summary>
        public Guid Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }
        
        private Guid _tenantId;
        
        /// <summary>
        /// Required. Gets the Azure SQL Server Active Directory Administrator
        /// tenant id.
        /// </summary>
        public Guid TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServerAdministratorProperties
        /// class.
        /// </summary>
        public ServerAdministratorProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ServerAdministratorProperties
        /// class with required arguments.
        /// </summary>
        public ServerAdministratorProperties(Guid tenantId)
            : this()
        {
            this.TenantId = tenantId;
        }
    }
}
