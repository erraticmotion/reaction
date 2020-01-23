namespace MUnit.Framework.FluentAssertions
{
    using System;

    internal class ShouldDateTime : ShouldObject, IShouldDateTime
    {
        private readonly DateTime value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldObject"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ShouldDateTime(DateTime value)
            : base(value)
        {
            this.value = value;
        }

        #region Implementation of IShouldDateTime

        public void Be(DateTime expected)
        {
            if (0 != expected.CompareTo(value))
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        public void NotBe(DateTime expected)
        {
            if (0 == expected.CompareTo(value))
                Assert.Fail("Expected: \"" + expected + "\", Actual: \"" + value + "\".");
        }

        #endregion
    }
}
