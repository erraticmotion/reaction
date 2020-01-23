namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// Represents the results available in the <see cref="ApplicationInterchangeProfile"/> type.
    /// </summary>
    [Flags]
    public enum ApplicationInterchangeProfileMeaning
    {
        /// <summary>
        /// No AIP
        /// </summary>
        None = 1 << 0,

        /// <summary>
        /// 
        /// </summary>
        SdaSupported = 1 << 1,

        /// <summary>
        /// 
        /// </summary>
        DdaSupported = 1 << 2,

        /// <summary>
        /// 
        /// </summary>
        CdaSupported = 1 << 3,

        /// <summary>
        /// 
        /// </summary>
        CardholderVerificationSupported = 1 << 4,

        /// <summary>
        /// 
        /// </summary>
        TerminalRiskManagementToBePerformed = 1 << 5,

        /// <summary>
        /// 
        /// </summary>
        IssuerAuthenticationIsSupported = 1 << 6,
    }
}
