using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData
{
    /// <summary>
    /// Represents a data transfer object for an identified chromatographic peak, linking its identity to its measured values.
    /// </summary>
    public class PeakDTO
    {
        /// <summary>
        /// Gets or sets the descriptive or chemical name of the peak (e.g., compound or analyte name).
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier for the peak.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the analytical result or sample run to which this peak belongs.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string ResultId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the measurement values associated with this peak, such as retention time, area, and height.
        /// </summary>
        public PeakValueDTO Value { get; set; } = null!;
    }
}