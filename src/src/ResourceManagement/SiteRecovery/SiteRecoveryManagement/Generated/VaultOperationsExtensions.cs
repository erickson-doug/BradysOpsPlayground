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
using Microsoft.Azure.Management.SiteRecoveryVault;
using Microsoft.Azure.Management.SiteRecoveryVault.Models;

namespace Microsoft.Azure.Management.SiteRecoveryVault
{
    public static partial class VaultOperationsExtensions
    {
        /// <summary>
        /// Creates a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to create.
        /// </param>
        /// <param name='vaultCreationInput'>
        /// Required. Vault object to be created
        /// </param>
        /// <returns>
        /// The response model for the Vm group object.
        /// </returns>
        public static VaultCreateResponse BeginCreating(this IVaultOperations operations, string resourceGroupName, string vaultName, VaultCreateArgs vaultCreationInput)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).BeginCreatingAsync(resourceGroupName, vaultName, vaultCreationInput);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to create.
        /// </param>
        /// <param name='vaultCreationInput'>
        /// Required. Vault object to be created
        /// </param>
        /// <returns>
        /// The response model for the Vm group object.
        /// </returns>
        public static Task<VaultCreateResponse> BeginCreatingAsync(this IVaultOperations operations, string resourceGroupName, string vaultName, VaultCreateArgs vaultCreationInput)
        {
            return operations.BeginCreatingAsync(resourceGroupName, vaultName, vaultCreationInput, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (Resource Group) cloud service containing
        /// the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to delete.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static RecoveryServicesOperationStatusResponse BeginDeleting(this IVaultOperations operations, string resourceGroupName, string vaultName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).BeginDeletingAsync(resourceGroupName, vaultName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (Resource Group) cloud service containing
        /// the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to delete.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<RecoveryServicesOperationStatusResponse> BeginDeletingAsync(this IVaultOperations operations, string resourceGroupName, string vaultName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, vaultName, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group) cloud service containing
        /// the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Optional. The name of the vault to create.
        /// </param>
        /// <param name='vaultCreationInput'>
        /// Required. Vault object to be created
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static RecoveryServicesOperationStatusResponse Create(this IVaultOperations operations, string resourceGroupName, string vaultName, VaultCreateArgs vaultCreationInput)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).CreateAsync(resourceGroupName, vaultName, vaultCreationInput);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group) cloud service containing
        /// the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Optional. The name of the vault to create.
        /// </param>
        /// <param name='vaultCreationInput'>
        /// Required. Vault object to be created
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<RecoveryServicesOperationStatusResponse> CreateAsync(this IVaultOperations operations, string resourceGroupName, string vaultName, VaultCreateArgs vaultCreationInput)
        {
            return operations.CreateAsync(resourceGroupName, vaultName, vaultCreationInput, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (Resource Group) cloud service containing
        /// the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to delete.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static RecoveryServicesOperationStatusResponse Delete(this IVaultOperations operations, string resourceGroupName, string vaultName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).DeleteAsync(resourceGroupName, vaultName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (Resource Group) cloud service containing
        /// the job collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to delete.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<RecoveryServicesOperationStatusResponse> DeleteAsync(this IVaultOperations operations, string resourceGroupName, string vaultName)
        {
            return operations.DeleteAsync(resourceGroupName, vaultName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the Vaults.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the vault collection.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for Vault.
        /// </returns>
        public static VaultListResponse Get(this IVaultOperations operations, string resourceGroupName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).GetAsync(resourceGroupName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the Vaults.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecoveryVault.IVaultOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the vault collection.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for Vault.
        /// </returns>
        public static Task<VaultListResponse> GetAsync(this IVaultOperations operations, string resourceGroupName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(resourceGroupName, customRequestHeaders, CancellationToken.None);
        }
    }
}
