// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Azure Synapse Analytics Management Client
    /// </summary>
    public partial interface ISynapseManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IBigDataPoolsOperations.
        /// </summary>
        IBigDataPoolsOperations BigDataPools { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IIpFirewallRulesOperations.
        /// </summary>
        IIpFirewallRulesOperations IpFirewallRules { get; }

        /// <summary>
        /// Gets the ISqlPoolsOperations.
        /// </summary>
        ISqlPoolsOperations SqlPools { get; }

        /// <summary>
        /// Gets the ISqlPoolMetadataSyncConfigsOperations.
        /// </summary>
        ISqlPoolMetadataSyncConfigsOperations SqlPoolMetadataSyncConfigs { get; }

        /// <summary>
        /// Gets the ISqlPoolOperationResultsOperations.
        /// </summary>
        ISqlPoolOperationResultsOperations SqlPoolOperationResults { get; }

        /// <summary>
        /// Gets the ISqlPoolGeoBackupPoliciesOperations.
        /// </summary>
        ISqlPoolGeoBackupPoliciesOperations SqlPoolGeoBackupPolicies { get; }

        /// <summary>
        /// Gets the ISqlPoolDataWarehouseUserActivitiesOperations.
        /// </summary>
        ISqlPoolDataWarehouseUserActivitiesOperations SqlPoolDataWarehouseUserActivities { get; }

        /// <summary>
        /// Gets the ISqlPoolRestorePointsOperations.
        /// </summary>
        ISqlPoolRestorePointsOperations SqlPoolRestorePoints { get; }

        /// <summary>
        /// Gets the ISqlPoolReplicationLinksOperations.
        /// </summary>
        ISqlPoolReplicationLinksOperations SqlPoolReplicationLinks { get; }

        /// <summary>
        /// Gets the ISqlPoolTransparentDataEncryptionsOperations.
        /// </summary>
        ISqlPoolTransparentDataEncryptionsOperations SqlPoolTransparentDataEncryptions { get; }

        /// <summary>
        /// Gets the ISqlPoolBlobAuditingPoliciesOperations.
        /// </summary>
        ISqlPoolBlobAuditingPoliciesOperations SqlPoolBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the ISqlPoolOperations.
        /// </summary>
        ISqlPoolOperations SqlPoolOperations { get; }

        /// <summary>
        /// Gets the ISqlPoolUsagesOperations.
        /// </summary>
        ISqlPoolUsagesOperations SqlPoolUsages { get; }

        /// <summary>
        /// Gets the ISqlPoolSensitivityLabelsOperations.
        /// </summary>
        ISqlPoolSensitivityLabelsOperations SqlPoolSensitivityLabels { get; }

        /// <summary>
        /// Gets the ISqlPoolSchemasOperations.
        /// </summary>
        ISqlPoolSchemasOperations SqlPoolSchemas { get; }

        /// <summary>
        /// Gets the ISqlPoolTablesOperations.
        /// </summary>
        ISqlPoolTablesOperations SqlPoolTables { get; }

        /// <summary>
        /// Gets the ISqlPoolTableColumnsOperations.
        /// </summary>
        ISqlPoolTableColumnsOperations SqlPoolTableColumns { get; }

        /// <summary>
        /// Gets the ISqlPoolConnectionPoliciesOperations.
        /// </summary>
        ISqlPoolConnectionPoliciesOperations SqlPoolConnectionPolicies { get; }

        /// <summary>
        /// Gets the ISqlPoolVulnerabilityAssessmentsOperations.
        /// </summary>
        ISqlPoolVulnerabilityAssessmentsOperations SqlPoolVulnerabilityAssessments { get; }

        /// <summary>
        /// Gets the ISqlPoolVulnerabilityAssessmentScansOperations.
        /// </summary>
        ISqlPoolVulnerabilityAssessmentScansOperations SqlPoolVulnerabilityAssessmentScans { get; }

        /// <summary>
        /// Gets the ISqlPoolSecurityAlertPoliciesOperations.
        /// </summary>
        ISqlPoolSecurityAlertPoliciesOperations SqlPoolSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the ISqlPoolVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        ISqlPoolVulnerabilityAssessmentRuleBaselinesOperations SqlPoolVulnerabilityAssessmentRuleBaselines { get; }

        /// <summary>
        /// Gets the IWorkspacesOperations.
        /// </summary>
        IWorkspacesOperations Workspaces { get; }

        /// <summary>
        /// Gets the IWorkspaceAadAdminsOperations.
        /// </summary>
        IWorkspaceAadAdminsOperations WorkspaceAadAdmins { get; }

        /// <summary>
        /// Gets the IWorkspaceManagedIdentitySqlControlSettingsOperations.
        /// </summary>
        IWorkspaceManagedIdentitySqlControlSettingsOperations WorkspaceManagedIdentitySqlControlSettings { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimesOperations.
        /// </summary>
        IIntegrationRuntimesOperations IntegrationRuntimes { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeNodeIpAddressOperations.
        /// </summary>
        IIntegrationRuntimeNodeIpAddressOperations IntegrationRuntimeNodeIpAddress { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeObjectMetadataOperations.
        /// </summary>
        IIntegrationRuntimeObjectMetadataOperations IntegrationRuntimeObjectMetadata { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeNodesOperations.
        /// </summary>
        IIntegrationRuntimeNodesOperations IntegrationRuntimeNodes { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeCredentialsOperations.
        /// </summary>
        IIntegrationRuntimeCredentialsOperations IntegrationRuntimeCredentials { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeConnectionInfosOperations.
        /// </summary>
        IIntegrationRuntimeConnectionInfosOperations IntegrationRuntimeConnectionInfos { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeAuthKeysOperations.
        /// </summary>
        IIntegrationRuntimeAuthKeysOperations IntegrationRuntimeAuthKeys { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeMonitoringDataOperations.
        /// </summary>
        IIntegrationRuntimeMonitoringDataOperations IntegrationRuntimeMonitoringData { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimeStatusOperations.
        /// </summary>
        IIntegrationRuntimeStatusOperations IntegrationRuntimeStatus { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkHubsOperations.
        /// </summary>
        IPrivateLinkHubsOperations PrivateLinkHubs { get; }

    }
}
