using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalLabData
{
    public class InjectionQueryDTO
    {
        public int StartIndex { get; set; } = 0;

        public int MaxCount { get; set; } = 100;

        public List<SearchTagDTO> SearchTags { get; set; } = new List<SearchTagDTO>();

        public string? ProjectName { get; set; }
    }
}
