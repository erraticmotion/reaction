namespace ErraticMotion.Reaction
{
    /// <summary>
    /// Contains extension methods for the <see cref="ITrack2"/> interface.
    /// </summary>
    public static class Track2Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ITrack2Validation Validation(this ITrack2 item)
        {
            //TODO
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ITrack2Expiry Expiry(this ITrack2 item)
        {
            return new Track2Expiry(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ITrack2BinRange BinRange(this ITrack2 item)
        {
            return new Track2BinRange(item);
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ITrack2Emv Emv(this ITrack2 item)
        {
            return new Track2Emv(item);
        }
    }
}
