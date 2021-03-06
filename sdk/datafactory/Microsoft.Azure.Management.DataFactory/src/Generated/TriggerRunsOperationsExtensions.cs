// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TriggerRunsOperations.
    /// </summary>
    public static partial class TriggerRunsOperationsExtensions
    {
            /// <summary>
            /// Rerun single trigger instance by runId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='triggerName'>
            /// The trigger name.
            /// </param>
            /// <param name='runId'>
            /// The pipeline run identifier.
            /// </param>
            public static void Rerun(this ITriggerRunsOperations operations, string resourceGroupName, string factoryName, string triggerName, string runId)
            {
                operations.RerunAsync(resourceGroupName, factoryName, triggerName, runId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rerun single trigger instance by runId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='triggerName'>
            /// The trigger name.
            /// </param>
            /// <param name='runId'>
            /// The pipeline run identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RerunAsync(this ITriggerRunsOperations operations, string resourceGroupName, string factoryName, string triggerName, string runId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RerunWithHttpMessagesAsync(resourceGroupName, factoryName, triggerName, runId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Cancel a single trigger instance by runId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='triggerName'>
            /// The trigger name.
            /// </param>
            /// <param name='runId'>
            /// The pipeline run identifier.
            /// </param>
            public static void Cancel(this ITriggerRunsOperations operations, string resourceGroupName, string factoryName, string triggerName, string runId)
            {
                operations.CancelAsync(resourceGroupName, factoryName, triggerName, runId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a single trigger instance by runId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='triggerName'>
            /// The trigger name.
            /// </param>
            /// <param name='runId'>
            /// The pipeline run identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this ITriggerRunsOperations operations, string resourceGroupName, string factoryName, string triggerName, string runId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(resourceGroupName, factoryName, triggerName, runId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Query trigger runs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='filterParameters'>
            /// Parameters to filter the pipeline run.
            /// </param>
            public static TriggerRunsQueryResponse QueryByFactory(this ITriggerRunsOperations operations, string resourceGroupName, string factoryName, RunFilterParameters filterParameters)
            {
                return operations.QueryByFactoryAsync(resourceGroupName, factoryName, filterParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query trigger runs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='filterParameters'>
            /// Parameters to filter the pipeline run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TriggerRunsQueryResponse> QueryByFactoryAsync(this ITriggerRunsOperations operations, string resourceGroupName, string factoryName, RunFilterParameters filterParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, filterParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
