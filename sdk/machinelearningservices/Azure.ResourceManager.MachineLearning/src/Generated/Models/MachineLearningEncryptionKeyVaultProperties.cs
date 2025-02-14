// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Customer Key vault properties. </summary>
    public partial class MachineLearningEncryptionKeyVaultProperties
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningEncryptionKeyVaultProperties"/>. </summary>
        /// <param name="keyIdentifier"> KeyVault key identifier to encrypt the data. </param>
        /// <param name="keyVaultArmId"> KeyVault Arm Id that contains the data encryption key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyIdentifier"/> or <paramref name="keyVaultArmId"/> is null. </exception>
        public MachineLearningEncryptionKeyVaultProperties(string keyIdentifier, ResourceIdentifier keyVaultArmId)
        {
            if (keyIdentifier == null)
            {
                throw new ArgumentNullException(nameof(keyIdentifier));
            }
            if (keyVaultArmId == null)
            {
                throw new ArgumentNullException(nameof(keyVaultArmId));
            }

            KeyIdentifier = keyIdentifier;
            KeyVaultArmId = keyVaultArmId;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEncryptionKeyVaultProperties"/>. </summary>
        /// <param name="identityClientId">
        /// Currently, we support only SystemAssigned MSI.
        /// We need this when we support UserAssignedIdentities
        /// </param>
        /// <param name="keyIdentifier"> KeyVault key identifier to encrypt the data. </param>
        /// <param name="keyVaultArmId"> KeyVault Arm Id that contains the data encryption key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningEncryptionKeyVaultProperties(string identityClientId, string keyIdentifier, ResourceIdentifier keyVaultArmId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdentityClientId = identityClientId;
            KeyIdentifier = keyIdentifier;
            KeyVaultArmId = keyVaultArmId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEncryptionKeyVaultProperties"/> for deserialization. </summary>
        internal MachineLearningEncryptionKeyVaultProperties()
        {
        }

        /// <summary>
        /// Currently, we support only SystemAssigned MSI.
        /// We need this when we support UserAssignedIdentities
        /// </summary>
        public string IdentityClientId { get; set; }
        /// <summary> KeyVault key identifier to encrypt the data. </summary>
        public string KeyIdentifier { get; set; }
        /// <summary> KeyVault Arm Id that contains the data encryption key. </summary>
        public ResourceIdentifier KeyVaultArmId { get; set; }
    }
}
