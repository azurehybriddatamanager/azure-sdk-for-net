// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class HDInsightStreamingActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageLinkedServices))
            {
                writer.WritePropertyName("storageLinkedServices");
                writer.WriteStartArray();
                foreach (var item in StorageLinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments");
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GetDebugInfo))
            {
                writer.WritePropertyName("getDebugInfo");
                writer.WriteStringValue(GetDebugInfo.Value.ToString());
            }
            writer.WritePropertyName("mapper");
            writer.WriteObjectValue(Mapper);
            writer.WritePropertyName("reducer");
            writer.WriteObjectValue(Reducer);
            writer.WritePropertyName("input");
            writer.WriteObjectValue(Input);
            writer.WritePropertyName("output");
            writer.WriteObjectValue(Output);
            writer.WritePropertyName("filePaths");
            writer.WriteStartArray();
            foreach (var item in FilePaths)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(FileLinkedService))
            {
                writer.WritePropertyName("fileLinkedService");
                writer.WriteObjectValue(FileLinkedService);
            }
            if (Optional.IsDefined(Combiner))
            {
                writer.WritePropertyName("combiner");
                writer.WriteObjectValue(Combiner);
            }
            if (Optional.IsCollectionDefined(CommandEnvironment))
            {
                writer.WritePropertyName("commandEnvironment");
                writer.WriteStartArray();
                foreach (var item in CommandEnvironment)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Defines))
            {
                writer.WritePropertyName("defines");
                writer.WriteStartObject();
                foreach (var item in Defines)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightStreamingActivity DeserializeHDInsightStreamingActivity(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            Optional<IList<LinkedServiceReference>> storageLinkedServices = default;
            Optional<IList<object>> arguments = default;
            Optional<HDInsightActivityDebugInfoOption> getDebugInfo = default;
            object mapper = default;
            object reducer = default;
            object input = default;
            object output = default;
            IList<object> filePaths = default;
            Optional<LinkedServiceReference> fileLinkedService = default;
            Optional<object> combiner = default;
            Optional<IList<object>> commandEnvironment = default;
            Optional<IDictionary<string, object>> defines = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageLinkedServices"))
                        {
                            List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                            }
                            storageLinkedServices = array;
                            continue;
                        }
                        if (property0.NameEquals("arguments"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            arguments = array;
                            continue;
                        }
                        if (property0.NameEquals("getDebugInfo"))
                        {
                            getDebugInfo = new HDInsightActivityDebugInfoOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mapper"))
                        {
                            mapper = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("reducer"))
                        {
                            reducer = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("input"))
                        {
                            input = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("output"))
                        {
                            output = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("filePaths"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            filePaths = array;
                            continue;
                        }
                        if (property0.NameEquals("fileLinkedService"))
                        {
                            fileLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("combiner"))
                        {
                            combiner = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("commandEnvironment"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            commandEnvironment = array;
                            continue;
                        }
                        if (property0.NameEquals("defines"))
                        {
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetObject());
                            }
                            defines = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightStreamingActivity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName.Value, policy.Value, Optional.ToList(storageLinkedServices), Optional.ToList(arguments), Optional.ToNullable(getDebugInfo), mapper, reducer, input, output, filePaths, fileLinkedService.Value, combiner.Value, Optional.ToList(commandEnvironment), Optional.ToDictionary(defines));
        }
    }
}
