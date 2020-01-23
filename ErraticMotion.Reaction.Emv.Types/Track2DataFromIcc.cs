namespace ErraticMotion.Reaction
{
    using System;
    using System.Extensions;

    /// <summary>
    /// Immutable data structure to hold the Track2 data that is returned from the device
    /// when an ICC card is inserted.
    /// </summary>
    //[Serializable]
    public sealed class Track2DataFromIcc : ITrack2
    {
        /// <summary>
        /// Parses the <param name="value">argument</param> and returns an object
        /// that implements the <see cref="ITrack2"/> interface.
        /// </summary>
        public static ITrack2 Parse(byte[] value)
        {
            var s = value.NetMf().Format("X");
            var i = s.Split('D');
            var result = new Track2DataFromIcc
                             {
                                 CardNumber = i[0].TrimEnd(new [] {'F','f'}),
                                 ExpiryDateYear = i[1].Substring(0, 2).NetMf().ToLiteralByte,
                                 ExpiryDateMonth = i[1].Substring(2, 2).NetMf().ToLiteralByte,
                                 ServiceCode = int.Parse(i[1].Substring(4, 3)),
                             };

            try
            {
                var e = i[1];
                result.DiscretionaryData = (e.Length > 7) ? e.Substring(7, e.Length - 7).TrimEnd(new [] {'?'}) : string.Empty;
            }
            catch (Exception)
            {
                result.DiscretionaryData = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Attempts to parse the value.
        /// </summary>
        public static bool TryParse(byte[] value, out ITrack2 item)
        {
            try
            {
                item = Parse(value);
                return true;
            }
            catch (Exception)
            {
                item = null;
                return false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track2DataFromIcc"/> class.
        /// </summary>
        private Track2DataFromIcc()
        {
        }

        /// <summary>
        /// Gets the cards number within the track 2 data.
        /// </summary>
        public string CardNumber { get; private set; }

        /// <summary>
        /// Gets the cards expiry date year within the track 2 data.
        /// </summary>
        public byte ExpiryDateYear { get; private set; }

        /// <summary>
        /// Gets the cards expiry date month within the track 2 data.
        /// </summary>
        public byte ExpiryDateMonth { get; private set; }

        /// <summary>
        /// Gets the cards service code within the track 2 data.
        /// </summary>
        public int ServiceCode { get; private set; }

        /// <summary>
        /// Indicates whether this instance uses literal bytes instead 
        /// of actual values for month and year (backwards compatible issue).
        /// </summary>
        public bool IsBcd { get { return true; } }

        /// <summary>
        /// Variable, to a maximum of 19 bytes, dependent on PAN length; for Interac,
        /// the final digit contains the Language Code (1 = English; 2 = French)
        /// </summary>
        public string DiscretionaryData { get; private set; } 
    }
}
