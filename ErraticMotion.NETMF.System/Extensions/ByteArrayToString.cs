namespace System.Extensions
{
    using Text;

    internal class ByteArrayToString : IByteToString
    {
        private readonly byte[] item;

        internal ByteArrayToString(byte[] item)
        {
            this.item = item;
        }

        #region Implementation of IByteToString

        public string Format(string format)
        {
            var builder = new StringBuilder();
            foreach (var b in item)
            {
                builder.Append(b.NetMf().Format(format));
            }

            return builder.ToString();
        }

        #endregion
    }
}
