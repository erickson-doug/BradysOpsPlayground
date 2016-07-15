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
    public static partial class VirtualNetworkOperationsExtensions
    {
        /// <summary>
        /// The Put VirtualNetwork operation creates/updates a virtual network
        /// in the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Virtual Network
        /// operation
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworks API service calls.
        /// </returns>
        public static VirtualNetworkPutResponse BeginCreateOrUpdating(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).BeginCreateOrUpdatingAsync(resourceGroupName, virtualNetworkName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put VirtualNetwork operation creates/updates a virtual network
        /// in the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Virtual Network
        /// operation
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworks API service calls.
        /// </returns>
        public static Task<VirtualNetworkPutResponse> BeginCreateOrUpdatingAsync(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
        {
            return operations.BeginCreateOrUpdatingAsync(resourceGroupName, virtualNetworkName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete VirtualNetwork operation deletes the specifed virtual
        /// network
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static UpdateOperationResponse BeginDeleting(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).BeginDeletingAsync(resourceGroupName, virtualNetworkName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete VirtualNetwork operation deletes the specifed virtual
        /// network
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static Task<UpdateOperationResponse> BeginDeletingAsync(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, virtualNetworkName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Put VirtualNetwork operation creates/updates a virtual
        /// networkin the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Virtual Network
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
        public static AzureAsyncOperationResponse CreateOrUpdate(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put VirtualNetwork operation creates/updates a virtual
        /// networkin the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Virtual Network
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
        public static Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete VirtualNetwork operation deletes the specifed virtual
        /// network
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).DeleteAsync(resourceGroupName, virtualNetworkName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete VirtualNetwork operation deletes the specifed virtual
        /// network
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName)
        {
            return operations.DeleteAsync(resourceGroupName, virtualNetworkName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get VirtualNetwork operation retrieves information about the
        /// specified virtual network.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <returns>
        /// Response for GetVirtualNetworks API service calls.
        /// </returns>
        public static VirtualNetworkGetResponse Get(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).GetAsync(resourceGroupName, virtualNetworkName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get VirtualNetwork operation retrieves information about the
        /// specified virtual network.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// Required. The name of the virtual network.
        /// </param>
        /// <returns>
        /// Response for GetVirtualNetworks API service calls.
        /// </returns>
        public static Task<VirtualNetworkGetResponse> GetAsync(this IVirtualNetworkOperations operations, string resourceGroupName, string virtualNetworkName)
        {
            return operations.GetAsync(resourceGroupName, virtualNetworkName, CancellationToken.None);
        }
        
        /// <summary>
        /// The list VirtualNetwork returns all Virtual Networks in a resource
        /// group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListVirtualNetworks Api servive call
        /// </returns>
        public static VirtualNetworkListResponse List(this IVirtualNetworkOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The list VirtualNetwork returns all Virtual Networks in a resource
        /// group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListVirtualNetworks Api servive call
        /// </returns>
        public static Task<VirtualNetworkListResponse> ListAsync(this IVirtualNetworkOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The list VirtualNetwork returns all Virtual Networks in a
        /// subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <returns>
        /// Response for ListVirtualNetworks Api servive call
        /// </returns>
        public static VirtualNetworkListResponse ListAll(this IVirtualNetworkOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkOperations)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The list VirtualNetwork returns all Virtual Networks in a
        /// subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkOperations.
        /// </param>
        /// <returns>
        /// Response for ListVirtualNetworks Api servive call
        /// </returns>
        public static Task<VirtualNetworkListResponse> ListAllAsync(this IVirtualNetworkOperations operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }
    }
}
