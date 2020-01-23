namespace ErraticMotion.Reaction
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITrack2Validation
    {
        /// <summary>
        /// Validates the correctness of <see cref="ITrack2"/> item.
        /// </summary>
        /// <param name="failover">Indicates whether this check is being carried out prior to failover.</param>
        /// <returns><c>true</c> if the item validates; otherwise false.</returns>
        bool Validate(bool failover);
    }
}
