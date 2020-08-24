// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of the Credentials used to connect to Backend.
    /// </summary>
    public partial class BackendCredentialsContract
    {
        /// <summary>
        /// Initializes a new instance of the BackendCredentialsContract class.
        /// </summary>
        public BackendCredentialsContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendCredentialsContract class.
        /// </summary>
        /// <param name="certificate">List of Client Certificate
        /// Thumbprint.</param>
        /// <param name="query">Query Parameter description.</param>
        /// <param name="header">Header Parameter description.</param>
        /// <param name="authorization">Authorization header
        /// authentication</param>
        public BackendCredentialsContract(IList<string> certificate = default(IList<string>), IDictionary<string, IList<string>> query = default(IDictionary<string, IList<string>>), IDictionary<string, IList<string>> header = default(IDictionary<string, IList<string>>), BackendAuthorizationHeaderCredentials authorization = default(BackendAuthorizationHeaderCredentials))
        {
            Certificate = certificate;
            Query = query;
            Header = header;
            Authorization = authorization;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Client Certificate Thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public IList<string> Certificate { get; set; }

        /// <summary>
        /// Gets or sets query Parameter description.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public IDictionary<string, IList<string>> Query { get; set; }

        /// <summary>
        /// Gets or sets header Parameter description.
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        public IDictionary<string, IList<string>> Header { get; set; }

        /// <summary>
        /// Gets or sets authorization header authentication
        /// </summary>
        [JsonProperty(PropertyName = "authorization")]
        public BackendAuthorizationHeaderCredentials Authorization { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Authorization != null)
            {
                Authorization.Validate();
            }
        }
    }
}
