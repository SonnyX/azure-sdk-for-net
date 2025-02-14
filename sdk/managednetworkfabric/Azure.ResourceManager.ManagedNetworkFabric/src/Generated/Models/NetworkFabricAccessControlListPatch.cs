// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The Access Control Lists patch resource definition. </summary>
    public partial class NetworkFabricAccessControlListPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkFabricAccessControlListPatch"/>. </summary>
        public NetworkFabricAccessControlListPatch()
        {
            MatchConfigurations = new ChangeTrackingList<AccessControlListMatchConfiguration>();
            DynamicMatchConfigurations = new ChangeTrackingList<CommonDynamicMatchConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricAccessControlListPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="configurationType"> Input method to configure Access Control List. </param>
        /// <param name="aclsUri"> Access Control List file URL. </param>
        /// <param name="defaultAction"> Default action that needs to be applied when no condition is matched. Example: Permit | Deny. </param>
        /// <param name="matchConfigurations"> List of match configurations. </param>
        /// <param name="dynamicMatchConfigurations"> List of dynamic match configurations. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        internal NetworkFabricAccessControlListPatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, NetworkFabricConfigurationType? configurationType, Uri aclsUri, CommunityActionType? defaultAction, IList<AccessControlListMatchConfiguration> matchConfigurations, IList<CommonDynamicMatchConfiguration> dynamicMatchConfigurations, string annotation) : base(tags, serializedAdditionalRawData)
        {
            ConfigurationType = configurationType;
            AclsUri = aclsUri;
            DefaultAction = defaultAction;
            MatchConfigurations = matchConfigurations;
            DynamicMatchConfigurations = dynamicMatchConfigurations;
            Annotation = annotation;
        }

        /// <summary> Input method to configure Access Control List. </summary>
        public NetworkFabricConfigurationType? ConfigurationType { get; set; }
        /// <summary> Access Control List file URL. </summary>
        public Uri AclsUri { get; set; }
        /// <summary> Default action that needs to be applied when no condition is matched. Example: Permit | Deny. </summary>
        public CommunityActionType? DefaultAction { get; set; }
        /// <summary> List of match configurations. </summary>
        public IList<AccessControlListMatchConfiguration> MatchConfigurations { get; }
        /// <summary> List of dynamic match configurations. </summary>
        public IList<CommonDynamicMatchConfiguration> DynamicMatchConfigurations { get; }
        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
    }
}
