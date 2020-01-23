namespace MUnit.Framework.FluentAssertions
{
    internal class ShouldInt64: ShouldObject, IShouldInt64
    {
        private readonly long value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldInt32"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ShouldInt64(long value)
            : base(value)
        {
            this.value = value;
        }

        public void Be(long expected)
        {
            if (value != expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        public void NotBe(long expected)
        {
            if (value == expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }
    }
}
