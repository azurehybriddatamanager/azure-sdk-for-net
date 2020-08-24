// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PrivateEndpointConnectionProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivateEndpointConnectionProvisioningState
    {
        /// <summary>
        /// The connection status is final and is ready for use if Status is
        /// Approved.
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        /// <summary>
        /// The user has requested that the connection status be updated, but
        /// the update operation has not yet completed. You may not reference
        /// the connection when connecting the Batch account.
        /// </summary>
        [EnumMember(Value = "Updating")]
        Updating,
        /// <summary>
        /// The user requested that the connection be updated and it failed.
        /// You may retry the update operation.
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class PrivateEndpointConnectionProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this PrivateEndpointConnectionProvisioningState? value)
        {
            return value == null ? null : ((PrivateEndpointConnectionProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PrivateEndpointConnectionProvisioningState value)
        {
            switch( value )
            {
                case PrivateEndpointConnectionProvisioningState.Succeeded:
                    return "Succeeded";
                case PrivateEndpointConnectionProvisioningState.Updating:
                    return "Updating";
                case PrivateEndpointConnectionProvisioningState.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static PrivateEndpointConnectionProvisioningState? ParsePrivateEndpointConnectionProvisioningState(this string value)
        {
            switch( value )
            {
                case "Succeeded":
                    return PrivateEndpointConnectionProvisioningState.Succeeded;
                case "Updating":
                    return PrivateEndpointConnectionProvisioningState.Updating;
                case "Failed":
                    return PrivateEndpointConnectionProvisioningState.Failed;
            }
            return null;
        }
    }
}
