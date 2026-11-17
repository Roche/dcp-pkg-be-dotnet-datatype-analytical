using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData;

namespace OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalLabData
{
    public class SampleSetResponse : DatasourceResponse
    {
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public SampleSetDTO SampleSet { get; set; }
    }
}
