namespace MUnit.Framework.FluentAssertions
{
    internal class ShouldInt32 : ShouldObject, IShouldInt32
    {
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldInt32"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ShouldInt32(int value)
            : base(value)
        {
            this.value = value;
        }

        public void Be(int expected)
        {
            if (value != expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        public void NotBe(int expected)
        {
            if (value == expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }
    }
}
