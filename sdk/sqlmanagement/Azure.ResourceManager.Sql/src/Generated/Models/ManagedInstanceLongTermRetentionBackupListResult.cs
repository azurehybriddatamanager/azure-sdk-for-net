// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of long term retention backups for managed database(s). </summary>
    public partial class ManagedInstanceLongTermRetentionBackupListResult
    {
        /// <summary> Initializes a new instance of ManagedInstanceLongTermRetentionBackupListResult. </summary>
        internal ManagedInstanceLongTermRetentionBackupListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceLongTermRetentionBackup>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceLongTermRetentionBackupListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstanceLongTermRetentionBackupListResult(IReadOnlyList<ManagedInstanceLongTermRetentionBackup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceLongTermRetentionBackup> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
