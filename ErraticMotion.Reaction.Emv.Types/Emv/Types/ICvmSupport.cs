namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Used on types to indicate supported CVM operations that are of interest
    /// to the framework.
    /// </summary>
    public interface ICvmSupport
    {
        /// <summary>
        /// Indicates whether the object supports Online PIN operations.
        /// </summary>
        bool EncipheredPinVerificationOnline { get; }

        /// <summary>
        /// Indicates whether the object supports normal PIN operations.
        /// </summary>
        bool PlaintextPinVerificationPerformedByIcc { get; }
    }
}
