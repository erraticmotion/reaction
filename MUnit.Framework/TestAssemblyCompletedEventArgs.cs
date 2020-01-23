namespace MUnit.Framework
{
    using Microsoft.SPOT;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TestAssemblyCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestAssemblyCompletedEventArgs"/> class.
        /// </summary>
        internal TestAssemblyCompletedEventArgs()
        {
        }

        /// <summary>
        /// Gets the number of tests passed.
        /// </summary>
        /// <value>The number of tests passed.</value>
        public int Passed { get; internal set; }

        /// <summary>
        /// Gets the number of tests failed.
        /// </summary>
        /// <value>The number of tests failed.</value>
        public int Failed { get; internal set; }


        /// <summary>
        /// Gets the name of the assembly under test.
        /// </summary>
        /// <value>The name of the assembly.</value>
        public string AssemblyName { get; internal set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return AssemblyName + " Passed " + Passed + " Failed " + Failed;
        }
    }
}
