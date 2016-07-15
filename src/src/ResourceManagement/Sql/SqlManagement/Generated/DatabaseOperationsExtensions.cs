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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class DatabaseOperationsExtensions
    {
        /// <summary>
        /// Begins creating a new Azure SQL Database or updating an existing
        /// Azure SQL Database. To determine the status of the operation call
        /// GetDatabaseOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be operated on
        /// (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a
        /// database.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse BeginCreateOrUpdate(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begins creating a new Azure SQL Database or updating an existing
        /// Azure SQL Database. To determine the status of the operation call
        /// GetDatabaseOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be operated on
        /// (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a
        /// database.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> BeginCreateOrUpdateAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new Azure SQL Database or updates an existing Azure SQL
        /// Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be operated on
        /// (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a
        /// database.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse CreateOrUpdate(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new Azure SQL Database or updates an existing Azure SQL
        /// Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be operated on
        /// (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a
        /// database.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> CreateOrUpdateAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the Azure SQL Database with the given name.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// Azure SQL Database Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).DeleteAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the Azure SQL Database with the given name.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// Azure SQL Database Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.DeleteAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database request.
        /// </returns>
        public static DatabaseGetResponse Get(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).GetAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database request.
        /// </returns>
        public static Task<DatabaseGetResponse> GetAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.GetAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseId'>
        /// Required. The Id of the Azure SQL Database to be retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database request.
        /// </returns>
        public static DatabaseListResponse GetById(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).GetByIdAsync(resourceGroupName, serverName, databaseId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseId'>
        /// Required. The Id of the Azure SQL Database to be retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database request.
        /// </returns>
        public static Task<DatabaseListResponse> GetByIdAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseId)
        {
            return operations.GetByIdAsync(resourceGroupName, serverName, databaseId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Database create or update operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse GetDatabaseOperationStatus(this IDatabaseOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).GetDatabaseOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Database create or update operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> GetDatabaseOperationStatusAsync(this IDatabaseOperations operations, string operationStatusLink)
        {
            return operations.GetDatabaseOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <param name='expand'>
        /// Required. The comma separated list of child objects that we want to
        /// expand on in response.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database request.
        /// </returns>
        public static DatabaseGetResponse GetExpanded(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName, string expand)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).GetExpandedAsync(resourceGroupName, serverName, databaseName, expand);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to be retrieved.
        /// </param>
        /// <param name='expand'>
        /// Required. The comma separated list of child objects that we want to
        /// expand on in response.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database request.
        /// </returns>
        public static Task<DatabaseGetResponse> GetExpandedAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName, string expand)
        {
            return operations.GetExpandedAsync(resourceGroupName, serverName, databaseName, expand, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about Azure SQL Databases.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// Azure SQL Databases are hosted.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database request.
        /// </returns>
        public static DatabaseListResponse List(this IDatabaseOperations operations, string resourceGroupName, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).ListAsync(resourceGroupName, serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about Azure SQL Databases.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// Azure SQL Databases are hosted.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database request.
        /// </returns>
        public static Task<DatabaseListResponse> ListAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName)
        {
            return operations.ListAsync(resourceGroupName, serverName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about Azure SQL Databases.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// Azure SQL Databases are hosted.
        /// </param>
        /// <param name='expand'>
        /// Required. The comma separated list of child objects that we want to
        /// expand on in response.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database request.
        /// </returns>
        public static DatabaseListResponse ListExpanded(this IDatabaseOperations operations, string resourceGroupName, string serverName, string expand)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).ListExpandedAsync(resourceGroupName, serverName, expand);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about Azure SQL Databases.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// Azure SQL Databases are hosted.
        /// </param>
        /// <param name='expand'>
        /// Required. The comma separated list of child objects that we want to
        /// expand on in response.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database request.
        /// </returns>
        public static Task<DatabaseListResponse> ListExpandedAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string expand)
        {
            return operations.ListExpandedAsync(resourceGroupName, serverName, expand, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about Azure SQL Database usages.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// Azure SQL Databases are hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database metrics
        /// request.
        /// </returns>
        public static DatabaseMetricListResponse ListUsages(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseOperations)s).ListUsagesAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about Azure SQL Database usages.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.IDatabaseOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server in which the
        /// Azure SQL Databases are hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database metrics
        /// request.
        /// </returns>
        public static Task<DatabaseMetricListResponse> ListUsagesAsync(this IDatabaseOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.ListUsagesAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
    }
}
