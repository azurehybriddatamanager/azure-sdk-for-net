// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The settings for the Upstream when the Azure SignalR is in server-less
    /// mode.
    /// </summary>
    public partial class ServerlessUpstreamSettings
    {
        /// <summary>
        /// Initializes a new instance of the ServerlessUpstreamSettings class.
        /// </summary>
        public ServerlessUpstreamSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerlessUpstreamSettings class.
        /// </summary>
        /// <param name="templates">Gets or sets the list of Upstream URL
        /// templates. Order matters, and the first matching template takes
        /// effects.</param>
        public ServerlessUpstreamSettings(IList<UpstreamTemplate> templates = default(IList<UpstreamTemplate>))
        {
            Templates = templates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Upstream URL templates. Order matters, and
        /// the first matching template takes effects.
        /// </summary>
        [JsonProperty(PropertyName = "templates")]
        public IList<UpstreamTemplate> Templates { get; set; }

    }
}
