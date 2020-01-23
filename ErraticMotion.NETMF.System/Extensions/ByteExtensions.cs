namespace System.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ByteExtensions
    {
        public static IByteToString NetMf(this byte item)
        {
            return new ByteToString(item);
        }

        public static IByteToString NetMf(this byte[] item)
        {
            return new ByteArrayToString(item);
        }
    }
}
