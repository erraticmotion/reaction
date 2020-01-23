namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum TerminalVerificationResultMeaning
    {
        /// <summary>
        /// No TVR
        /// </summary>
        None = 1 << 0,

        /// <summary>
        /// 
        /// </summary>
        OfflineDataAuthenticationWasNotPerformed = 1 << 1,

        /// <summary>
        /// 
        /// </summary>
        SdaFailed = 1 << 2,

        /// <summary>
        /// 
        /// </summary>
        IccDataMissing = 1 << 3,

        /// <summary>
        /// 
        /// </summary>
        CardAppearsOnTerminalExceptionFile = 1 << 4,

        /// <summary>
        /// 
        /// </summary>
        DdaFailed = 1 << 5,

        /// <summary>
        /// 
        /// </summary>
        CdaFailed = 1 << 6,

        /// <summary>
        /// 
        /// </summary>
        IccAndTerminalHaveDifferentApplicationVersions = 1<<7,

        /// <summary>
        /// 
        /// </summary>
        ExpiredApplication = 1<<8,

        /// <summary>
        /// 
        /// </summary>
        ApplicationNotYetEffective = 1<<9,

        /// <summary>
        /// 
        /// </summary>
        RequestedServiceNotAllowedForCardProduct = 1<<10,

        /// <summary>
        /// 
        /// </summary>
        NewCard = 1<<11,

        /// <summary>
        /// 
        /// </summary>
        CardholderVerificationWasNotSuccessful = 1<<12,

        /// <summary>
        /// 
        /// </summary>
        UnrecognisedCvm = 1<<13,

        /// <summary>
        /// 
        /// </summary>
        PinTryLimitExceeded = 1<<14,

        /// <summary>
        /// 
        /// </summary>
        PinEntryRequiredAndPinPadNotPresentOrNotWorking = 1<<15,

        /// <summary>
        /// 
        /// </summary>
        PinEntryRequiredPinPadPresentButPinWasNotEntered = 1<<16,

        /// <summary>
        /// 
        /// </summary>
        OnlinePinEntered = 1<<17,

        /// <summary>
        /// 
        /// </summary>
        TransactionExceedsFloorLimit = 1<<18,

        /// <summary>
        /// 
        /// </summary>
        LowerConsecutiveOfflineLimitExceeded = 1<<19,

        /// <summary>
        /// 
        /// </summary>
        UpperConsecutiveOfflineLimitExceeded = 1 << 20,

        /// <summary>
        /// 
        /// </summary>
        TransactionSelectedRandomlyForOnlineProcessing = 1<<21,

        /// <summary>
        /// 
        /// </summary>
        MerchantForcedTransactionOnline = 1<<22,

        /// <summary>
        /// 
        /// </summary>
        DefaultTdolUsed = 1<<23,

        /// <summary>
        /// 
        /// </summary>
        IssuerAuthenticationFailed = 1<<24,

        /// <summary>
        /// 
        /// </summary>
        ScriptProcessingFailedBeforeFinalGenerateAc = 1<<25,

        /// <summary>
        /// 
        /// </summary>
        ScriptProcessingFailedAfterFinalGenerateAc = 1<<26,
    }
}