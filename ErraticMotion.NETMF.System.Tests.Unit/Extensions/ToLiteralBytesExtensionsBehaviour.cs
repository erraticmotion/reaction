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
    public class ToLiteralBytesExtensionsBehaviour : TestFixture
    {
        [Test]
        public void ToLiteralBytes0000Test()
        {
            var b = "0000".NetMf().ToLiteralBytes;
            b[0].Should().Be(0x00);
            b[1].Should().Be(0x00);
        }

        [Test]
        public void ToLiteralBytes0101Test()
        {
            var b = "0101".NetMf().ToLiteralBytes;
            b[0].Should().Be(0x01);
            b[1].Should().Be(0x01);
        }
    }
}