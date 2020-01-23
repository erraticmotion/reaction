namespace System.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string item)
        {
            // ReSharper disable ReplaceWithStringIsNullOrEmpty
            return item == null || item.Length == 0;
            // ReSharper restore ReplaceWithStringIsNullOrEmpty
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IStringToByte NetMf(this string item)
        {
            return new LiteralStringToByte(item);
        }
    }
}
