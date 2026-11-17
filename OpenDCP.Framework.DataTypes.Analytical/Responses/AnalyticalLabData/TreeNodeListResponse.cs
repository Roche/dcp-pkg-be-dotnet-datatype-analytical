using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalLabData
{
    public class TreeNodeListResponse : DatasourceResponse
    {
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<TreeNodeDTO> TreeNodes { get; set; } = new List<TreeNodeDTO>();
    }
}
