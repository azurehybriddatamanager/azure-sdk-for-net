// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> The abstract common base of all domains. </summary>
    public partial class MonitorDomain
    {
        /// <summary> Initializes a new instance of MonitorDomain. </summary>
        public MonitorDomain()
        {
        }

        /// <summary> Initializes a new instance of MonitorDomain. </summary>
        /// <param name="test"> Ignored value. </param>
        internal MonitorDomain(string test)
        {
            Test = test;
        }

        /// <summary> Ignored value. </summary>
        public string Test { get; set; }
    }
}
