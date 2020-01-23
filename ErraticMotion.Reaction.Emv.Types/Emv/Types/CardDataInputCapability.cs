namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// Byte 1 of the Terminal Capabilities
    /// </summary>
    [Flags]
    public enum CardDataInputCapability : byte
    {
        /// <summary>
        /// Manual key entry
        /// </summary>
        ManualKeyEntry = 1<<7,

        /// <summary>
        /// Magnetic strip
        /// </summary>
        MagneticStrip = 1<<6,

        /// <summary>
        /// IC with Contacts
        /// </summary>
        IcWithContacts = 1<<5,
    }
}
