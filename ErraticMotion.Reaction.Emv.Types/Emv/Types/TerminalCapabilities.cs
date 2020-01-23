namespace Servebase.Pceft.Ped.Emv
{
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TerminalCapabilities : EmvElement, ICvmSupport
    {
        /// <summary>
        /// 
        /// </summary>
        public static EmvQuery<TerminalCapabilities> Query()
        {
            return new TerminalCapabilitiesQuery();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvElement"/> class.
        /// </summary>
        /// <param name="value">The TLV value</param>
        public TerminalCapabilities(byte[] value)
            : base(TagLengthValueType.TerminalCapabilities, value)
        {
            CardDataInputCapability = (CardDataInputCapability)value[0];
            CvmCapability = (CvmCapability)value[1];
            SecurityCapability = (SecurityCapability)value[2];
        }

        /// <summary>
        /// 
        /// </summary>
        public CardDataInputCapability CardDataInputCapability { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public CvmCapability CvmCapability { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public SecurityCapability SecurityCapability { get; private set; }

        #region Implementation of ICvmSupport

        /// <summary>
        /// Indicates whether the object supports Online PIN operations
        /// </summary>
        public bool EncipheredPinVerificationOnline
        {
            get
            {
                return ((CvmCapability & CvmCapability.EncipheredPinForOnlineVerification)
                    == CvmCapability.EncipheredPinForOnlineVerification);
            }
        }

        /// <summary>
        /// Indicates whether the object supports normal PIN operations.
        /// </summary>
        public bool PlaintextPinVerificationPerformedByIcc
        {
            get
            {
                return ((CvmCapability & CvmCapability.PlaintextPinForIccVerification)
                    == CvmCapability.PlaintextPinForIccVerification);
            }
        }

        #endregion

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
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}", GetType().Name));
            builder.AppendLine(Format("Tag", Tag));
            if (Value != null)
            {
                builder.AppendLine(Format("Value", Value.DefaultDecoder()));
                builder.AppendLine(Format("Card Data Input Capability", CardDataInputCapability));
                builder.AppendLine(Format("CVM Capability", CvmCapability));
                builder.AppendLine(Format("Security Capability", SecurityCapability));
            }

            return builder.ToString();
        }

        
    }
}
