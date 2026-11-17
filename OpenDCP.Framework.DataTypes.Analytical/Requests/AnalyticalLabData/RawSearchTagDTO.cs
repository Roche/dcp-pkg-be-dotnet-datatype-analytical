namespace OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalLabData
{
    /// <summary>
    /// A key/value filter applied when searching data.
    /// </summary>
    public class RawSearchTagDTO : SearchTagDTO
    {
        /// <summary>
        /// Key to match.
        /// </summary>
        public string Key { get; set; } = null!;
    }
}
