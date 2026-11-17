using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalData
{
    /// <summary>
    /// Represents a single data point for an analytical attribute.
    /// Contains the observation ID, attribute ID, value, and timestamp.
    /// </summary>
    public class AnalyticalDataValueDTO
    {
        /// <summary>
        /// The unique identifier of the observation.
        /// Typically used to track individual measurements or events.
        /// </summary>
        public string ObsId { get; set; }

        /// <summary>
        /// The unique identifier of the attribute associated with this data point.
        /// Used internally for mapping and transformation in pipelines.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; }

        /// <summary>
        /// The value of the attribute at the specified observation.
        /// Can be of any type (numeric, string, boolean, etc.).
        /// </summary>
        public dynamic Value { get; set; } = null;

        /// <summary>
        /// The timestamp of the observation, typically in ISO 8601 format.
        /// Indicates when the measurement was taken.
        /// </summary>
        public string Timestamp { get; set; }
    }
}
