namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public sealed class IssuerCountryCode : EmvElement, ICountry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerCountryCode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public IssuerCountryCode(byte[] value)
            : base(TagLengthValueType.IssuerCountryCode, value)
        {
            Country c;
            if (Country.TryParse(this, out c))
            {
                Country = c;
            }
            else
            {
                // No match for country code, defaults to Unknown, need to log.
                // TODO Diagnostics when Country.TryParse fails.
                Country = c;
            }

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

        protected override void OnToString(System.Text.StringBuilder builder)
        {
            builder.AppendLine(Format("Country", Country));
            if (Currency.HasValue)
            {
                builder.AppendLine(Format("Currency", Currency.Value));
            }
        }
    }
}
