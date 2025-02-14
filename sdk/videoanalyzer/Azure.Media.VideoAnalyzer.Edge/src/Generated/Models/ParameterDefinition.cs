// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines the parameter value of an specific pipeline topology parameter. See pipeline topology parameters for more information. </summary>
    public partial class ParameterDefinition
    {
        /// <summary> Initializes a new instance of <see cref="ParameterDefinition"/>. </summary>
        /// <param name="name"> Name of the parameter declared in the pipeline topology. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ParameterDefinition(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Name of the parameter declared in the pipeline topology. </summary>
        public string Name { get; set; }
        /// <summary> Parameter value to be applied on this specific live pipeline. </summary>
        public string Value { get; set; }
    }
}
