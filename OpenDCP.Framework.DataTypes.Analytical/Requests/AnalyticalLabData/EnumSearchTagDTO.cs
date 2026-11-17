using OpenDCP.Framework.DataTypes.Analytical.Constants;

namespace OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalLabData
{
    /// <summary>
    /// A key/value filter applied when searching data.
    /// </summary>
    public class EnumSearchTagDTO : SearchTagDTO
    {
        /// <summary>
        /// Key to match.
        /// </summary>
        public SearchTagKey Key { get; set; }
    }
}
