namespace Servebase.Pceft.Ped.Emv
{
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// EMV Tag 4F. Identifies the application as described in ISO/IEC 7816-5
    /// </summary>
    public sealed class ApplicationIdentifier : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationIdentifier"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ApplicationIdentifier(byte[] value)
            : base(TagLengthValueType.ApplicationIdentifier, value)
        {
            Aid = Value.AsString(false);
            Rid = RegisteredApplicationProviderIdentifier.From(this);
        }

        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <summary>
        /// Gets the AID.
        /// </summary>
        /// <value>The AID.</value>
        public string Aid { get; private set; }

        /// <summary>
        /// Gets the RID.
        /// </summary>
        /// <value>The RID.</value>
        public RegisteredApplicationProviderIdentifier Rid { get; private set; }

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
            builder.AppendLine(Format("Aid", Aid));
            builder.AppendLine(Format("Rid", Rid));
            OnToString(builder);
            return builder.ToString();
        }
    }
}
