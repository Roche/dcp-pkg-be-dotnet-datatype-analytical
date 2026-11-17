namespace OpenDCP.Framework.DataTypes.Analytical.Constants
{
    public enum InjectionStatus : byte
    {
        /// <summary>Status was missing, empty, or not recognized.</summary>
        Unknown = 0,
        /// <summary>Injection completed successfully.</summary>
        Complete = 1,
        /// <summary>Injection was aborted by the user.</summary>
        UserAbort = 2,
        /// <summary>Injection did not finish.</summary>
        Incomplete = 3,
        /// <summary>Injection failed due to an instrument error.</summary>
        InstrumentFailure = 4,
    }
}
