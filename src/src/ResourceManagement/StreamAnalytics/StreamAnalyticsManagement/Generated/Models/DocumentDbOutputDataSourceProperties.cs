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

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of DocumentDB data source as output.
    /// </summary>
    public partial class DocumentDbOutputDataSourceProperties
    {
        private string _accountId;
        
        /// <summary>
        /// Optional. Gets or sets the account id of the DocumentDB.
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        
        private string _accountKey;
        
        /// <summary>
        /// Optional. Gets or sets the account key of the DocumentDB.
        /// </summary>
        public string AccountKey
        {
            get { return this._accountKey; }
            set { this._accountKey = value; }
        }
        
        private string _collectionNamePattern;
        
        /// <summary>
        /// Optional. Gets or sets the collection name pattern for the
        /// collections to be used of the DocumentDB.
        /// </summary>
        public string CollectionNamePattern
        {
            get { return this._collectionNamePattern; }
            set { this._collectionNamePattern = value; }
        }
        
        private string _database;
        
        /// <summary>
        /// Optional. Gets or sets the database name of the DocumentDB.
        /// </summary>
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }
        
        private string _documentId;
        
        /// <summary>
        /// Optional. Gets or sets the document id of the DocumentDB.
        /// </summary>
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }
        
        private string _partitionKey;
        
        /// <summary>
        /// Optional. Gets or sets the partition key of the DocumentDB.
        /// </summary>
        public string PartitionKey
        {
            get { return this._partitionKey; }
            set { this._partitionKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DocumentDbOutputDataSourceProperties class.
        /// </summary>
        public DocumentDbOutputDataSourceProperties()
        {
        }
    }
}
