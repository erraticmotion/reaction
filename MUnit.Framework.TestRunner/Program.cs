namespace MUnit.Framework.TestRunner
{
    using System;
    using System.Reflection;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            var testAssemblies = new[]
            {
                Assembly.Load("ErraticMotion.NETMF.System.Tests.Unit"),
                Assembly.Load("ErraticMotion.Reaction.Emv.Types.Tests.Unit")
            };

            var controller = new TestRunController(testAssemblies);
            controller.TestCompleted += (sende, e) => Console.WriteLine(e);
            controller.TestAssemblyCompleted += (sender, e) => Console.WriteLine(e);
            controller.Execute();
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
