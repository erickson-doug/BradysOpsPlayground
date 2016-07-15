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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of storage classification operations for the Site Recovery
    /// extension.
    /// </summary>
    public partial interface IStorageClassificationOperations
    {
        /// <summary>
        /// Gets the replication storage object by name.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the storage object
        /// </returns>
        Task<StorageClassificationResponse> GetAsync(string fabricName, string storageClassificationName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage objects under a fabric.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list storage classification operation.
        /// </returns>
        Task<StorageClassificationListResponse> ListAsync(string fabricName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage classifications under a vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list storage classification operation.
        /// </returns>
        Task<StorageClassificationListResponse> ListAllAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage classification objects under a vault.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next protected items page.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list storage classification operation.
        /// </returns>
        Task<StorageClassificationListResponse> ListNextAsync(string nextLink, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
