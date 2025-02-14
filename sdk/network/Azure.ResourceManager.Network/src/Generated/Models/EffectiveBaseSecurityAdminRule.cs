// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary>
    /// Network base admin rule.
    /// Please note <see cref="EffectiveBaseSecurityAdminRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EffectiveSecurityAdminRule"/> and <see cref="EffectiveDefaultSecurityAdminRule"/>.
    /// </summary>
    public abstract partial class EffectiveBaseSecurityAdminRule
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EffectiveBaseSecurityAdminRule"/>. </summary>
        protected EffectiveBaseSecurityAdminRule()
        {
            RuleCollectionAppliesToGroups = new ChangeTrackingList<NetworkManagerSecurityGroupItem>();
            RuleGroups = new ChangeTrackingList<NetworkConfigurationGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="EffectiveBaseSecurityAdminRule"/>. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="configurationDescription"> A description of the security admin configuration. </param>
        /// <param name="ruleCollectionDescription"> A description of the rule collection. </param>
        /// <param name="ruleCollectionAppliesToGroups"> Groups for rule collection. </param>
        /// <param name="ruleGroups"> Effective configuration groups. </param>
        /// <param name="kind"> Whether the rule is custom or default. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EffectiveBaseSecurityAdminRule(ResourceIdentifier resourceId, string configurationDescription, string ruleCollectionDescription, IReadOnlyList<NetworkManagerSecurityGroupItem> ruleCollectionAppliesToGroups, IReadOnlyList<NetworkConfigurationGroup> ruleGroups, EffectiveAdminRuleKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            ConfigurationDescription = configurationDescription;
            RuleCollectionDescription = ruleCollectionDescription;
            RuleCollectionAppliesToGroups = ruleCollectionAppliesToGroups;
            RuleGroups = ruleGroups;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> A description of the security admin configuration. </summary>
        public string ConfigurationDescription { get; }
        /// <summary> A description of the rule collection. </summary>
        public string RuleCollectionDescription { get; }
        /// <summary> Groups for rule collection. </summary>
        public IReadOnlyList<NetworkManagerSecurityGroupItem> RuleCollectionAppliesToGroups { get; }
        /// <summary> Effective configuration groups. </summary>
        public IReadOnlyList<NetworkConfigurationGroup> RuleGroups { get; }
        /// <summary> Whether the rule is custom or default. </summary>
        internal EffectiveAdminRuleKind Kind { get; set; }
    }
}
