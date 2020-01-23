namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class GenericEmvType : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericEmvType"/> class.
        /// </summary>
        /// <param name="tag">The TLV.</param>
        /// <param name="value">The TLV value</param>
        public GenericEmvType(TagLengthValueType tag, byte[] value) : base(tag, value)
        {
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
