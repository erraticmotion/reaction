namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class PanSequenceNumber : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PanSequenceNumber"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public PanSequenceNumber(byte[] value)
            : base(TagLengthValueType.PanSequenceNumber, value)
        {
            if (value == null)
            {
                Value = new byte[] { 0x00 };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ReceiptValue
        {
            get
            {
                return Value.AsString(false);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
