// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ContainerService;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Desired outbound IP Prefix resources for the cluster load balancer. </summary>
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPPrefixes
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerProfileOutboundIPPrefixes"/>. </summary>
        public ManagedClusterLoadBalancerProfileOutboundIPPrefixes()
        {
            PublicIPPrefixes = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerProfileOutboundIPPrefixes"/>. </summary>
        /// <param name="publicIPPrefixes"> A list of public IP prefix resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterLoadBalancerProfileOutboundIPPrefixes(IList<WritableSubResource> publicIPPrefixes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicIPPrefixes = publicIPPrefixes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of public IP prefix resources. </summary>
        public IList<WritableSubResource> PublicIPPrefixes { get; }
    }
}
