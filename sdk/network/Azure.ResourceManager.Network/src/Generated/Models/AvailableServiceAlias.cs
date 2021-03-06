// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The available service alias. </summary>
    public partial class AvailableServiceAlias
    {
        /// <summary> Initializes a new instance of AvailableServiceAlias. </summary>
        internal AvailableServiceAlias()
        {
        }

        /// <summary> Initializes a new instance of AvailableServiceAlias. </summary>
        /// <param name="name"> The name of the service alias. </param>
        /// <param name="id"> The ID of the service alias. </param>
        /// <param name="type"> The type of the resource. </param>
        /// <param name="resourceName"> The resource name of the service alias. </param>
        internal AvailableServiceAlias(string name, string id, string type, string resourceName)
        {
            Name = name;
            Id = id;
            Type = type;
            ResourceName = resourceName;
        }

        /// <summary> The name of the service alias. </summary>
        public string Name { get; }
        /// <summary> The ID of the service alias. </summary>
        public string Id { get; }
        /// <summary> The type of the resource. </summary>
        public string Type { get; }
        /// <summary> The resource name of the service alias. </summary>
        public string ResourceName { get; }
    }
}
