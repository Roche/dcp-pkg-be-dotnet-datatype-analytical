using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalData
{
    /// <summary>
    /// Represents a single analytical attribute and its associated data values.
    /// </summary>
    public class AnalyticalDataDTO
    {
        /// <summary>
        /// The human-readable name of the analytical attribute.
        /// Example: "Temperature", "Pressure", etc.
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// The unique identifier of the analytical attribute.
        /// Used internally for mapping and data retrieval in pipelines.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string AttributeId { get; set; }

        /// <summary>
        /// The collection of values associated with this attribute.
        /// Each entry represents a timestamped data point or measurement.
        /// </summary>
        public List<AnalyticalDataValueDTO> Values { get; set; } = new List<AnalyticalDataValueDTO>();
    }
}
