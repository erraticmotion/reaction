namespace Servebase.Pceft.Ped.Emv
{
    using System.Globalization;
    using System.IO;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PrimaryAccountNumber : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryAccountNumber"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public PrimaryAccountNumber(byte[] value)
            : base(TagLengthValueType.PrimaryAccountNumber, value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string Pan { get { return Value.AsString(false).TrimEnd('F'); } }

        /// <summary>
        /// Gets a value suitable for Online PIN uses.
        /// </summary>
        public byte[] PaddedPan
        {
            get
            {
                var result = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
                var ms = new MemoryStream(result);
                ms.Write(Value);
                return ms.ToArray();
            }
        }

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
#if DEBUG
                builder.AppendLine(Format("Pan", Pan));
#else
                builder.AppendLine(Format("Pan", Pan.ObfuscateCardNumber()));
#endif
            }
            OnToString(builder);
            return builder.ToString();
        }
    }
}
