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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// machine extensions in your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157206.aspx for
    /// more information)
    /// </summary>
    public partial interface IVirtualMachineExtensionOperations
    {
        /// <summary>
        /// The List Resource Extensions operation lists the resource
        /// extensions that are available to add to a Virtual Machine. In
        /// Azure, a process can run as a resource extension of a Virtual
        /// Machine. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as resource extensions to the Virtual
        /// Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495441.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        Task<VirtualMachineExtensionListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Resource Extension Versions operation lists the versions
        /// of a resource extension that are available to add to a Virtual
        /// Machine. In Azure, a process can run as a resource extension of a
        /// Virtual Machine. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as resource extensions to the Virtual
        /// Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495440.aspx
        /// for more information)
        /// </summary>
        /// <param name='publisherName'>
        /// The name of the publisher.
        /// </param>
        /// <param name='extensionName'>
        /// The name of the extension.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        Task<VirtualMachineExtensionListResponse> ListVersionsAsync(string publisherName, string extensionName, CancellationToken cancellationToken);
    }
}
