// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class PrivateEndpointConnectionProperties
    {
        internal static PrivateEndpointConnectionProperties DeserializePrivateEndpointConnectionProperties(JsonElement element)
        {
            Optional<PrivateEndpointProperty> privateEndpoint = default;
            Optional<PrivateLinkServiceConnectionStatePropertyAutoGenerated> privateLinkServiceConnectionState = default;
            Optional<PrivateEndpointProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"))
                {
                    privateEndpoint = PrivateEndpointProperty.DeserializePrivateEndpointProperty(property.Value);
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"))
                {
                    privateLinkServiceConnectionState = PrivateLinkServiceConnectionStatePropertyAutoGenerated.DeserializePrivateLinkServiceConnectionStatePropertyAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = new PrivateEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new PrivateEndpointConnectionProperties(privateEndpoint.Value, privateLinkServiceConnectionState.Value, Optional.ToNullable(provisioningState));
        }
    }
}
