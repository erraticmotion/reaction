namespace System.Extensions
{
    internal partial class LiteralStringToByte : IStringToByte
    {
        private readonly string value;

        public LiteralStringToByte(string value)
        {
            if (value.IsNullOrEmpty())
            {
                throw new ArgumentNullException("item");
            }

            if (value.Length.IsOdd())
            {
                throw new ArgumentOutOfRangeException("value", "Can only convert to literal byte array an even numbered string");
            }

            this.value = value;
        }

        #region Implementation of IStringToByte

        /// <summary>
        /// 
        /// </summary>
        public byte[] ToLiteralBytes
        {
            get
            {
                var ca = value.ToCharArray();
                var stream = new byte[ca.Length / 2];
                var index = 0;
                var position = 0;
                foreach (var c in ca)
                {
                    if (index.IsOdd())
                    {
                        var b = ToByte(new string(new[] { ca[index - 1], c }));
                        stream[position] = b;
                        position++;
                    }
                    index++;
                }

                return stream;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public byte ToLiteralByte
        {
            get
            {
                if (value.Length != 2)
                {
                    throw new InvalidOperationException("value length was not 2.");
                }

                return ToByte(value);
            }
        }

        #endregion
    }
}
