namespace ErraticMotion.Reaction
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public interface ITrack2Expiry
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        DateTime Date { get; }

        /// <summary>
        /// 
        /// </summary>
        bool HasExpired { get; }
    }
}
