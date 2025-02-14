// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Storage Profile properties of a server. </summary>
    public partial class PostgreSqlStorageProfile
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlStorageProfile"/>. </summary>
        public PostgreSqlStorageProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlStorageProfile"/>. </summary>
        /// <param name="backupRetentionDays"> Backup retention days for the server. </param>
        /// <param name="geoRedundantBackup"> Enable Geo-redundant or not for server backup. </param>
        /// <param name="storageInMB"> Max storage allowed for a server. </param>
        /// <param name="storageAutogrow"> Enable Storage Auto Grow. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlStorageProfile(int? backupRetentionDays, PostgreSqlGeoRedundantBackup? geoRedundantBackup, int? storageInMB, PostgreSqlStorageAutogrow? storageAutogrow, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackupRetentionDays = backupRetentionDays;
            GeoRedundantBackup = geoRedundantBackup;
            StorageInMB = storageInMB;
            StorageAutogrow = storageAutogrow;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Backup retention days for the server. </summary>
        public int? BackupRetentionDays { get; set; }
        /// <summary> Enable Geo-redundant or not for server backup. </summary>
        public PostgreSqlGeoRedundantBackup? GeoRedundantBackup { get; set; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? StorageInMB { get; set; }
        /// <summary> Enable Storage Auto Grow. </summary>
        public PostgreSqlStorageAutogrow? StorageAutogrow { get; set; }
    }
}
