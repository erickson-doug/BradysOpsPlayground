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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for managing recommended indexes on Azure
    /// SQL Databases. Contains operations to retrieve recommended index and
    /// update state.
    /// </summary>
    public partial interface IRecommendedIndexOperations
    {
        /// <summary>
        /// Returns details on recommended index.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the Azure SQL database schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the Azure SQL database table.
        /// </param>
        /// <param name='indexName'>
        /// The name of the Azure SQL database recommended index.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a get recommended index request.
        /// </returns>
        Task<RecommendedIndexGetResponse> GetAsync(string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string indexName, CancellationToken cancellationToken);
        
        /// <summary>
        /// We execute or cancel index operations by updating index state.
        /// Allowed state transitions are :Active          -> Pending
        /// - Start index creation processPending         -> Active
        /// - Cancel index creationActive/Pending  -> Ignored
        /// - Ignore index recommendation so it will no longer show
        /// in active recommendationsIgnored         -> Active           -
        /// Restore index recommendationSuccess         -> Pending Revert   -
        /// Revert index that has been createdPending Revert  -> Revert
        /// Canceled  - Cancel index revert operation
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Database
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the Azure SQL Database schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the Azure SQL Database table.
        /// </param>
        /// <param name='indexName'>
        /// The name of the Azure SQL Database recommended index.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for updating index state.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a get recommended index request.
        /// </returns>
        Task<RecommendedIndexUpdateResponse> UpdateAsync(string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string indexName, RecommendedIndexUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
