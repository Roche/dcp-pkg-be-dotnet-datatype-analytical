using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData
{
    /// <summary>
    /// Represents data transfer object for analytical response curve data, containing coordinates and unit of measurement.
    /// </summary>
    public class ResponseCurveDTO
    {
        /// <summary>
        /// Gets or sets the unit of measurement (UoM) associated with the response curve values.
        /// </summary>
        public string UoM { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of X-axis data points (e.g., concentration, time, or wavelength).
        /// </summary>
        public List<double> X { get; set; } = new List<double>();

        /// <summary>
        /// Gets or sets the collection of Y-axis data points representing the corresponding measured response values.
        /// </summary>
        public List<double> Y { get; set; } = new List<double>();
    }
}