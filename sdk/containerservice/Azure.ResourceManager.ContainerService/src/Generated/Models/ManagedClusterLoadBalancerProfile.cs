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
    /// <summary> Profile of the managed cluster load balancer. </summary>
    public partial class ManagedClusterLoadBalancerProfile
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerProfile"/>. </summary>
        public ManagedClusterLoadBalancerProfile()
        {
            EffectiveOutboundIPs = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerProfile"/>. </summary>
        /// <param name="managedOutboundIPs"> Desired managed outbound IPs for the cluster load balancer. </param>
        /// <param name="outboundIPPrefixes"> Desired outbound IP Prefix resources for the cluster load balancer. </param>
        /// <param name="outboundIPs"> Desired outbound IP resources for the cluster load balancer. </param>
        /// <param name="effectiveOutboundIPs"> The effective outbound IP resources of the cluster load balancer. </param>
        /// <param name="allocatedOutboundPorts"> The desired number of allocated SNAT ports per VM. Allowed values are in the range of 0 to 64000 (inclusive). The default value is 0 which results in Azure dynamically allocating ports. </param>
        /// <param name="idleTimeoutInMinutes"> Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120 (inclusive). The default value is 30 minutes. </param>
        /// <param name="enableMultipleStandardLoadBalancers"> Enable multiple standard load balancers per AKS cluster or not. </param>
        /// <param name="backendPoolType"> The type of the managed inbound Load Balancer BackendPool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterLoadBalancerProfile(ManagedClusterLoadBalancerProfileManagedOutboundIPs managedOutboundIPs, ManagedClusterLoadBalancerProfileOutboundIPPrefixes outboundIPPrefixes, ManagedClusterLoadBalancerProfileOutboundIPs outboundIPs, IList<WritableSubResource> effectiveOutboundIPs, int? allocatedOutboundPorts, int? idleTimeoutInMinutes, bool? enableMultipleStandardLoadBalancers, ManagedClusterLoadBalancerBackendPoolType? backendPoolType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManagedOutboundIPs = managedOutboundIPs;
            OutboundIPPrefixes = outboundIPPrefixes;
            OutboundIPs = outboundIPs;
            EffectiveOutboundIPs = effectiveOutboundIPs;
            AllocatedOutboundPorts = allocatedOutboundPorts;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableMultipleStandardLoadBalancers = enableMultipleStandardLoadBalancers;
            BackendPoolType = backendPoolType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Desired managed outbound IPs for the cluster load balancer. </summary>
        public ManagedClusterLoadBalancerProfileManagedOutboundIPs ManagedOutboundIPs { get; set; }
        /// <summary> Desired outbound IP Prefix resources for the cluster load balancer. </summary>
        internal ManagedClusterLoadBalancerProfileOutboundIPPrefixes OutboundIPPrefixes { get; set; }
        /// <summary> A list of public IP prefix resources. </summary>
        public IList<WritableSubResource> OutboundPublicIPPrefixes
        {
            get
            {
                if (OutboundIPPrefixes is null)
                    OutboundIPPrefixes = new ManagedClusterLoadBalancerProfileOutboundIPPrefixes();
                return OutboundIPPrefixes.PublicIPPrefixes;
            }
        }

        /// <summary> Desired outbound IP resources for the cluster load balancer. </summary>
        internal ManagedClusterLoadBalancerProfileOutboundIPs OutboundIPs { get; set; }
        /// <summary> A list of public IP resources. </summary>
        public IList<WritableSubResource> OutboundPublicIPs
        {
            get
            {
                if (OutboundIPs is null)
                    OutboundIPs = new ManagedClusterLoadBalancerProfileOutboundIPs();
                return OutboundIPs.PublicIPs;
            }
        }

        /// <summary> The effective outbound IP resources of the cluster load balancer. </summary>
        public IList<WritableSubResource> EffectiveOutboundIPs { get; }
        /// <summary> The desired number of allocated SNAT ports per VM. Allowed values are in the range of 0 to 64000 (inclusive). The default value is 0 which results in Azure dynamically allocating ports. </summary>
        public int? AllocatedOutboundPorts { get; set; }
        /// <summary> Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120 (inclusive). The default value is 30 minutes. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> Enable multiple standard load balancers per AKS cluster or not. </summary>
        public bool? EnableMultipleStandardLoadBalancers { get; set; }
        /// <summary> The type of the managed inbound Load Balancer BackendPool. </summary>
        public ManagedClusterLoadBalancerBackendPoolType? BackendPoolType { get; set; }
    }
}
