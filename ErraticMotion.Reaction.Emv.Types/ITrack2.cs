namespace ErraticMotion.Reaction
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITrack2
    {
        /// <summary>
        /// Gets the cards number within the track 2 data.
        /// </summary>
        string CardNumber { get; }

        /// <summary>
        /// Gets the cards expiry date year within the track 2 data.
        /// </summary>
        byte ExpiryDateYear { get; }

        /// <summary>
        /// Gets the cards expiry date month within the track 2 data.
        /// </summary>
        byte ExpiryDateMonth { get; }

        /// <summary>
        /// Gets the cards service code within the track 2 data.
        /// </summary>
        int ServiceCode { get; }
         
        /// <summary>
        /// Indicates whether this instance uses BCD bytes instead 
        /// of actual values for month and year.
        /// </summary>
        bool IsBcd { get; }

        /// <summary>
        /// Variable, to a maximum of 19 bytes, dependent on PAN length; for Interac,
        /// the final digit contains the Language Code (1 = English; 2 = French)
        /// </summary>
        string DiscretionaryData { get; }
    }
}