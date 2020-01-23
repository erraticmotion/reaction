namespace MUnit.Framework
{
    using System;
    using System.Reflection;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TestRun
    {
        public event TestCompletedEventHandler TestCompleted;
        public event TestAssemblyCompletedEventHandler TestAssemblyCompleted;

        private readonly Assembly testAssembly;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRun"/> class.
        /// </summary>
        /// <param name="testAssembly">The test assembly.</param>
        public TestRun(Assembly testAssembly)
        {
            this.testAssembly = testAssembly;
        }

        public void Execute()
        {
            var passed = 0;
            var failed = 0;

            foreach (var type in testAssembly.GetTypes())
            {
                if (!type.IsSubclassOf(typeof(TestFixture)))
                {
                    break;
                }

                // ReSharper disable PossibleNullReferenceException
                var instance = type.GetConstructor(new Type[] { }).Invoke(new object[] { });
                // ReSharper restore PossibleNullReferenceException

                var protectedMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

                MethodInfo setUpMethod = null;
                MethodInfo tearDownMethod = null;
                foreach (var method in protectedMethods)
                {
                    if (method.Name == "SetUp")
                    {
                        setUpMethod = method;
                    }

                    if (method.Name == "TearDown")
                    {
                        tearDownMethod = method;
                    }
                }

                var publicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
                foreach (var method in publicMethods)
                {
                    if (method.ReturnType == typeof(void))
                    {
                        var testMatch = false;
                        var iTest = method.Name.LastIndexOf("Test");
                        if (iTest > -1 && iTest == method.Name.Length - 4)
                        {
                            testMatch = true;
                        }

                        var iAssert = method.Name.LastIndexOf("Assert");
                        if (iAssert > -1 && iAssert == method.Name.Length - 6)
                        {
                            testMatch = true;
                        }

                        if (testMatch)
                        {
                            var result = new TestCompletedEventArgs
                            {
                                TestClass = type.Name,
                                TestMethod = method.Name,
                                Message = string.Empty
                            };

                            try
                            {
                                if (setUpMethod != null)
                                {
                                    setUpMethod.Invoke(instance, new object[] { });
                                }

                                method.Invoke(instance, new object[] { });

                                if (tearDownMethod != null)
                                {
                                    tearDownMethod.Invoke(instance, new object[] { });
                                }
                                result.Pass = true;
                                passed++;
                            }
                            catch (AssertException ex)
                            {
                                result.Pass = false;
                                result.Message = ex.Message;
                                failed++;
                            }
                            catch (Exception ex)
                            {
                                result.Pass = false;
                                result.Message = ex.ToString();
                                failed++;
                            }

                            OnTestCompleted(result);
                        }
                    }
                }
            }

            OnTestAssemblyCompleted(new TestAssemblyCompletedEventArgs
                {
                    Passed = passed,
                    Failed = failed,
                    AssemblyName = testAssembly.FullName,
                });
        }

        private void OnTestCompleted(TestCompletedEventArgs item)
        {
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
