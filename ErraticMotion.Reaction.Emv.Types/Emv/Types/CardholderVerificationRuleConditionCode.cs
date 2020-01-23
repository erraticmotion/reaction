namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public enum CardholderVerificationRuleConditionCode
    {
        /// <summary>
        /// Always
        /// </summary>
        Always = 0,

        /// <summary>
        /// If unattended cash
        /// </summary>
        IfUnattendedCash = 1,

        /// <summary>
        /// If not unattended cash and not manual cash and not purchase with cash back
        /// </summary>
        IfNotUnattendedCash = 2,

        /// <summary>
        /// If terminal supports the CVM
        /// </summary>
        IfTerminalSupportsTheCvm = 3,

        /// <summary>
        /// If manual cash
        /// </summary>
        IfManualCash = 4,

        /// <summary>
        /// If purchase with cash back
        /// </summary>
        IfPurchaseWithCashback = 5,

        /// <summary>
        /// If transaction is in the application currency and is under X value
        /// </summary>
        IfTransactionIsInTheApplicationCurrencyAndIsUnderXValue = 6,

        /// <summary>
        /// If transaction is in the application currency and is over X value
        /// </summary>
        IfTransactionIsInTheApplicationCurrencyAndIsOverXValue = 7,

        /// <summary>
        /// If transaction is in the application currency and is under Y value 
        /// </summary>
        IfTransactionIsInTheApplicationCurrencyAndIsUnderYValue = 8,

        /// <summary>
        /// If transaction is in the application currency and is over Y value
        /// </summary>
        IfTransactionIsInTheApplicationCurrencyAndIsOverYValue = 9,

        /// <summary>
        /// When 0x00 is used in the <see cref="CvmResults"/> instead of the <see cref="CvmList"/> type
        /// 0x00 has a different meaning.
        /// </summary>
        NoActualCvmWasPerformed = 0xFF,
    }
}
