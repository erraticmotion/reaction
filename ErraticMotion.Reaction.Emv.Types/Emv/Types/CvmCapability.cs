namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// Byte 2 of the Terminal Capabilities
    /// </summary>
    [Flags]
    public enum CvmCapability
    {
        /// <summary>
        ///  Plaintext PIN for ICC verification
        /// </summary>
        PlaintextPinForIccVerification = 1<<7,

        /// <summary>
        /// Enciphered PIN for online verification
        /// </summary>
        EncipheredPinForOnlineVerification = 1<<6,

        /// <summary>
        /// Signature 
        /// </summary>
        Signature = 1<<5,

        /// <summary>
        /// Enciphered PIN for offline verification
        /// </summary>
        EncipheredPinForOfflineVerification = 1<<4,

        /// <summary>
        /// No CVM Required
        /// </summary>
        NoCvmRequired = 1<<3,
    }
}
