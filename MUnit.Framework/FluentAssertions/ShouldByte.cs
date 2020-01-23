namespace MUnit.Framework.FluentAssertions
{
    internal class ShouldByte : ShouldObject, IShouldByte
    {
        private readonly byte value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldObject"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ShouldByte(byte value)
            : base(value)
        {
            this.value = value;
        }

        #region Implementation of IShouldByte

        public void Be(byte expected)
        {
            if (value != expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        public void NotBe(byte expected)
        {
            if (value == expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        #endregion
    }
}
