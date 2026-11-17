using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalData
{
    /// <summary>
    /// Represents metadata about an analytical attribute, including its identifier, display name, unit of measure, and description.
    /// </summary>
    public class AttributeDTO
    {
        /// <summary>
        /// The unique identifier of the analytical attribute.
        /// Used internally for mapping and data retrieval in pipelines.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; }

        /// <summary>
        /// The human-readable name of the attribute.
        /// Example: "Temperature", "Pressure", etc.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The unit of measure associated with this attribute.
        /// Example: "°C", "Pa", "kWh".
        /// </summary>
        public string UoM { get; set; }

        /// <summary>
        /// A textual description of the attribute.
        /// Provides additional context or explanation for the attribute.
        /// Defaults to an empty string if not specified.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
