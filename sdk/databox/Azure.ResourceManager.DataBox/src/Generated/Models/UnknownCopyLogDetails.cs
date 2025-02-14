// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownCopyLogDetails. </summary>
    internal partial class UnknownCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCopyLogDetails"/>. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCopyLogDetails(DataBoxOrderType copyLogDetailsType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(copyLogDetailsType, serializedAdditionalRawData)
        {
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCopyLogDetails"/> for deserialization. </summary>
        internal UnknownCopyLogDetails()
        {
        }
    }
}
