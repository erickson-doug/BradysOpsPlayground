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
    /// Definition of storage mapping operations for the Site Recovery
    /// extension.
    /// </summary>
    public partial interface IStorageClassificationMappingOperations
    {
        /// <summary>
        /// Pairs storage to a given storage.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage mapping name.
        /// </param>
        /// <param name='input'>
        /// Create mapping input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginPairStorageClassificationAsync(string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageClassificationMappingInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unpairs storage to a given storage.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage mapping name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginUnpairStorageClassificationAsync(string fabricName, string storageClassificationName, string storageClassificationMappingName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage mapping object by name.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage unique name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage mapping unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the storage mapping object
        /// </returns>
        Task<StorageClassificationMappingResponse> GetAsync(string fabricName, string storageClassificationName, string storageClassificationMappingName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Service response for operation which change status of mapping for
        /// storage.
        /// </returns>
        Task<StorageClassificationMappingOperationResponse> GetPairStorageClassificationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> GetUnpairStorageClassificationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage mapping objects under a storage.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list storage mapping operation.
        /// </returns>
        Task<StorageClassificationMappingListResponse> ListAsync(string fabricName, string storageClassificationName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage mapping objects under a vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list storage mapping operation.
        /// </returns>
        Task<StorageClassificationMappingListResponse> ListAllAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the replication storage mapping objects under a vault.
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
        /// The response model for the list storage mapping operation.
        /// </returns>
        Task<StorageClassificationMappingListResponse> ListNextAsync(string nextLink, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Pairs storage to a given storage.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classsification name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage classification mapping name.
        /// </param>
        /// <param name='input'>
        /// Create mapping input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> PairStorageClassificationAsync(string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageClassificationMappingInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes storage classification pairing.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Storage mapping name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> UnpairStorageClassificationAsync(string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
