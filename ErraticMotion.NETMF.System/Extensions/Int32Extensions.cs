namespace System.Extensions
{
    /// <summary>
    /// Contains extension methods for the <see cref="Int32"/> type.
    /// </summary>
    public static class Int32Extensions
    {
        /// <summary>
        /// Determines whether the specified item is even.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// 	<c>true</c> if the specified item is even; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEven(this int item)
        {
            return ((item & 1) == 0);
        }

        /// <summary>
        /// Determines whether the specified item is odd.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// 	<c>true</c> if the specified item is odd; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsOdd(this int item)
        {
            return ((item & 1) == 1);
        }
    }
}
