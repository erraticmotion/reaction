namespace ErraticMotion.Reaction.Emv
{
    using System;

    /// <summary>
    /// The card movements.
    /// </summary>
    [Flags]
    public enum CardMovements
    {
        /// <summary>
        /// No TAG48 found in response.
        /// </summary>
        None = 1 << 0, // 0000000001

        /// <summary>
        /// Card in slot
        /// </summary>
        CardInSlot = 1 << 1, // 0000000010

        /// <summary>
        /// Card returning ATR (EMV/Asynchronous card).
        /// </summary>
        CardReturningEmvAsynchronousCard = 1 << 2, // 0000000100

        /// <summary>
        /// Card returning ATR (Synchronous card, SLE442 etc...).
        /// </summary>
        CardReturningSynchronousCard = 1 << 3, // 0000001000

        /// <summary>
        /// Card returning ATR (I2C card, ST14C02 etc...).
        /// </summary>
        CardReturningI2CCard = 1 << 4, // 0000010000

        /// <summary>
        /// Card successfully swiped.
        /// </summary>
        CardSuccessfullySwiped = 1 << 5, // 0000100000

        /// <summary>
        /// Track data 1 available.
        /// </summary>
        Track1Available = 1 << 6, // 0001000000

        /// <summary>
        /// Track data 2 available.
        /// </summary>
        Track2Available = 1 << 7, // 0010000000

        /// <summary>
        /// Track data 3 available.
        /// </summary>
        Track3Available = 1 << 8, // 0100000000
    }  
}