// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Radiology procedures are the specific imaging studies or examinations ordered for the patient, extracted from the document information and text. </summary>
    public partial class RadiologyProcedureInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="RadiologyProcedureInference"/>. </summary>
        /// <param name="imagingProcedures"> Imaging procedures. </param>
        /// <param name="orderedProcedure"> Ordered procedure information from the document information or text. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imagingProcedures"/> or <paramref name="orderedProcedure"/> is null. </exception>
        internal RadiologyProcedureInference(IEnumerable<ImagingProcedure> imagingProcedures, FhirR4Extendible orderedProcedure)
        {
            if (imagingProcedures == null)
            {
                throw new ArgumentNullException(nameof(imagingProcedures));
            }
            if (orderedProcedure == null)
            {
                throw new ArgumentNullException(nameof(orderedProcedure));
            }

            Kind = "radiologyProcedure";
            ProcedureCodes = new ChangeTrackingList<FhirR4CodeableConcept>();
            ImagingProcedures = imagingProcedures.ToList();
            OrderedProcedure = orderedProcedure;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyProcedureInference"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="procedureCodes"> LOINC codes for the procedure. </param>
        /// <param name="imagingProcedures"> Imaging procedures. </param>
        /// <param name="orderedProcedure"> Ordered procedure information from the document information or text. </param>
        internal RadiologyProcedureInference(string kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<FhirR4CodeableConcept> procedureCodes, IReadOnlyList<ImagingProcedure> imagingProcedures, FhirR4Extendible orderedProcedure) : base(kind, extension, serializedAdditionalRawData)
        {
            ProcedureCodes = procedureCodes;
            ImagingProcedures = imagingProcedures;
            OrderedProcedure = orderedProcedure;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyProcedureInference"/> for deserialization. </summary>
        internal RadiologyProcedureInference()
        {
        }

        /// <summary> LOINC codes for the procedure. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> ProcedureCodes { get; }
        /// <summary> Imaging procedures. </summary>
        public IReadOnlyList<ImagingProcedure> ImagingProcedures { get; }
        /// <summary> Ordered procedure information from the document information or text. </summary>
        public FhirR4Extendible OrderedProcedure { get; }
    }
}
