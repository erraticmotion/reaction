namespace MUnit.Framework.FluentAssertions
{
    /// <summary>
    /// 
    /// </summary>
    internal class ShouldString : ShouldObject, IShouldString
    {
        private readonly string value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldObject"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ShouldString(string value)
            : base(value)
        {
            this.value = value;
        }

        #region Implementation of IShouldString

        public void Be(string expected)
        {
            if (value != expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        public void NotBe(string expected)
        {
            if (value == expected)
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        #endregion
    }
}
