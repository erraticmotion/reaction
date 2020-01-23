namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Name: PIN Result
    /// Tag: DF A2 0A
    /// Length: 1
    ///Description: If this tag is present it means that PIN was performed.
    /// </summary>
    public sealed class PinResult : EmvElement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static EmvQuery<PinResult> Query()
        {
            return new PinResultQuery();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PinResult"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public PinResult(byte[] value)
            : base(TagLengthValueType.PinResult, value)
        {
            if (value.Length != 1)
            {
                throw new ArgumentOutOfRangeException("value", "PinResult value was not 1 in length");
            }

            switch (value[0])
            {
                case 0x00: 
                    Meaning = PinResultMeaning.Failed; 
                    break;
                case 0x01: 
                    Meaning = PinResultMeaning.Success; 
                    break;
                case 0x02: 
                    Meaning = PinResultMeaning.Cancelled; 
                    break;
                default: 
                    Meaning = PinResultMeaning.Skipped;
                    break;
            }
        }

        /// <summary>
        /// Gets the meaning.
        /// </summary>
        /// <value>The meaning.</value>
        public PinResultMeaning Meaning { get; private set; }

        #region Overrides of EmvElement

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Pin Result -> {0}", Meaning);
        }
    }
}
