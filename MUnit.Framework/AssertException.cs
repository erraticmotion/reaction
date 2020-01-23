namespace MUnit.Framework
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class AssertException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssertException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public AssertException(string message)
            : base(message)
        {
        }
    }
}
