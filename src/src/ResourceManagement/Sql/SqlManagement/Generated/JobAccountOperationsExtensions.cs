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
    public static partial class JobAccountOperationsExtensions
    {
        /// <summary>
        /// Begins creating a new Azure SQL Job Account or updating an existing
        /// Azure SQL Job Account. To determine the status of the operation
        /// call GetJobAccountOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Job
        /// Account.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static JobAccountOperationResponse BeginCreateOrUpdate(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName, JobAccountCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, serverName, jobAccountName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begins creating a new Azure SQL Job Account or updating an existing
        /// Azure SQL Job Account. To determine the status of the operation
        /// call GetJobAccountOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Job
        /// Account.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static Task<JobAccountOperationResponse> BeginCreateOrUpdateAsync(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName, JobAccountCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, jobAccountName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Begins deleting the Azure SQL Job Account with the given name. To
        /// determine the status of the operation call
        /// GetJobAccountOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be deleted.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static JobAccountOperationResponse BeginDelete(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).BeginDeleteAsync(resourceGroupName, serverName, jobAccountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begins deleting the Azure SQL Job Account with the given name. To
        /// determine the status of the operation call
        /// GetJobAccountOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be deleted.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static Task<JobAccountOperationResponse> BeginDeleteAsync(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName)
        {
            return operations.BeginDeleteAsync(resourceGroupName, serverName, jobAccountName, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new Azure SQL Job Account or updates an existing Azure
        /// SQL Job Account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Job Database Server that the
        /// Job Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Job
        /// Account.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static JobAccountOperationResponse CreateOrUpdate(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName, JobAccountCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).CreateOrUpdateAsync(resourceGroupName, serverName, jobAccountName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new Azure SQL Job Account or updates an existing Azure
        /// SQL Job Account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Job Database Server that the
        /// Job Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Job
        /// Account.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static Task<JobAccountOperationResponse> CreateOrUpdateAsync(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName, JobAccountCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, serverName, jobAccountName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new Azure SQL Job Account or updates an existing Azure
        /// SQL Job Account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Job Database Server that the
        /// Job Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be created or
        /// updated.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static JobAccountOperationResponse Delete(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).DeleteAsync(resourceGroupName, serverName, jobAccountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new Azure SQL Job Account or updates an existing Azure
        /// SQL Job Account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Job Database Server that the
        /// Job Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be created or
        /// updated.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static Task<JobAccountOperationResponse> DeleteAsync(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName)
        {
            return operations.DeleteAsync(resourceGroupName, serverName, jobAccountName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Job Account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Job Account request.
        /// </returns>
        public static JobAccountGetResponse Get(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).GetAsync(resourceGroupName, serverName, jobAccountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Job Account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Account is hosted in.
        /// </param>
        /// <param name='jobAccountName'>
        /// Required. The name of the Azure SQL Job Account to be retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Job Account request.
        /// </returns>
        public static Task<JobAccountGetResponse> GetAsync(this IJobAccountOperations operations, string resourceGroupName, string serverName, string jobAccountName)
        {
            return operations.GetAsync(resourceGroupName, serverName, jobAccountName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Job Account create or update
        /// operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static JobAccountOperationResponse GetJobAccountOperationStatus(this IJobAccountOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).GetJobAccountOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Job Account create or update
        /// operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Job Account operations.
        /// </returns>
        public static Task<JobAccountOperationResponse> GetJobAccountOperationStatusAsync(this IJobAccountOperations operations, string operationStatusLink)
        {
            return operations.GetJobAccountOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about Azure SQL Job Accounts.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Accounts are hosted in.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Job Accounts request.
        /// </returns>
        public static JobAccountListResponse List(this IJobAccountOperations operations, string resourceGroupName, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobAccountOperations)s).ListAsync(resourceGroupName, serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about Azure SQL Job Accounts.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IJobAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that the Job
        /// Accounts are hosted in.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Job Accounts request.
        /// </returns>
        public static Task<JobAccountListResponse> ListAsync(this IJobAccountOperations operations, string resourceGroupName, string serverName)
        {
            return operations.ListAsync(resourceGroupName, serverName, CancellationToken.None);
        }
    }
}
