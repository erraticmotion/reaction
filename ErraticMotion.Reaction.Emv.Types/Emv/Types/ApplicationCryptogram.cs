namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ApplicationCryptogram : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCryptogram"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ApplicationCryptogram(byte[] value)
            : base(TagLengthValueType.ApplicationCryptogram, value)
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
    }
}
