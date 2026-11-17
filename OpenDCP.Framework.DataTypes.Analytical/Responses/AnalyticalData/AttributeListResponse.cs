using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalData
{
    public class AttributeListResponse : DatasourceResponse
    {
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<AttributeDTO> Attributes { get; set; }
    }
}
