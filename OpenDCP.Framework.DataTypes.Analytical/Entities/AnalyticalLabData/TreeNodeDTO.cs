using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData
{
    public class TreeNodeDTO
    {
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool HasChildren { get; set; }
        public int Level { get; set; }
        [ConnectionManager(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string FileId { get; set; } = string.Empty;
    }
}
