using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData
{
    public class SampleSetDTO
    {
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string FileId { get; set; }
        public List<string> Category { get; set; } = new List<string>();
        public DateTime CreatedAt { get; set; }
        public string ProjectName { get; set; }
        public string SampleName { get; set; }
    }
}
