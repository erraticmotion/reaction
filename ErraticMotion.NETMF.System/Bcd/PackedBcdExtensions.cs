namespace System.Bcd
{
    /// <summary>
    /// Contains extensions for the <see cref="byte"/> type to support Packed BCD operations.
    /// http://en.wikipedia.org/wiki/Binary-coded_decimal
    /// </summary>
    public static class PackedBcdExtensions
    {
        /// <summary>
        /// Packed BCD operations
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object that supports the <see cref="IBytePackedBinaryCodedDecimal"/> interface</returns>
        public static IBytePackedBinaryCodedDecimal AsPackedBcd(this byte value)
        {
            return new BytePackedBinaryCodedDecimal(value);
        }

        /// <summary>
        /// Packed BCD operations
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object that supports the <see cref="IByteArrayPackedBinaryCodedDecimal"/> interface</returns>
        public static IByteArrayPackedBinaryCodedDecimal AsPackedBcd(this byte[] value)
        {
            return new ByteArrayPackedBinaryCodedDecimal(value);
        }
    }
}
