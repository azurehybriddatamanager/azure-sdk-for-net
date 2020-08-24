// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> A private endpoint connection. </summary>
    public partial class PrivateEndpointConnection
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        public PrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. </param>
        /// <param name="provisioningState"> The provisioning status of the private endpoint connection. </param>
        /// <param name="privateEndpoint"> The resource of private endpoint. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        internal PrivateEndpointConnection(string id, string name, string type, ProvisioningState? provisioningState, PrivateEndpoint privateEndpoint, PrivateLinkServiceConnectionState privateLinkServiceConnectionState)
        {
            Id = id;
            Name = name;
            Type = type;
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        }

        /// <summary> The resource ID. </summary>
        public string Id { get; }
        /// <summary> The name of the resource. </summary>
        public string Name { get; }
        /// <summary> The type of the resource. </summary>
        public string Type { get; }
        /// <summary> The provisioning status of the private endpoint connection. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The resource of private endpoint. </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}
