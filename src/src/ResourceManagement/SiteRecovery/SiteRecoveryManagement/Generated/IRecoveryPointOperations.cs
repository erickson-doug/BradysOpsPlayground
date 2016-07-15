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
    /// Definition of recovery point operations for Site recovery extension.
    /// </summary>
    public partial interface IRecoveryPointOperations
    {
        /// <summary>
        /// Get a specific recovery point for a replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container unique name.
        /// </param>
        /// <param name='replicationProtectedItemName'>
        /// Replication protected item's name.
        /// </param>
        /// <param name='recoveryPointName'>
        /// Recovery point name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for recovery point object.
        /// </returns>
        Task<RecoveryPointResponse> GetAsync(string fabricName, string protectionContainerName, string replicationProtectedItemName, string recoveryPointName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get all recovery points for a replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container unique name.
        /// </param>
        /// <param name='replicationProtectedItemName'>
        /// Replication protected item's name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for a list of recovery points.
        /// </returns>
        Task<RecoveryPointListResponse> ListAsync(string fabricName, string protectionContainerName, string replicationProtectedItemName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
