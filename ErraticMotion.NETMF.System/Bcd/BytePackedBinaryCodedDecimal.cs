namespace System.Bcd
{
    using Extensions;

    internal class BytePackedBinaryCodedDecimal : IBytePackedBinaryCodedDecimal
    {
        private readonly byte value;

        /// <summary>
        /// Initializes a new instance of the <see cref="BytePackedBinaryCodedDecimal"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public BytePackedBinaryCodedDecimal(byte value)
        {
            this.value = value;
        }

        #region Implementation of IBytePackedBinaryCodedDecimal

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
            try
            {
#pragma warning disable 168
                var result = (acceptTrailingF) ? value.FromBcdAcceptTrailingF() : value.FromBcd();
#pragma warning restore 168
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// Toes the int32.
        /// </summary>
        /// <returns></returns>
        public byte ToByte()
        {
            return ToByte(false);
        }

        /// <summary>
        /// Toes the int32.
        /// </summary>
        /// <param name="acceptTrailingF">if set to <c>true</c> [accept trailing F].</param>
        /// <returns></returns>
        public byte ToByte(bool acceptTrailingF)
        {
            return (acceptTrailingF) ? value.FromBcdAcceptTrailingF() : value.FromBcd();
        }

        /// <summary>
        /// Converts the packed BCD byte to a string representation.
        /// </summary>
        /// <returns>The byte value as a string representation.</returns>
        public string ConvertToString()
        {
            return ConvertToString(false);
        }

        /// <summary>
        /// Converts the packed BCD byte to a string representation.
        /// </summary>
        /// <param name="stripTrailingF">if set to <c>true</c> then will strip trailing 'F' if present.</param>
        /// <returns>The byte value as a string representation.</returns>
        public string ConvertToString(bool stripTrailingF)
        {
            var result = value.NetMf().Format("X");
            return stripTrailingF ? result.TrimEnd(new [] { 'F', 'f' }) : result;
        }

        #endregion
    }
}
