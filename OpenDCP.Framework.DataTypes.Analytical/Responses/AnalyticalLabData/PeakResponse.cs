using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalLabData
{
    /// <summary>
    /// Represents the data source response containing analytical chromatographic peak information.
    /// </summary>
    public class PeakResponse : DatasourceResponse
    {
        /// <summary>
        /// Gets or sets the collection of identified chromatographic peaks retrieved from the analytical data source.
        /// </summary>
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<PeakDTO> Peaks { get; set; } = new List<PeakDTO>();
    }
}
