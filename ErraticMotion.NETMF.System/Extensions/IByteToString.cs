namespace System.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IByteToString
    {
        /// <summary>
        /// METMF replacement for the ToString(string format) method
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns></returns>
        string Format(string format);
    }
}
