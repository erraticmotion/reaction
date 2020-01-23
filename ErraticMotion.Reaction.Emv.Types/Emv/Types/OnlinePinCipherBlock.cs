namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class OnlinePinCipherBlock : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlinePinCipherBlock"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public OnlinePinCipherBlock(byte[] value)
            : base(TagLengthValueType.OnlinePinCipherBlock, value)
        {
        }

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
    }
}
