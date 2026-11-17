namespace OpenDCP.Framework.DataTypes.Analytical.Entities.AnalyticalLabData
{
    /// <summary>
    /// Represents data transfer object for analytical chromatographic peak measurements.
    /// </summary>
    public class PeakValueDTO
    {
        /// <summary>
        /// Gets or sets the retention time (the time elapsed between sample injection and the peak apex).
        /// </summary>
        public double? RetentionTime { get; set; }

        /// <summary>
        /// Gets or sets the calculated integrated area under the peak, typically proportional to analyte quantity.
        /// </summary>
        public double? Area { get; set; }

        /// <summary>
        /// Gets or sets the peak height measured from the baseline to the apex.
        /// </summary>
        public double? Height { get; set; }
    }
}