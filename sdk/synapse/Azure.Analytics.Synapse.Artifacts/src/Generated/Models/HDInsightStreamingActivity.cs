// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HDInsight streaming activity type. </summary>
    public partial class HDInsightStreamingActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightStreamingActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="mapper"> Mapper executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="reducer"> Reducer executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="input"> Input blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="output"> Output blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="filePaths"> Paths to streaming job files. Can be directories. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="mapper"/>, <paramref name="reducer"/>, <paramref name="input"/>, <paramref name="output"/>, or <paramref name="filePaths"/> is null. </exception>
        public HDInsightStreamingActivity(string name, object mapper, object reducer, object input, object output, IEnumerable<object> filePaths) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }
            if (reducer == null)
            {
                throw new ArgumentNullException(nameof(reducer));
            }
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }
            if (filePaths == null)
            {
                throw new ArgumentNullException(nameof(filePaths));
            }

            StorageLinkedServices = new ChangeTrackingList<LinkedServiceReference>();
            Arguments = new ChangeTrackingList<object>();
            Mapper = mapper;
            Reducer = reducer;
            Input = input;
            Output = output;
            FilePaths = filePaths.ToList();
            CommandEnvironment = new ChangeTrackingList<object>();
            Defines = new ChangeTrackingDictionary<string, object>();
            Type = "HDInsightStreaming";
        }

        /// <summary> Initializes a new instance of HDInsightStreamingActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="mapper"> Mapper executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="reducer"> Reducer executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="input"> Input blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="output"> Output blob path. Type: string (or Expression with resultType string). </param>
        /// <param name="filePaths"> Paths to streaming job files. Can be directories. </param>
        /// <param name="fileLinkedService"> Linked service reference where the files are located. </param>
        /// <param name="combiner"> Combiner executable name. Type: string (or Expression with resultType string). </param>
        /// <param name="commandEnvironment"> Command line environment values. </param>
        /// <param name="defines"> Allows user to specify defines for streaming job request. </param>
        internal HDInsightStreamingActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<LinkedServiceReference> storageLinkedServices, IList<object> arguments, HDInsightActivityDebugInfoOption? getDebugInfo, object mapper, object reducer, object input, object output, IList<object> filePaths, LinkedServiceReference fileLinkedService, object combiner, IList<object> commandEnvironment, IDictionary<string, object> defines) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            Mapper = mapper;
            Reducer = reducer;
            Input = input;
            Output = output;
            FilePaths = filePaths;
            FileLinkedService = fileLinkedService;
            Combiner = combiner;
            CommandEnvironment = commandEnvironment;
            Defines = defines;
            Type = type ?? "HDInsightStreaming";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<LinkedServiceReference> StorageLinkedServices { get; }
        /// <summary> User specified arguments to HDInsightActivity. </summary>
        public IList<object> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOption? GetDebugInfo { get; set; }
        /// <summary> Mapper executable name. Type: string (or Expression with resultType string). </summary>
        public object Mapper { get; set; }
        /// <summary> Reducer executable name. Type: string (or Expression with resultType string). </summary>
        public object Reducer { get; set; }
        /// <summary> Input blob path. Type: string (or Expression with resultType string). </summary>
        public object Input { get; set; }
        /// <summary> Output blob path. Type: string (or Expression with resultType string). </summary>
        public object Output { get; set; }
        /// <summary> Paths to streaming job files. Can be directories. </summary>
        public IList<object> FilePaths { get; }
        /// <summary> Linked service reference where the files are located. </summary>
        public LinkedServiceReference FileLinkedService { get; set; }
        /// <summary> Combiner executable name. Type: string (or Expression with resultType string). </summary>
        public object Combiner { get; set; }
        /// <summary> Command line environment values. </summary>
        public IList<object> CommandEnvironment { get; }
        /// <summary> Allows user to specify defines for streaming job request. </summary>
        public IDictionary<string, object> Defines { get; }
    }
}
