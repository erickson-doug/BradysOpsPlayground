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
using Microsoft.Azure.Management.Redis.Models;

namespace Microsoft.Azure.Management.Redis
{
    /// <summary>
    /// Operations for managing the redis cache.
    /// </summary>
    public partial interface IRedisOperations
    {
        /// <summary>
        /// Create a redis cache, or replace (overwrite/recreate, with
        /// potential downtime) an existing cache
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the redis cache.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the CreateOrUpdate redis operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of CreateOrUpdate redis operation.
        /// </returns>
        Task<RedisCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string name, RedisCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a redis cache. This operation takes a while to complete.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the redis cache.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string name, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a redis cache (resource description).
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the redis cache.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of GET redis operation.
        /// </returns>
        Task<RedisGetResponse> GetAsync(string resourceGroupName, string name, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets all redis caches in a resource group (if provided) otherwise
        /// all in subscription.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of list redis operation.
        /// </returns>
        Task<RedisListResponse> ListAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a redis cache's access keys. This operation requires write
        /// permission to the cache resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the redis cache.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of redis list keys operation.
        /// </returns>
        Task<RedisListKeysResponse> ListKeysAsync(string resourceGroupName, string name, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets all redis caches using next link.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of list redis operation.
        /// </returns>
        Task<RedisListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Regenerate redis cache's access keys. This operation requires write
        /// permission to the cache resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the redis cache.
        /// </param>
        /// <param name='parameters'>
        /// Specifies which key to reset.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> RegenerateKeyAsync(string resourceGroupName, string name, RedisRegenerateKeyParameters parameters, CancellationToken cancellationToken);
    }
}
