// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A class that contains virtual network definition. </summary>
    public partial class KustoClusterVirtualNetworkConfiguration
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

        /// <summary> Initializes a new instance of <see cref="KustoClusterVirtualNetworkConfiguration"/>. </summary>
        /// <param name="subnetId"> The subnet resource id. </param>
        /// <param name="enginePublicIPId"> Engine service's public IP address resource id. </param>
        /// <param name="dataManagementPublicIPId"> Data management's service public IP address resource id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetId"/>, <paramref name="enginePublicIPId"/> or <paramref name="dataManagementPublicIPId"/> is null. </exception>
        public KustoClusterVirtualNetworkConfiguration(string subnetId, string enginePublicIPId, string dataManagementPublicIPId)
        {
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }
            if (enginePublicIPId == null)
            {
                throw new ArgumentNullException(nameof(enginePublicIPId));
            }
            if (dataManagementPublicIPId == null)
            {
                throw new ArgumentNullException(nameof(dataManagementPublicIPId));
            }

            SubnetId = subnetId;
            EnginePublicIPId = enginePublicIPId;
            DataManagementPublicIPId = dataManagementPublicIPId;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterVirtualNetworkConfiguration"/>. </summary>
        /// <param name="subnetId"> The subnet resource id. </param>
        /// <param name="enginePublicIPId"> Engine service's public IP address resource id. </param>
        /// <param name="dataManagementPublicIPId"> Data management's service public IP address resource id. </param>
        /// <param name="state"> When enabled, the cluster is deployed into the configured subnet, when disabled it will be removed from the subnet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoClusterVirtualNetworkConfiguration(string subnetId, string enginePublicIPId, string dataManagementPublicIPId, KustoClusterVnetState? state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubnetId = subnetId;
            EnginePublicIPId = enginePublicIPId;
            DataManagementPublicIPId = dataManagementPublicIPId;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterVirtualNetworkConfiguration"/> for deserialization. </summary>
        internal KustoClusterVirtualNetworkConfiguration()
        {
        }

        /// <summary> The subnet resource id. </summary>
        public string SubnetId { get; set; }
        /// <summary> Engine service's public IP address resource id. </summary>
        public string EnginePublicIPId { get; set; }
        /// <summary> Data management's service public IP address resource id. </summary>
        public string DataManagementPublicIPId { get; set; }
        /// <summary> When enabled, the cluster is deployed into the configured subnet, when disabled it will be removed from the subnet. </summary>
        public KustoClusterVnetState? State { get; set; }
    }
}
