// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProblemClassificationsOperations.
    /// </summary>
    public static partial class ProblemClassificationsOperationsExtensions
    {
            /// <summary>
            /// Lists all the problem classifications (categories) available for a specific
            /// Azure service. Always use the service and problem classifications obtained
            /// programmatically. This practice ensures that you always have the most
            /// recent set of service and problem classification Ids.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// Name of the Azure service for which the problem classifications need to be
            /// retrieved.
            /// </param>
            public static IEnumerable<ProblemClassification> List(this IProblemClassificationsOperations operations, string serviceName)
            {
                return operations.ListAsync(serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the problem classifications (categories) available for a specific
            /// Azure service. Always use the service and problem classifications obtained
            /// programmatically. This practice ensures that you always have the most
            /// recent set of service and problem classification Ids.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// Name of the Azure service for which the problem classifications need to be
            /// retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ProblemClassification>> ListAsync(this IProblemClassificationsOperations operations, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get problem classification details for a specific Azure service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// Name of the Azure service available for support.
            /// </param>
            /// <param name='problemClassificationName'>
            /// Name of problem classification.
            /// </param>
            public static ProblemClassification Get(this IProblemClassificationsOperations operations, string serviceName, string problemClassificationName)
            {
                return operations.GetAsync(serviceName, problemClassificationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get problem classification details for a specific Azure service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// Name of the Azure service available for support.
            /// </param>
            /// <param name='problemClassificationName'>
            /// Name of problem classification.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProblemClassification> GetAsync(this IProblemClassificationsOperations operations, string serviceName, string problemClassificationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(serviceName, problemClassificationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
