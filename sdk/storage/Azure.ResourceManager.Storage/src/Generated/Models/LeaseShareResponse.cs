// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Lease Share response schema. </summary>
    public partial class LeaseShareResponse
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

        /// <summary> Initializes a new instance of <see cref="LeaseShareResponse"/>. </summary>
        internal LeaseShareResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LeaseShareResponse"/>. </summary>
        /// <param name="leaseId"> Returned unique lease ID that must be included with any request to delete the share, or to renew, change, or release the lease. </param>
        /// <param name="leaseTimeSeconds"> Approximate time remaining in the lease period, in seconds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LeaseShareResponse(string leaseId, string leaseTimeSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LeaseId = leaseId;
            LeaseTimeSeconds = leaseTimeSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Returned unique lease ID that must be included with any request to delete the share, or to renew, change, or release the lease. </summary>
        public string LeaseId { get; }
        /// <summary> Approximate time remaining in the lease period, in seconds. </summary>
        public string LeaseTimeSeconds { get; }
    }
}
