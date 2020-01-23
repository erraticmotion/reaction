namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Result of the (last) CVM performed as known by the terminal
    /// </summary>
    public enum CvmResult
    {
        /// <summary>
        /// Can be for Signature
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// CVM failed, or if no CVM Condition Code was satisfied or if the CVM Code was not recognised or not supported
        /// </summary>
        Failed = 1,

        /// <summary>
        /// CVM was successful.
        /// </summary>
        Successful,
    }
}
