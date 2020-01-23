namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// 9F02 - Authorised amount of the transaction (excluding adjustments)
    /// </summary>
    /// <remarks>
    /// Format n 12, Length 6
    /// </remarks>
    public sealed class AmountAuthorisedNumeric : EmvElement, IFormattable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountAuthorisedNumeric"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public AmountAuthorisedNumeric(byte[] value)
            : base(TagLengthValueType.TransactionTotalAmount, value)
        {
        }

        /// <summary>
        /// 
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
            return ToString(null, null);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Formats the value of the current instance using the specified format.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> containing the value of the current instance in the specified format.
        /// </returns>
        /// <param name="format">The <see cref="T:System.String"/> specifying the format to use.
        ///                     -or- 
        ///                 null to use the default format defined for the type of the <see cref="T:System.IFormattable"/> implementation. 
        ///                 </param><param name="formatProvider">The <see cref="T:System.IFormatProvider"/> to use to format the value.
        ///                     -or- 
        ///                 null to obtain the numeric format information from the current locale setting of the operating system. 
        ///                 </param><filterpriority>2</filterpriority>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                return base.ToString();
            }

            if (0 == string.Compare(format, "l", StringComparison.InvariantCultureIgnoreCase))
            {
                var builder = new StringBuilder();
                foreach (var x in Value)
                {
                    if (x != 0x00)
                        builder.Append(x.ToString("X2"));
                }
                
                long l;
                if (long.TryParse(builder.ToString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out l))
                {
                    var b1 = BitConverter.GetBytes(l);

                    var result = new StringBuilder();
                    result.Append(b1[5].ToString("X2"));
                    result.Append(b1[4].ToString("X2"));
                    result.Append(b1[3].ToString("X2"));
                    result.Append(b1[2].ToString("X2"));
                    result.Append(b1[1].ToString("X2"));
                    result.Append(b1[0].ToString("X2"));
                    return result.ToString();
                }
            }

            return base.ToString();
        }
    }
}
