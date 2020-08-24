// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the information necessary to perform a create database restore point operation. </summary>
    public partial class CreateDatabaseRestorePointDefinition
    {
        /// <summary> Initializes a new instance of CreateDatabaseRestorePointDefinition. </summary>
        /// <param name="restorePointLabel"> The restore point label to apply. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointLabel"/> is null. </exception>
        public CreateDatabaseRestorePointDefinition(string restorePointLabel)
        {
            if (restorePointLabel == null)
            {
                throw new ArgumentNullException(nameof(restorePointLabel));
            }

            RestorePointLabel = restorePointLabel;
        }

        /// <summary> The restore point label to apply. </summary>
        public string RestorePointLabel { get; }
    }
}
