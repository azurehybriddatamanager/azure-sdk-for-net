// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The FlowLogs service client. </summary>
    public partial class FlowLogsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FlowLogsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of FlowLogsOperations for mocking. </summary>
        protected FlowLogsOperations()
        {
        }
        /// <summary> Initializes a new instance of FlowLogsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal FlowLogsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new FlowLogsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a flow log resource by name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FlowLog>> GetAsync(string resourceGroupName, string networkWatcherName, string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkWatcherName, flowLogName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a flow log resource by name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FlowLog> Get(string resourceGroupName, string networkWatcherName, string flowLogName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkWatcherName, flowLogName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all flow log resources for the specified Network Watcher. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="networkWatcherName"/> is null. </exception>
        public virtual AsyncPageable<FlowLog> ListAsync(string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            async Task<Page<FlowLog>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FlowLog>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all flow log resources for the specified Network Watcher. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing Network Watcher. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Pageable<FlowLog> List(string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            Page<FlowLog> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkWatcherName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FlowLog> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, networkWatcherName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, <paramref name="flowLogName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<FlowLogsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string networkWatcherName, string flowLogName, FlowLog parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, networkWatcherName, flowLogName, parameters, cancellationToken).ConfigureAwait(false);
                return new FlowLogsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkWatcherName, flowLogName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a flow log for the specified network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, <paramref name="flowLogName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual FlowLogsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string networkWatcherName, string flowLogName, FlowLog parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, networkWatcherName, flowLogName, parameters, cancellationToken);
                return new FlowLogsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkWatcherName, flowLogName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified flow log resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<FlowLogsDeleteOperation> StartDeleteAsync(string resourceGroupName, string networkWatcherName, string flowLogName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkWatcherName, flowLogName, cancellationToken).ConfigureAwait(false);
                return new FlowLogsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkWatcherName, flowLogName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified flow log resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="flowLogName"/> is null. </exception>
        public virtual FlowLogsDeleteOperation StartDelete(string resourceGroupName, string networkWatcherName, string flowLogName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (flowLogName == null)
            {
                throw new ArgumentNullException(nameof(flowLogName));
            }

            using var scope = _clientDiagnostics.CreateScope("FlowLogsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, networkWatcherName, flowLogName, cancellationToken);
                return new FlowLogsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkWatcherName, flowLogName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
