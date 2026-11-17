using OpenDCP.Framework.DataTypes.Analytical.Constants;

namespace OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalLabData
{
    /// <summary>
    /// A key/value filter applied when searching data.
    /// </summary>
    public class SearchTagDTO
    {
        /// <summary>
        /// Value to match./>
        /// </summary>
        public string Value { get; set; } = null!;

        /// <summary>
        /// Determines how <see cref="Key"/> is interpreted.
        /// </summary>
        public SearchTagType Type { get; set; }
    }
}
