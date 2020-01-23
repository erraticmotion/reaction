namespace ErraticMotion.Reaction.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceKeyPressed
    {
        /// <summary>
        /// No key was pressed.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// The device Enter key was pressed.
        /// </summary>
        Enter = 0x0d,

        /// <summary>
        /// The device cancel key was pressed.
        /// </summary>
        Cancel = 0x1b,

        /// <summary>
        /// The device Back key was pressed.
        /// </summary>
        Back = 0x08,

        /// <summary>
        /// The device F1 key was pressed.
        /// </summary>
        F1 = 0x81,

        /// <summary>
        /// The device F2 key was pressed.
        /// </summary>
        F2 = 0x82,

        /// <summary>
        /// The device F3 key was pressed.
        /// </summary>
        F3 = 0x83,

        /// <summary>
        /// The device F4 key was pressed.
        /// </summary>
        F4 = 0x84
    }
}