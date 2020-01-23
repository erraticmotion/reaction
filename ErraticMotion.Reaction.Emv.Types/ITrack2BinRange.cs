namespace ErraticMotion.Reaction
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITrack2BinRange 
    {
        /// <summary>
        /// Returns the BIN range
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        long Bin(int number);

        /// <summary>
        /// Gets the first six digits of the card number.
        /// </summary>
        string FirstSix { get; }

        /// <summary>
        /// Gets the last four digits of the card number.
        /// </summary>
        string LastFour { get; }
    }
}