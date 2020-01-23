namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum TransactionStatusInformationMeaning
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        OfflineDataAuthenticationWasPerformed = 1 << 1,

        /// <summary>
        /// 
        /// </summary>
        CardholderVerificationWasPerformed = 1 << 2,

        /// <summary>
        /// 
        /// </summary>
        CardRiskManagementWasPerformed = 1 << 3,

        /// <summary>
        /// 
        /// </summary>
        IssuerAuthenticationWasPerformed = 1 << 4,

        /// <summary>
        /// 
        /// </summary>
        TerminalRiskManagementWasPerformed = 1 << 5,

        /// <summary>
        /// 
        /// </summary>
        ScriptProcessingWasPerformed = 1 << 6,
    }
}
