// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication agent details. </summary>
    public partial class ReplicationAgentDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReplicationAgentDetails"/>. </summary>
        internal ReplicationAgentDetails()
        {
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationAgentDetails"/>. </summary>
        /// <param name="id"> The replication agent Id. </param>
        /// <param name="name"> The replication agent name. </param>
        /// <param name="biosId"> The replication agent Bios Id. </param>
        /// <param name="fabricObjectId"> The fabric object Id. </param>
        /// <param name="fqdn"> The replication agent Fqdn. </param>
        /// <param name="version"> The version. </param>
        /// <param name="lastHeartbeatUtc"> The last heartbeat received from the replication agent. </param>
        /// <param name="health"> The health of the replication agent. </param>
        /// <param name="healthErrors"> The health errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReplicationAgentDetails(string id, string name, string biosId, ResourceIdentifier fabricObjectId, string fqdn, string version, DateTimeOffset? lastHeartbeatUtc, SiteRecoveryProtectionHealth? health, IReadOnlyList<SiteRecoveryHealthError> healthErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            FabricObjectId = fabricObjectId;
            Fqdn = fqdn;
            Version = version;
            LastHeartbeatUtc = lastHeartbeatUtc;
            Health = health;
            HealthErrors = healthErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The replication agent Id. </summary>
        public string Id { get; }
        /// <summary> The replication agent name. </summary>
        public string Name { get; }
        /// <summary> The replication agent Bios Id. </summary>
        public string BiosId { get; }
        /// <summary> The fabric object Id. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> The replication agent Fqdn. </summary>
        public string Fqdn { get; }
        /// <summary> The version. </summary>
        public string Version { get; }
        /// <summary> The last heartbeat received from the replication agent. </summary>
        public DateTimeOffset? LastHeartbeatUtc { get; }
        /// <summary> The health of the replication agent. </summary>
        public SiteRecoveryProtectionHealth? Health { get; }
        /// <summary> The health errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
    }
}
