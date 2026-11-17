using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Analytical.Constants;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData
{
    /// <summary>
    /// Represents a data transfer object for an analytical injection, including sample metadata, run status, and associated labels.
    /// </summary>
    public class InjectionDTO
    {
        /// <summary>
        /// Gets or sets the name of the sample set or sequence run to which the injection belongs.
        /// </summary>
        public string SampleSetName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name or identifier of the specific sample being analyzed.
        /// </summary>
        public string SampleName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique result identifier associated with the processed injection data.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string ResultId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the current processing or execution status of the injection.
        /// </summary>
        public InjectionStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the collection of custom or system labels assigned to the injection.
        /// </summary>
        public List<InjectionLabelDTO> Labels { get; set; } = new List<InjectionLabelDTO>();
    }
}
