namespace MUnit.Framework.FluentAssertions
{
    internal class ShouldObject : IShouldObject
    {
        private readonly object value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldObject"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ShouldObject(object value)
        {
            this.value = value;
        }

        public void BeNull()
        {
            if (value != null)
                Assert.Fail("Expected: \"null\", Actual: \"not null\".");
        }

        public void NotBeNull()
        {
            if (value == null)
                Assert.Fail("Expected: \"not null\", Actual: \"null\".");
        }
    }
}
