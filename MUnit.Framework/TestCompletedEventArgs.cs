namespace MUnit.Framework
{
    using Microsoft.SPOT;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TestCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCompletedEventArgs"/> class.
        /// </summary>
        internal TestCompletedEventArgs()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether this test has passed.
        /// </summary>
        /// <value><c>true</c> if pass; otherwise, <c>false</c>.</value>
        public bool Pass { get; internal set; }

        /// <summary>
        /// Gets the test class.
        /// </summary>
        /// <value>The test class.</value>
        public string TestClass { get; internal set; }

        /// <summary>
        /// Gets the test method.
        /// </summary>
        /// <value>The test method.</value>
        public string TestMethod { get; internal set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; internal set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var passed = (Pass) ? "PASS " : "FAIL ";
            var member = TestClass + "." + TestMethod;
            if (Message == null)
                return passed + member;

            return passed + member + " " + Message;
        }
    }
}
