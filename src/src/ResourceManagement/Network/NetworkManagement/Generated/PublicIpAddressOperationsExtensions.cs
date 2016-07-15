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
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Windows Azure Network management API provides a RESTful set of web
    /// services that interact with Windows Azure Networks service to manage
    /// your network resrources. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Networks
    /// service.
    /// </summary>
    public static partial class PublicIpAddressOperationsExtensions
    {
        /// <summary>
        /// The Put PublicIPAddress operation creates/updates a stable/dynamic
        /// PublicIP address
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the publicIpAddress.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update PublicIPAddress
        /// operation
        /// </param>
        /// <returns>
        /// Response for PutPublicIpAddress Api servive call
        /// </returns>
        public static PublicIpAddressPutResponse BeginCreateOrUpdating(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName, PublicIpAddress parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).BeginCreateOrUpdatingAsync(resourceGroupName, publicIpAddressName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put PublicIPAddress operation creates/updates a stable/dynamic
        /// PublicIP address
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the publicIpAddress.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update PublicIPAddress
        /// operation
        /// </param>
        /// <returns>
        /// Response for PutPublicIpAddress Api servive call
        /// </returns>
        public static Task<PublicIpAddressPutResponse> BeginCreateOrUpdatingAsync(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName, PublicIpAddress parameters)
        {
            return operations.BeginCreateOrUpdatingAsync(resourceGroupName, publicIpAddressName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The delete publicIpAddress operation deletes the specified
        /// publicIpAddress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the subnet.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static UpdateOperationResponse BeginDeleting(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).BeginDeletingAsync(resourceGroupName, publicIpAddressName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The delete publicIpAddress operation deletes the specified
        /// publicIpAddress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the subnet.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static Task<UpdateOperationResponse> BeginDeletingAsync(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, publicIpAddressName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Put PublicIPAddress operation creates/updates a stable/dynamic
        /// PublicIP address
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the publicIpAddress.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create PublicIPAddress
        /// operation
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static AzureAsyncOperationResponse CreateOrUpdate(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName, PublicIpAddress parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).CreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put PublicIPAddress operation creates/updates a stable/dynamic
        /// PublicIP address
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the publicIpAddress.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create PublicIPAddress
        /// operation
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName, PublicIpAddress parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Role operation retrieves information about the specified
        /// virtual machine.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the subnet.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).DeleteAsync(resourceGroupName, publicIpAddressName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Role operation retrieves information about the specified
        /// virtual machine.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the subnet.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName)
        {
            return operations.DeleteAsync(resourceGroupName, publicIpAddressName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get publicIpAddress operation retreives information about the
        /// specified pubicIpAddress
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the subnet.
        /// </param>
        /// <returns>
        /// Response for GetPublicIpAddress Api servive call
        /// </returns>
        public static PublicIpAddressGetResponse Get(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).GetAsync(resourceGroupName, publicIpAddressName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get publicIpAddress operation retreives information about the
        /// specified pubicIpAddress
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// Required. The name of the subnet.
        /// </param>
        /// <returns>
        /// Response for GetPublicIpAddress Api servive call
        /// </returns>
        public static Task<PublicIpAddressGetResponse> GetAsync(this IPublicIpAddressOperations operations, string resourceGroupName, string publicIpAddressName)
        {
            return operations.GetAsync(resourceGroupName, publicIpAddressName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List publicIpAddress opertion retrieves all the
        /// publicIpAddresses in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListPublicIpAddresses Api service call
        /// </returns>
        public static PublicIpAddressListResponse List(this IPublicIpAddressOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List publicIpAddress opertion retrieves all the
        /// publicIpAddresses in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListPublicIpAddresses Api service call
        /// </returns>
        public static Task<PublicIpAddressListResponse> ListAsync(this IPublicIpAddressOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List publicIpAddress opertion retrieves all the
        /// publicIpAddresses in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <returns>
        /// Response for ListPublicIpAddresses Api service call
        /// </returns>
        public static PublicIpAddressListResponse ListAll(this IPublicIpAddressOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicIpAddressOperations)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List publicIpAddress opertion retrieves all the
        /// publicIpAddresses in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IPublicIpAddressOperations.
        /// </param>
        /// <returns>
        /// Response for ListPublicIpAddresses Api service call
        /// </returns>
        public static Task<PublicIpAddressListResponse> ListAllAsync(this IPublicIpAddressOperations operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }
    }
}
