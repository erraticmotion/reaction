namespace Servebase.Pceft.Ped.Emv
{
    using System.Globalization;
    using System.IO;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public sealed class IssuerScriptCommand : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerScriptCommand"/> class.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="value">The value.</param>
        internal IssuerScriptCommand(TagLengthValueType tag, byte[] value)
            : base(tag, value)
        {
            var s = value.AsString(false);
            Value = new byte[s.Length];
            s.ForIndex((i, c) => Value[i] = (byte)c);
        }

        public override byte[] ReadLanguage()
        {
            var s = new MemoryStream();
            s.WriteByte(0x38);
            s.WriteByte(0x36);
            var l = Encoding.ASCII.GetBytes(((short)Value.Length / 2).ToString("X2"));
            s.WriteByte(l[0]);
            s.WriteByte(l[1]);
            s.Write(Value, 0, Value.Length);
            return s.ToArray();
        }

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture, 
                "{0} {1} {2}", 
                ((byte)Tag).ToString("X2"), 
                ((byte)Value.Length).ToString("X2"), 
                Value.AsString(false));
        }
    }
}
