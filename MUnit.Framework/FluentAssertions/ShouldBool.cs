namespace MUnit.Framework.FluentAssertions
{
    internal class ShouldBool : ShouldObject, IShouldBool
    {
        private readonly bool value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShouldBool"/> class.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public ShouldBool(bool value)
            : base(value)
        {
            this.value = value;
        }

        public void BeTrue()
        {
            Assert.AreEqual(true, value);
        }

        public void BeFalse()
        {
            Assert.AreEqual(false, value);
        }
    }
}
