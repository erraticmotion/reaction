namespace System.Bcd
{
    using Text;

    /// <summary>
    /// 
    /// </summary>
    internal class ByteArrayPackedBinaryCodedDecimal : IByteArrayPackedBinaryCodedDecimal
    {
        private readonly byte[] value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteArrayPackedBinaryCodedDecimal"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ByteArrayPackedBinaryCodedDecimal(byte[] value)
        {
            this.value = value;
        }

        #region Implementation of IByteArrayPackedBinaryCodedDecimal

        /// <summary>
        /// Determines whether this instance is BCD.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance is BCD; otherwise, <c>false</c>.
        /// </returns>
        public bool IsBcd()
        {
            return IsBcd(false);
        }

        /// <summary>
        /// Determines whether the specified accept trailing F is BCD.
        /// </summary>
        /// <param name="acceptTrailingF">if set to <c>true</c> [accept trailing F].</param>
        /// <returns>
        /// 	<c>true</c> if the specified accept trailing F is BCD; otherwise, <c>false</c>.
        /// </returns>
        public bool IsBcd(bool acceptTrailingF)
        {
            foreach (var b in value)
            {
                if (!b.AsPackedBcd().IsBcd(acceptTrailingF))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte[] ToBytes()
        {
            return ToBytes(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="acceptTrailingF">if set to <c>true</c> [accept trailing F].</param>
        /// <returns></returns>
        public byte[] ToBytes(bool acceptTrailingF)
        {
            var result = new byte[value.Length];
            var index = 0;
            foreach (var b in value)
            {
                result[index] = b.AsPackedBcd().ToByte(acceptTrailingF);
                index++;
            }
            return result;
        }

        /// <summary>
        /// Converts the packed BCD byte array to a string representation.
        /// </summary>
        /// <returns>The byte array value as a string representation.</returns>
        public string ConvertToString()
        {
            return ConvertToString(false);
        }

        /// <summary>
        /// Converts the packed BCD byte array to a string representation.
        /// </summary>
        /// <param name="stripTrailingF">if set to <c>true</c> then will strip trailing 'F' if present.</param>
        /// <returns>The byte array value as a string representation.</returns>
        public string ConvertToString(bool stripTrailingF)
        {
            var builder = new StringBuilder();
            foreach (var b in value)
            {
                builder.Append(b.AsPackedBcd().ConvertToString(stripTrailingF));
            }

            return builder.ToString();
        }

        #endregion
    }
}
