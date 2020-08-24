// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static class ChangeTypeExtensions
    {
        public static string ToSerialString(this ChangeType value) => value switch
        {
            ChangeType.Create => "Create",
            ChangeType.Delete => "Delete",
            ChangeType.Ignore => "Ignore",
            ChangeType.Deploy => "Deploy",
            ChangeType.NoChange => "NoChange",
            ChangeType.Modify => "Modify",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ChangeType value.")
        };

        public static ChangeType ToChangeType(this string value)
        {
            if (string.Equals(value, "Create", StringComparison.InvariantCultureIgnoreCase)) return ChangeType.Create;
            if (string.Equals(value, "Delete", StringComparison.InvariantCultureIgnoreCase)) return ChangeType.Delete;
            if (string.Equals(value, "Ignore", StringComparison.InvariantCultureIgnoreCase)) return ChangeType.Ignore;
            if (string.Equals(value, "Deploy", StringComparison.InvariantCultureIgnoreCase)) return ChangeType.Deploy;
            if (string.Equals(value, "NoChange", StringComparison.InvariantCultureIgnoreCase)) return ChangeType.NoChange;
            if (string.Equals(value, "Modify", StringComparison.InvariantCultureIgnoreCase)) return ChangeType.Modify;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ChangeType value.");
        }
    }
}
