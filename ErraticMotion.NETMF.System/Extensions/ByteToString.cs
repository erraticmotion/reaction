namespace System.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class ByteToString : IByteToString
    {
        private readonly byte item;

        internal ByteToString(byte item)
        {
            this.item = item;
        }

        #region Implementation of IByteToString

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Format(string format)
        {
// ReSharper disable StringCompareIsCultureSpecific.1
            if (0 == string.Compare("x", format))

            {
                return X2(item).ToLower();
            }

            if (0 == string.Compare("X", format))
            {
                return X2(item);
            }
// ReSharper restore StringCompareIsCultureSpecific.1

            throw new ArgumentOutOfRangeException("format", "Format not supported. 'X', or 'x' only for this release");
        }

        #endregion

        private static string X2(byte value)
        {
            var d1 = Base16(value / 16);
            var d2 = Base16(value % 16);
            return d1 + d2;
        }

        private static string Base16(int value)
        {
            switch (value)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return value.ToString();
            }
        }
    }
}
