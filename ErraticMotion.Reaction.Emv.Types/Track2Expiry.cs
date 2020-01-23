namespace ErraticMotion.Reaction
{
    using System;
    using System.Bcd;

    internal class Track2Expiry : ITrack2Expiry
    {
        private readonly ITrack2 item;

        public Track2Expiry(ITrack2 item)
        {
            this.item = item;
        }

        #region Implementation of ITrack2Expiry

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime Date
        {
            get
            {
                int y;
                int m;
                if (item.IsBcd)
                {
                    y = item.ExpiryDateYear.AsPackedBcd().ToByte() + 2000;
                    m = item.ExpiryDateMonth.AsPackedBcd().ToByte();
                }
                else
                {
                    y = item.ExpiryDateYear + 2000;
                    m = item.ExpiryDateMonth;
                }
                var d = DateTime.DaysInMonth(y, m);
                return new DateTime(y, m, d, 23, 59, 59);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasExpired
        {
            get
            {
                return (DateTime.Now > Date);
            }
        }

        #endregion
    }
}
