using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalLabData
{
    public class PeakQueryDTO
    {
        public int StartIndex { get; set; } = 0;

        public int MaxCount { get; set; } = 100;

        public List<SearchTagDTO> SearchTags { get; set; } = new List<SearchTagDTO>();

        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Decode)]
        public List<string> ResultIds { get; set; } = new List<string>();
    }
}
