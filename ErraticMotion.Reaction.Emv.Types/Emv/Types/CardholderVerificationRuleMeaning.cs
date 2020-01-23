namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum CardholderVerificationRuleMeaning
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// Fail cardholder verification if this CVM is unsuccessful
        /// </summary>
        FailIfUnsuccessful = 1<<0,

        /// <summary>
        /// Apply succeeding CV Rule if this CVM is unsuccessful
        /// </summary>
        ApplySucceeding = 1<<1,

        /// <summary>
        /// Fail CVM processing
        /// </summary>
        FailCvmProcessing = 1<<2,

        /// <summary>
        /// Plaintext PIN verification performed by ICC
        /// </summary>
        PlaintextPinVerificationPerformedByIcc = 1<<3,

        /// <summary>
        /// Enciphered PIN verified online
        /// </summary>
        EncipheredPinVerifiedOnline = 1<<4,

        /// <summary>
        /// Plaintext PIN verification performed by ICC and signature
        /// </summary>
        PlaintextPinVerificationPerformedByIccAndSignature = 1<<5,

        /// <summary>
        /// Enciphered PIN verification performed by ICC
        /// </summary>
        EncipheredPinVerificationPerformedByIcc = 1<<6,

        /// <summary>
        /// Enciphered PIN verification performed by ICC and signature
        /// </summary>
        EncipheredPinVerificationPerformedByIccAndSignature = 1<<7,

        /// <summary>
        /// Signature
        /// </summary>
        Signature = 1<<8,

        /// <summary>
        /// No CVM required
        /// </summary>
        NoCvmRequired = 1<<9,

        /// <summary>
        /// EMV7816 specs use 0x3F to indicate this value. Only problem is that 0x3F
        /// also means the following:
        /// FailIfUnsuccessful, ApplySucceeding, FailCvmProcessing, PlaintextPinVerificationPerformedByIcc, EncipheredPinVerifiedOnline, PlaintextPinVerificationPerformedByIccAndSignature
        /// as we are using Flags.
        /// In the <see cref="CardholderVerificationRule"/> ctor it checks for 0x3F, and uses the enumeration value instead of normal processing.
        /// I can't see it being an issue as the Meaning (if 0x3F is fixed to be always this value) otherwise does not appear to be valid.
        /// </summary>
        NoCvmHasBeenPerformed = 1<<20,
    }
}
