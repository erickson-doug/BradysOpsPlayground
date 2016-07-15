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
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public static partial class ProtectableItemOperationsExtensions
    {
        /// <summary>
        /// Get the replication protectable object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IProtectableItemOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Required. Protection container unique name.
        /// </param>
        /// <param name='protectableItemName'>
        /// Required. Replication protected item unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the fabric object
        /// </returns>
        public static ProtectableItemResponse Get(this IProtectableItemOperations operations, string fabricName, string protectionContainerName, string protectableItemName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectableItemOperations)s).GetAsync(fabricName, protectionContainerName, protectableItemName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the replication protectable object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IProtectableItemOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Required. Protection container unique name.
        /// </param>
        /// <param name='protectableItemName'>
        /// Required. Replication protected item unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the fabric object
        /// </returns>
        public static Task<ProtectableItemResponse> GetAsync(this IProtectableItemOperations operations, string fabricName, string protectionContainerName, string protectableItemName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(fabricName, protectionContainerName, protectableItemName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Enumerate all replication protectable items in a container.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IProtectableItemOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Required. Protection container unique name.
        /// </param>
        /// <param name='typeOfEntities'>
        /// Optional. Type of entities to fetch. Protected to fetch protected
        /// only, Unprotected to fetch unprotected only, All to fetch both
        /// unprotected and protected.
        /// </param>
        /// <param name='skipToken'>
        /// Optional. Continuation Token.
        /// </param>
        /// <param name='take'>
        /// Optional. Maximum number of items to be fetched in a request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list replicated protected items.
        /// </returns>
        public static ProtectableItemListResponse List(this IProtectableItemOperations operations, string fabricName, string protectionContainerName, string typeOfEntities, string skipToken, string take, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectableItemOperations)s).ListAsync(fabricName, protectionContainerName, typeOfEntities, skipToken, take, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enumerate all replication protectable items in a container.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IProtectableItemOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Required. Protection container unique name.
        /// </param>
        /// <param name='typeOfEntities'>
        /// Optional. Type of entities to fetch. Protected to fetch protected
        /// only, Unprotected to fetch unprotected only, All to fetch both
        /// unprotected and protected.
        /// </param>
        /// <param name='skipToken'>
        /// Optional. Continuation Token.
        /// </param>
        /// <param name='take'>
        /// Optional. Maximum number of items to be fetched in a request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list replicated protected items.
        /// </returns>
        public static Task<ProtectableItemListResponse> ListAsync(this IProtectableItemOperations operations, string fabricName, string protectionContainerName, string typeOfEntities, string skipToken, string take, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(fabricName, protectionContainerName, typeOfEntities, skipToken, take, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Enumerate all replication protectable items in a container.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IProtectableItemOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next protected items page.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list replicated protected items.
        /// </returns>
        public static ProtectableItemListResponse ListNext(this IProtectableItemOperations operations, string nextLink, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectableItemOperations)s).ListNextAsync(nextLink, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enumerate all replication protectable items in a container.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IProtectableItemOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next protected items page.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list replicated protected items.
        /// </returns>
        public static Task<ProtectableItemListResponse> ListNextAsync(this IProtectableItemOperations operations, string nextLink, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListNextAsync(nextLink, customRequestHeaders, CancellationToken.None);
        }
    }
}
