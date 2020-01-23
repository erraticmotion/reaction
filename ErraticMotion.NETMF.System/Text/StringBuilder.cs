namespace System.Text
{
    using System;

#if MF_FRAMEWORK_VERSION_V4_1
    public class StringBuilder
#else
    public class StringBuilderMf
#endif
    {
        private const int InitialSize = 16;
        private const int MinGrowthSize = 64;
        private char[] content;

#if MF_FRAMEWORK_VERSION_V4_1
        public StringBuilder()
#else
        public StringBuilderMf()
#endif
            : this(InitialSize)
        {
        }

#if MF_FRAMEWORK_VERSION_V4_1
        public StringBuilder(int capacity)
#else
        public StringBuilderMf(int capacity)
#endif
        {
            content = new char[capacity];
        }

#if MF_FRAMEWORK_VERSION_V4_1
        public StringBuilder(string initital)
#else
        public StringBuilderMf(string initital)
#endif
        {
            content = initital.ToCharArray();
            Length = content.Length;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>The length.</value>
        public int Length { get; private set; }

        /// <summary>
        /// Gets the <see cref="System.Char"/> at the specified index.
        /// </summary>
        /// <value></value>
        public char this[int index] { get { return content[index]; } }

        /// <summary>
        /// Append a character to the current string builder
        /// </summary>
        /// <param name="c"></param>
        public void Append(char c)
        {
            Append(new string(new[] { c }));
        }

        /// <summary>
        /// Append a string to the current string builder
        /// </summary>
        /// <param name="toAppend">String to be appended.</param>
        public void Append(string toAppend)
        {
            var additionalSpaceRequired = (toAppend.Length + Length) - content.Length;

            if (additionalSpaceRequired > 0)
            {
                // ensure at least minimum growth size is done to minimise future copying / manipulation
                if (additionalSpaceRequired < MinGrowthSize)
                {
                    additionalSpaceRequired = MinGrowthSize;
                }

                var tmp = new char[content.Length + additionalSpaceRequired];

                // copy content to new array
                Array.Copy(content, tmp, Length);

                // replace the content array.
                content = tmp;
            }

            // copy the new content to the holding array
            Array.Copy(toAppend.ToCharArray(), 0, content, Length, toAppend.Length);
            Length += toAppend.Length;
        }

        /// <summary>
        /// Append the provided line along with a new line.
        /// </summary>
        /// <param name="str"></param>
        public void AppendLine(string str)
        {
            Append(str);
            Append("\r\n");
        }

        /// <summary>
        /// Clear the current string builder back to an empty string.
        /// </summary>
        public void Clear()
        {
            Length = 0;
        }

        /// <summary>
        /// Get the final built string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return new string(content, 0, Length);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="length">The length.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public string ToString(int index, int length)
        {
            return new string(content, 0, length);
        }
    }
}
