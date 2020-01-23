namespace System.Collections
{
    using System;

#if MF_FRAMEWORK_VERSION_V4_1
    public sealed class BitArray
#else
    public sealed class BitArrayMf
#endif
    {
        private readonly int[] array;
        private readonly int length;

        /// <summary>
        /// Gets or sets the <see cref="bool"/> at the specified index.
        /// </summary>
        /// <value></value>
        public bool this[int index]
        {
            get
            {
                return Get(index);
            }
            set
            {
                Set(index, value);
            }
        }

#if MF_FRAMEWORK_VERSION_V4_1
        public BitArray(int length)
#else
        public BitArrayMf(int length)
#endif
            : this(length, false)
        {
        }

#if MF_FRAMEWORK_VERSION_V4_1
        public BitArray(bool[] values)
#else
        public BitArrayMf(bool[] values)
#endif
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }

            array = new int[(values.Length + 31) / 32];
            length = values.Length;
            for (var index = 0; index < values.Length; ++index)
            {
                if (values[index])
                {
                    array[index / 32] |= 1 << index % 32;
                }
            }
        }

#if MF_FRAMEWORK_VERSION_V4_1
        public BitArray(byte[] bytes)
#else
        public BitArrayMf(byte[] bytes)
#endif
        {
            if (bytes == null)
            {
                throw new ArgumentNullException("bytes");
            }

            array = new int[(bytes.Length + 3) / 4];
            length = bytes.Length * 8;
            var index1 = 0;
            var index2 = 0;
            while (bytes.Length - index2 >= 4)
            {
                array[index1++] = bytes[index2] & byte.MaxValue
                    | (bytes[index2 + 1] & byte.MaxValue) << 8
                    | (bytes[index2 + 2] & byte.MaxValue) << 16
                    | (bytes[index2 + 3] & byte.MaxValue) << 24;
                index2 += 4;
            }
            switch (bytes.Length - index2)
            {
                case 1:
                    array[index1] |= bytes[index2] & byte.MaxValue;
                    break;
                case 2:
                    array[index1] |= (bytes[index2 + 1] & byte.MaxValue) << 8;
                    goto case 1;
                case 3:
                    array[index1] = (bytes[index2 + 2] & byte.MaxValue) << 16;
                    goto case 2;
            }
        }

#if MF_FRAMEWORK_VERSION_V4_1
        public BitArray(int length, bool defaultValue)
#else
        public BitArrayMf(int length, bool defaultValue)
#endif
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length");
            }

            array = new int[(length + 31) / 32];
            this.length = length;
            var num = defaultValue ? -1 : 0;
            for (var index = 0; index < array.Length; ++index)
            {
                array[index] = num;
            }
        }

        public int Count
        {
            get
            {
                return length;
            }
        }

        /// <summary>
        /// Gets the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public bool Get(int index)
        {
            if (index < 0 || index >= length)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return (array[index / 32] & 1 << index % 32) != 0;
        }

        /// <summary>
        /// Sets the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public void Set(int index, bool value)
        {
            if (index < 0 || index >= length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (value)
            {
                array[index / 32] |= 1 << index % 32;
            }
            else
            {
                array[index / 32] &= ~(1 << index % 32);
            }
        }
    }
}
