// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maintenance
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublicMaintenanceConfigurationsOperations.
    /// </summary>
    public static partial class PublicMaintenanceConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Get Public Maintenance Configuration records
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<MaintenanceConfiguration> List(this IPublicMaintenanceConfigurationsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Public Maintenance Configuration records
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<MaintenanceConfiguration>> ListAsync(this IPublicMaintenanceConfigurationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Public Maintenance Configuration record
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceName'>
            /// Resource Identifier
            /// </param>
            public static MaintenanceConfiguration Get(this IPublicMaintenanceConfigurationsOperations operations, string resourceName)
            {
                return operations.GetAsync(resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Public Maintenance Configuration record
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceName'>
            /// Resource Identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MaintenanceConfiguration> GetAsync(this IPublicMaintenanceConfigurationsOperations operations, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
