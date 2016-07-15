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
    public static partial class PolicyOperationsExtensions
    {
        /// <summary>
        /// Creates a profile
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create profile
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginCreating(this IPolicyOperations operations, string policyName, CreatePolicyInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).BeginCreatingAsync(policyName, input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a profile
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create profile
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginCreatingAsync(this IPolicyOperations operations, string policyName, CreatePolicyInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginCreatingAsync(policyName, input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a Policy
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='name'>
        /// Required. Policy name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginDeleting(this IPolicyOperations operations, string name, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).BeginDeletingAsync(name, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a Policy
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='name'>
        /// Required. Policy name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginDeletingAsync(this IPolicyOperations operations, string name, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginDeletingAsync(name, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Update Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='input'>
        /// Required. input.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginUpdating(this IPolicyOperations operations, UpdatePolicyInput input, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).BeginUpdatingAsync(input, policyName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='input'>
        /// Required. input.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginUpdatingAsync(this IPolicyOperations operations, UpdatePolicyInput input, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginUpdatingAsync(input, policyName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a profile
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create profile
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Create(this IPolicyOperations operations, string policyName, CreatePolicyInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).CreateAsync(policyName, input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a profile
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create profile
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> CreateAsync(this IPolicyOperations operations, string policyName, CreatePolicyInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CreateAsync(policyName, input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a Policy
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='name'>
        /// Required. Policy name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Delete(this IPolicyOperations operations, string name, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).DeleteAsync(name, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a Policy
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='name'>
        /// Required. Policy name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> DeleteAsync(this IPolicyOperations operations, string name, CustomRequestHeaders customRequestHeaders)
        {
            return operations.DeleteAsync(name, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the protected Profile by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Policy object.
        /// </returns>
        public static PolicyResponse Get(this IPolicyOperations operations, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).GetAsync(policyName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the protected Profile by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Policy object.
        /// </returns>
        public static Task<PolicyResponse> GetAsync(this IPolicyOperations operations, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(policyName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static CreatePolicyOperationResponse GetCreateStatus(this IPolicyOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).GetCreateStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<CreatePolicyOperationResponse> GetCreateStatusAsync(this IPolicyOperations operations, string operationStatusLink)
        {
            return operations.GetCreateStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static DeletePolicyOperationResponse GetDeleteStatus(this IPolicyOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).GetDeleteStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<DeletePolicyOperationResponse> GetDeleteStatusAsync(this IPolicyOperations operations, string operationStatusLink)
        {
            return operations.GetDeleteStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static UpdatePolicyOperationResponse GetUpdateStatus(this IPolicyOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).GetUpdateStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<UpdatePolicyOperationResponse> GetUpdateStatusAsync(this IPolicyOperations operations, string operationStatusLink)
        {
            return operations.GetUpdateStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all ProtectionContainers for the given server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list policies operation.
        /// </returns>
        public static PolicyListResponse List(this IPolicyOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).ListAsync(customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all ProtectionContainers for the given server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list policies operation.
        /// </returns>
        public static Task<PolicyListResponse> ListAsync(this IPolicyOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Update Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='input'>
        /// Required. input.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Update(this IPolicyOperations operations, UpdatePolicyInput input, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPolicyOperations)s).UpdateAsync(input, policyName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IPolicyOperations.
        /// </param>
        /// <param name='input'>
        /// Required. input.
        /// </param>
        /// <param name='policyName'>
        /// Required. Policy name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> UpdateAsync(this IPolicyOperations operations, UpdatePolicyInput input, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UpdateAsync(input, policyName, customRequestHeaders, CancellationToken.None);
        }
    }
}
