namespace System.Extensions
{
#if MF_FRAMEWORK_VERSION_V4_1
    using MUnit.Framework;
    using MUnit.Framework.FluentAssertions;

#else
	using FluentAssertions;
    using NUnit.Framework;
#endif
	
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class Int32ExtensionsBehaviour : TestFixture
    {
        [Test]
        public void IsEven0Test()
        {
            0.IsEven().Should().BeTrue();
        }

        [Test]
        public void IsEven1Test()
        {
            1.IsEven().Should().BeFalse();
        }

        [Test]
        public void IsOdd0Test()
        {
            0.IsOdd().Should().BeFalse();
        }

        [Test]
        public void IsOdd1Test()
        {
            1.IsOdd().Should().BeTrue();
        }
    }
}