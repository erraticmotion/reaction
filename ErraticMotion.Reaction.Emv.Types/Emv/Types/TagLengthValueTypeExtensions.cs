namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains extension methods for the <see cref="TagLengthValueType"/> enumeration
    /// </summary>
    public static class TagLengthValueTypeExtensions
    {
        /// <summary>
        /// Returns the length of the <paramref name="value"/> when converted to a byte array
        /// </summary>
        /// <param name="value">The <see cref="TagLengthValueType"/> value.</param>
        /// <returns>The length of the value</returns>
        public static int Length(this TagLengthValueType value)
        {
            var b = BitConverter.GetBytes((int) value);
            return b.Count(x => x != 0x00);
        }

        /// <summary>
        /// Gets a byte array representation of the <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="TagLengthValueType"/> value.</param>
        /// <returns>A byte array representation of the value.</returns>
        public static IEnumerable<byte> RawValue(this TagLengthValueType value)
        {
            var b = BitConverter.GetBytes((int)value);
            return b.Take(value.Length()).Reverse();
        }
    }
}
