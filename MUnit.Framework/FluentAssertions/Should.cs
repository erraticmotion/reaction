namespace MUnit.Framework.FluentAssertions
{
    using System;

    /// <summary>
    /// Fluent assertions
    /// </summary>
    public static class ShouldExtensions
    {
        public static IShouldBool Should(this bool value)
        {
            return new ShouldBool(value);
        }

        public static IShouldObject Should(this object value)
        {
            return new ShouldObject(value);
        }

        public static IShouldInt32 Should(this int value)
        {
            return new ShouldInt32(value);
        }

        public static IShouldInt64 Should(this long value)
        {
            return new ShouldInt64(value);
        }

        public static IShouldString Should(this string value)
        {
            return new ShouldString(value);
        }

        public static IShouldByte Should(this byte item)
        {
            return new ShouldByte(item);
        }

        public static IShouldDateTime Should(this DateTime item)
        {
            return new ShouldDateTime(item);
        }
    }
}
