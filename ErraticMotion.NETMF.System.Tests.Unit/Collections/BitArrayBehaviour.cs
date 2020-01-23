namespace System.Collections
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
    public class BitArrayBehaviour : TestFixture
    {
        [Test]
        public void ShouldDefaultToFalseTest()
        {
            var sut = new BitArray(8);
            for (var i = 0; i < 8; i++)
            {
                sut[i].Should().BeFalse();
            }
        }

        [Test]
        public void ShouldHaveCountOfEightTest()
        {
            var sut = new BitArray(8);
            sut.Count.Should().Be(8);
        }

        [Test]
        public void ShouldSetIndexPosition0Test()
        {
            var sut = new BitArray(8);
            sut.Set(0, true);
            sut[0].Should().BeTrue();
        }
    }
}