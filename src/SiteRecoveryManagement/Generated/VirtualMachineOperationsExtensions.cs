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
using Microsoft.WindowsAzure.Management.SiteRecovery;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure
{
    public static partial class VirtualMachineOperationsExtensions
    {
        /// <summary>
        /// Get the VM object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.IVirtualMachineOperations.
        /// </param>
        /// <param name='protectionContainerId'>
        /// Required. Parent Protection Container ID.
        /// </param>
        /// <param name='virtualMachineId'>
        /// Required. VM ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Vm object.
        /// </returns>
        public static VirtualMachineResponse Get(this IVirtualMachineOperations operations, string protectionContainerId, string virtualMachineId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOperations)s).GetAsync(protectionContainerId, virtualMachineId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the VM object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.IVirtualMachineOperations.
        /// </param>
        /// <param name='protectionContainerId'>
        /// Required. Parent Protection Container ID.
        /// </param>
        /// <param name='virtualMachineId'>
        /// Required. VM ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Vm object.
        /// </returns>
        public static Task<VirtualMachineResponse> GetAsync(this IVirtualMachineOperations operations, string protectionContainerId, string virtualMachineId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(protectionContainerId, virtualMachineId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all Vms.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.IVirtualMachineOperations.
        /// </param>
        /// <param name='protectionContainerId'>
        /// Required. Parent Protection Container ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list Vm operation.
        /// </returns>
        public static VirtualMachineListResponse List(this IVirtualMachineOperations operations, string protectionContainerId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOperations)s).ListAsync(protectionContainerId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all Vms.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.IVirtualMachineOperations.
        /// </param>
        /// <param name='protectionContainerId'>
        /// Required. Parent Protection Container ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list Vm operation.
        /// </returns>
        public static Task<VirtualMachineListResponse> ListAsync(this IVirtualMachineOperations operations, string protectionContainerId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(protectionContainerId, customRequestHeaders, CancellationToken.None);
        }
    }
}
