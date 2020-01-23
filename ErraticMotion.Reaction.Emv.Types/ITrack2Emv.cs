namespace ErraticMotion.Reaction
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITrack2Emv
    {
        /// <summary>
        /// Returns true if the service code indicates that the card is an ICC card; otherwise false
        /// to indicate that the card is not an ICC card.
        /// </summary>
        bool IsCardIcc { get; }

        /// <summary>
        /// Gets the service code digit at position 1.
        /// </summary>
        /// <value>The digit1.</value>
        int ServiceCodeDigit1 { get; }

        /// <summary>
        /// Gets the service code digit at position 2.
        /// </summary>
        /// <value>The digit2.</value>
        int ServiceCodeDigit2 { get; }

        /// <summary>
        /// Gets the service code digit at position 3.
        /// </summary>
        /// <value>The digit3.</value>
        int ServiceCodeDigit3 { get; }

        /// <summary>
        /// Gets a value indicating whether it can failover.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if it can failover; otherwise, <c>false</c>.
        /// </value>
        bool CanFailover { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is valid for use on ATM's only
        /// </summary>
        /// <value>
        /// <c>true</c> if valid for ATM's only; otherwise <c>false</c> to indicate that it can be used on devices in addition to ATM's.
        /// </value>
        bool ValidForATMOnly { get; }
    }
}
