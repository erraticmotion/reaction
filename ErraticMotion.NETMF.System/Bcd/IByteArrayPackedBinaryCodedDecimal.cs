namespace System.Bcd
{
    /// <summary>
    /// 
    /// </summary>
    public interface IByteArrayPackedBinaryCodedDecimal
    {
        /// <summary>
        /// Determines whether this instance is BCD.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance is BCD; otherwise, <c>false</c>.
        /// </returns>
        bool IsBcd();

        /// <summary>
        /// Determines whether the specified accept trailing F is BCD.
        /// </summary>
        /// <param name="acceptTrailingF">if set to <c>true</c> [accept trailing F].</param>
        /// <returns>
        /// 	<c>true</c> if the specified accept trailing F is BCD; otherwise, <c>false</c>.
        /// </returns>
        bool IsBcd(bool acceptTrailingF);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        byte[] ToBytes();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="acceptTrailingF">if set to <c>true</c> [accept trailing F].</param>
        /// <returns></returns>
        byte[] ToBytes(bool acceptTrailingF);

        /// <summary>
        /// Converts the packed BCD byte array to a string representation.
        /// </summary>
        /// <returns>The byte array value as a string representation.</returns>
        string ConvertToString();

        /// <summary>
        /// Converts the packed BCD byte array to a string representation.
        /// </summary>
        /// <param name="stripTrailingF">if set to <c>true</c> then will strip trailing 'F' if present.</param>
        /// <returns>The byte array value as a string representation.</returns>
        string ConvertToString(bool stripTrailingF);
    }
}
