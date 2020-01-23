namespace Servebase.Pceft.Ped.Emv
{
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// 9F1A
    /// </summary>
    public sealed class TerminalCountryCode : EmvElement, ICountry
    {
        /// <summary>
        /// 
        /// </summary>
        public static EmvQuery<TerminalCountryCode> Query()
        {
            return new TerminalCountryCodeQuery();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalCountryCode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public TerminalCountryCode(byte[] value)
            : base(TagLengthValueType.TerminalCountryCode, value)
        {
            Country = Country.Parse(this);
            Currency = Ped.Currency.Parse(value);
        }

        #region Implementation of ICountry

        /// <summary>
        /// 
        /// </summary>
        public Currency? Currency { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Country Country { get; private set; }

        #endregion

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}", GetType().Name));
            builder.AppendLine(Format("Tag", Tag));
            if (Value != null)
            {
                builder.AppendLine(Format("Value", Value.DefaultDecoder()));
                builder.AppendLine(Format("Country", Country));
                if (Currency.HasValue)
                {
                    builder.AppendLine(Format("Currency", Currency.Value));
                }
            }
  
            return builder.ToString();
        }
    }
}
