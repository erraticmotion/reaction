namespace ErraticMotion.Reaction
{
    /// <summary>
    /// 
    /// </summary>
    internal class Track2Validation : ITrack2Validation
    {
        private readonly ITrack2 item;

        public Track2Validation(ITrack2 item)
        {
            this.item = item;
        }

        #region Implementation of ITrack2Validation

        /// <summary>
        /// Validates the correctness of <see cref="ITrack2"/> item.
        /// </summary>
        /// <param name="failover">Indicates whether this check is being carried out prior to failover.</param>
        /// <returns><c>true</c> if the item validates; otherwise false.</returns>
        public bool Validate(bool failover)
        {
            if (item == null)
            {
                // If this is being called during failover, then it can't be null.
                // Always return false to indicate that it is not valid and can't
                // be persisted.
                return !(failover);
            }

            if (failover && !item.Emv().CanFailover)
            {
                return false;
            }

            if (!Luhn.IsValid(item.CardNumber))
            {
                return false;
            }

            return !item.Expiry().HasExpired;
        }

        #endregion
    }
}
