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
    public static partial class NetworkOperationsExtensions
    {
        /// <summary>
        /// Gets a VM network.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='networkName'>
        /// Required. Network name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Network object.
        /// </returns>
        public static NetworkResponse Get(this INetworkOperations operations, string fabricName, string networkName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).GetAsync(fabricName, networkName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a VM network.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='networkName'>
        /// Required. Network name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Network object.
        /// </returns>
        public static Task<NetworkResponse> GetAsync(this INetworkOperations operations, string fabricName, string networkName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(fabricName, networkName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get list of Networks.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list of Networks.
        /// </returns>
        public static NetworksListResponse GetAll(this INetworkOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).GetAllAsync(customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get list of Networks.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list of Networks.
        /// </returns>
        public static Task<NetworksListResponse> GetAllAsync(this INetworkOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAllAsync(customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get list of Networks.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list of Networks.
        /// </returns>
        public static NetworksListResponse List(this INetworkOperations operations, string fabricName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).ListAsync(fabricName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get list of Networks.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list of Networks.
        /// </returns>
        public static Task<NetworksListResponse> ListAsync(this INetworkOperations operations, string fabricName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(fabricName, customRequestHeaders, CancellationToken.None);
        }
    }
}
