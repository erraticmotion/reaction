namespace MUnit.Framework
{
    using System.Threading;
    using System.Reflection;

    /// <summary>
    /// 
    /// </summary>
    public class TestRunController
    {
        public event TestCompletedEventHandler TestCompleted;
        public event TestAssemblyCompletedEventHandler TestAssemblyCompleted;

        private readonly TestRun[] runners;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunController"/> class.
        /// </summary>
        /// <param name="testAssembly">The test assembly.</param>
        public TestRunController(Assembly testAssembly)
        {
            runners = new [] { new TestRun(testAssembly) };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunController"/> class.
        /// </summary>
        /// <param name="testAssemblies">The test assemblies.</param>
        public TestRunController(Assembly[] testAssemblies)
        {
            runners = new TestRun[testAssemblies.Length];
            var i = 0;
            foreach (var testAssembly in testAssemblies)
            {
                runners[i] = new TestRun(testAssembly);
                i++;
            }
        }

        public void Execute()
        {
            foreach (var runner in runners)
            {
                runner.TestCompleted += (sender, e) => OnTestCompleted(e);
                runner.TestAssemblyCompleted += (sender, e) => OnTestAssemblyCompleted(e);
                new Thread(runner.Execute).Start();
            }
        }

        private void OnTestCompleted(TestCompletedEventArgs item)
        {
            // Not interested in notifying if the test has passed.
            if (item.Pass)
            {
                return;
            }

            var ev = TestCompleted;
            if (ev != null)
            {
                ev(this, item);
            }
        }

        private void OnTestAssemblyCompleted(TestAssemblyCompletedEventArgs item)
        {
            var ev = TestAssemblyCompleted;
            if (ev != null)
            {
                ev(this, item);
            }
        }
    }
}
