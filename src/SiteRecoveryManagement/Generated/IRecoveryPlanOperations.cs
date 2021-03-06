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
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of recoveryplan operations for the Site Recovery extension.
    /// </summary>
    public partial interface IRecoveryPlanOperations
    {
        /// <summary>
        /// Commit the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> CommitAsync(string recoveryPlanId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create the recovery plan.
        /// </summary>
        /// <param name='parameters'>
        /// Create recovery plan input parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> CreateRecoveryPlanAsync(RecoveryPlanXmlData parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Remove a Recovery Plan from the current Azure Site Recovery Vault.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> DeleteAsync(string recoveryPlanId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the recovery plan by the ID.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the recoveryplan object.
        /// </returns>
        Task<RecoveryPlanResponse> GetAsync(string recoveryPlanId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the recovery plan xml by the ID.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The xml output for the recoveryplan object.
        /// </returns>
        Task<RecoveryPlanXmlOuput> GetRecoveryPlanXmlAsync(string recoveryPlanId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all recoveryplans under the resource.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list recoveryplans operation.
        /// </returns>
        Task<RecoveryPlanListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// PlannedFailover for the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> RecoveryPlanPlannedFailoverAsync(string recoveryPlanId, RpPlannedFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// TestFailover for the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> RecoveryPlanTestFailoverAsync(string recoveryPlanId, RpTestFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// UnplannedFailover for the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> RecoveryPlanUnplannedFailoverAsync(string recoveryPlanId, RpUnplannedFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Reprotect the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanId'>
        /// RecoveryPlan ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> ReprotectAsync(string recoveryPlanId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update the recovery plan.
        /// </summary>
        /// <param name='parameters'>
        /// Update recovery plan input parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> UpdateRecoveryPlanAsync(RecoveryPlanXmlData parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
