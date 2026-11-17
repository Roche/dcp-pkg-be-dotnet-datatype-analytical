namespace OpenDCP.Framework.DataTypes.Analytical.Constants
{
    /// <summary>
    /// Specifies the type of a search tag.
    /// </summary>
    public enum SearchTagType : byte
    {
        /// <summary>
        /// Tag based on a custom field.
        /// </summary>
        CustomField = 0,

        /// <summary>
        /// Tag based on a sample label.
        /// </summary>
        SampleLabel = 1,
    }
}
