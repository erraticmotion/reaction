namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// Byte 3 of the Terminal Capabilities
    /// </summary>
    [Flags]
    public enum SecurityCapability
    {
        /// <summary>
        /// SDA
        /// </summary>
        Sda = 1<<7,

        /// <summary>
        /// DDA
        /// </summary>
        Dda = 1<<6,

        /// <summary>
        /// Card Capture
        /// </summary>
        CardCapture = 1<<5,

        /// <summary>
        /// CDA
        /// </summary>
        Cda = 1<<3,
    }
}
