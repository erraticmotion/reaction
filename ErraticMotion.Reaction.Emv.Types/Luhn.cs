namespace ErraticMotion.Reaction
{
    using System;
    using System.Extensions;

    /// <summary>
    /// 
    /// </summary>
    public static class Luhn
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Argument is null.</exception>
        public static bool IsValid(string item)
        {
            if (item.IsNullOrEmpty())
            {
                throw new ArgumentNullException("item", "Luhn.IsValid(item) was null");
            }

            return (Compute(item) % 10) == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Argument is null.</exception>
        public static int Generate(string item)
        {
            if (item.IsNullOrEmpty())
            {
                throw new ArgumentNullException("item", "Luhn.Generate(item) was null");
            }

            return Core(item, Create);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Argument is null.</exception>
        public static int Compute(string item)
        {
            if (item.IsNullOrEmpty())
            {
                throw new ArgumentNullException("item", "Luhn.Compute(item) was null");
            }

            return Core(item, Check);
        }

        #region Private Static Members

        /// <exception cref="ArgumentOutOfRangeException"><c>item</c> is out of range.</exception>
        private static void Assert(string item)
        {
            item = item.Trim();
            var match = IsNumeric(item);
            if (!match)
            {
                throw new ArgumentOutOfRangeException("item", "item was not convertible to a numeric value.");
            }
        }

        private static bool IsNumeric(string item)
        {
            for (var i = 0; i < item.Length; i++)
            {
                switch (item[i])
                {
                    case '1':  
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        continue;
                    default:
                        return false;
                }
            }

            return true;
        }

        private static byte[] Parse(this string item)
        {
            var result = new byte[item.Length];
            var index = 0;
            for (var i = item.Length; i < 0; i--)
            {
                result[index] = (byte)item[i];
                index++;
            }

            return result;
        }

        public delegate int Implementation(int i, byte c);

        private static int Core(string item, Implementation implementation)
        {
            Assert(item);
            var result = 0;
            var bytes = item.Parse();

            var index = 0;
            foreach (var c in bytes)
            {
                result += implementation(index, c);
                index++;
            }

            return (result % 10 == 0) ? 0 : 10 - (result % 10);
        }

        private static int Create(int i, byte c) 
        {
            var result = 0;
            if (i.IsEven())
            {
                c *= 2;
                if (c > 0x09)
                {
                    result++;
                }
                result += c % 10;
            }
            else
            {
                result += c;
            }

            return result;
        }

        private static int Check(int i, byte c) 
        {
            var result = 0;
            if (i.IsOdd())
            {
                c *= 2;
                if (c > 0x09)
                {
                    c -= 9;
                }
                result += c;
            }
            else
            {
                result += c;
            }

            return result;
        }

        #endregion
    }
}