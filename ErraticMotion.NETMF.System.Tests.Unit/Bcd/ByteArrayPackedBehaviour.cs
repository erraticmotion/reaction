namespace System.Bcd
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
    public class ByteArrayPackedBehaviour : TestFixture
    {
        [Assert]
        public void ShouldConvert0X9191ToString9191Test()
        {
            var sut = new byte[] { 0x91, 0x91 };
            sut.AsPackedBcd().ConvertToString().Should().Be("9191");
        }

        [Assert]
        public void ShouldConvert0X919FToString919FTest()
        {
            var sut = new byte[] { 0x91, 0x9F };
            sut.AsPackedBcd().ConvertToString().Should().Be("919F");
        }

        [Assert]
        public void ShouldConvert0X919FToString919Test()
        {
            var sut = new byte[] { 0x91, 0x9F };
            sut.AsPackedBcd().ConvertToString(true).Should().Be("919");
        }
    }
}