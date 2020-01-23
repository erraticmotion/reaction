namespace ErraticMotion.Reaction
{
    using System;

    internal class Track2BinRange : ITrack2BinRange
    {
        private readonly ITrack2 item;

        /// <summary>
        /// Initializes a new instance of the <see cref="Track2BinRange"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        public Track2BinRange(ITrack2 item)
        {
            this.item = item;
        }

        #region Implementation of ITrack2BinRange

        /// <summary>
        /// Returns the BIN range
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public long Bin(int number)
        {
            var v = item.CardNumber.Substring(0, number);
            try
            {
                return long.Parse(v);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the first six digits of the card number.
        /// </summary>
        public string FirstSix
        {
            get
            {
                return item.CardNumber.Substring(0, 6);
            }
        }

        /// <summary>
        /// Gets the last four digits of the card number.
        /// </summary>
        public string LastFour
        {
            get
            {
                return item.CardNumber.Substring(item.CardNumber.Length - 4, 4);
            }
        }

        #endregion
    }
}
