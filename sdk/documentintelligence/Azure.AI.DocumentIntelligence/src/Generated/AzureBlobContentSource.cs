// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Azure Blob Storage content. </summary>
    public partial class AzureBlobContentSource
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

        /// <summary> Initializes a new instance of <see cref="AzureBlobContentSource"/>. </summary>
        /// <param name="containerUrl"> Azure Blob Storage container URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUrl"/> is null. </exception>
        public AzureBlobContentSource(Uri containerUrl)
        {
            if (containerUrl == null)
            {
                throw new ArgumentNullException(nameof(containerUrl));
            }

            ContainerUrl = containerUrl;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobContentSource"/>. </summary>
        /// <param name="containerUrl"> Azure Blob Storage container URL. </param>
        /// <param name="prefix"> Blob name prefix. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureBlobContentSource(Uri containerUrl, string prefix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContainerUrl = containerUrl;
            Prefix = prefix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobContentSource"/> for deserialization. </summary>
        internal AzureBlobContentSource()
        {
        }

        /// <summary> Azure Blob Storage container URL. </summary>
        public Uri ContainerUrl { get; set; }
        /// <summary> Blob name prefix. </summary>
        public string Prefix { get; set; }
    }
}
