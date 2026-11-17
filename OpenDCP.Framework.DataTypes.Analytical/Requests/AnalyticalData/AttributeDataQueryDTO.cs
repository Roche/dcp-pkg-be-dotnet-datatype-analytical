using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalData
{
    public class AttributeDataQueryDTO
    {
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> AttributeId { get; set; } = new List<string>();

        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Decode)]
        public List<string> EventId { get; set; } = new List<string>();
    }
}
