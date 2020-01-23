namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Ksn : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ksn"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Ksn(byte[] value)
            : base(TagLengthValueType.Ksn, value)
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
