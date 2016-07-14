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

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Subscriptions.Csm.Models;

namespace Microsoft.Azure.Subscriptions.Csm
{
    /// <summary>
    /// Operations for managing subscriptions.
    /// </summary>
    public partial interface ISubscriptionOperations
    {
        /// <summary>
        /// Gets details about particular subscription.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of the subscription.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Subscription detailed information.
        /// </returns>
        Task<GetSubscriptionResult> GetAsync(string subscriptionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a list of the subscriptionIds.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Subscription list operation response.
        /// </returns>
        Task<SubscriptionListResult> ListAsync(CancellationToken cancellationToken);
    }
}
