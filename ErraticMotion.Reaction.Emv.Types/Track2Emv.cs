namespace ErraticMotion.Reaction
{
    using System;

    internal class Track2Emv : ITrack2Emv
    {
        private readonly ITrack2 item;

        /// <summary>
        /// Initializes a new instance of the <see cref="Track2Emv"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        public Track2Emv(ITrack2 item)
        {
            this.item = item;
            if (item.ServiceCode <= 99)
            {
                ServiceCodeDigit1 = 0;
                ServiceCodeDigit2 = Convert.ToInt32(item.ServiceCode.ToString().Substring(0, 1));
                ServiceCodeDigit3 = Convert.ToInt32(item.ServiceCode.ToString().Substring(1, 1));
            }
            else
            {
                ServiceCodeDigit1 = Convert.ToInt32(item.ServiceCode.ToString().Substring(0, 1));
                ServiceCodeDigit2 = Convert.ToInt32(item.ServiceCode.ToString().Substring(1, 1));
                ServiceCodeDigit3 = Convert.ToInt32(item.ServiceCode.ToString().Substring(2, 1));
            }
        }

        /// <summary>
        /// Returns true if the service code indicates that the card is an ICC card; otherwise false
        /// to indicate that the card is not an ICC card.
        /// </summary>
        public bool IsCardIcc
        {
            get
            {
                return (item.ServiceCode == 201 || item.ServiceCode == 601 || item.ServiceCode == 220);
            }
        }

        /// <summary>
        /// Gets the service code digit at position 1.
        /// </summary>
        /// <value>The digit1.</value>
        public int ServiceCodeDigit1 { get; private set; }

        /// <summary>
        /// Gets the service code digit at position 2.
        /// </summary>
        /// <value>The digit2.</value>
        public int ServiceCodeDigit2 { get; private set; }

        /// <summary>
        /// Gets the service code digit at position 3.
        /// </summary>
        /// <value>The digit3.</value>
        public int ServiceCodeDigit3 { get; private set; }

        /// <summary>
        /// Gets a value indicating whether it can failover.
        /// </summary>
        /// <value><c>true</c> if it can failover; otherwise, <c>false</c>.</value>
        public bool CanFailover
        {
            get
            {
                return 6 != ServiceCodeDigit1 && 2 != ServiceCodeDigit2 && 4 != ServiceCodeDigit2;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is valid for use on ATM's only
        /// </summary>
        /// <value>
        /// <c>true</c> if valid for ATM's only; otherwise <c>false</c> to indicate that it can be used on devices in addition to ATM's.
        /// </value>
        public bool ValidForATMOnly
        {
            get
            {
                return ServiceCodeDigit3 == 3;
            }
        }
    }
}
