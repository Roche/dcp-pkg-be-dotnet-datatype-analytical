using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData;

namespace OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalLabData
{
    /// <summary>
    /// Represents the data source response containing analytical response curve data.
    /// </summary>
    public class ResponseCurveResponse : DatasourceResponse
    {
        /// <summary>
        /// Gets or sets the response curve data, including coordinates and measurement units.
        /// </summary>
        public ResponseCurveDTO ResponseCurve { get; set; } = new ResponseCurveDTO();
    }
}