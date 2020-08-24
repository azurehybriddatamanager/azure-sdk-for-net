// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetSkuCapacity
    {
        internal static VirtualMachineScaleSetSkuCapacity DeserializeVirtualMachineScaleSetSkuCapacity(JsonElement element)
        {
            Optional<long> minimum = default;
            Optional<long> maximum = default;
            Optional<long> defaultCapacity = default;
            Optional<VirtualMachineScaleSetSkuScaleType> scaleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"))
                {
                    minimum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximum"))
                {
                    maximum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultCapacity"))
                {
                    defaultCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scaleType"))
                {
                    scaleType = property.Value.GetString().ToVirtualMachineScaleSetSkuScaleType();
                    continue;
                }
            }
            return new VirtualMachineScaleSetSkuCapacity(Optional.ToNullable(minimum), Optional.ToNullable(maximum), Optional.ToNullable(defaultCapacity), Optional.ToNullable(scaleType));
        }
    }
}
