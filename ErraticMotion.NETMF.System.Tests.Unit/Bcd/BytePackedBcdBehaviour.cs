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
    public class BytePackedBcdBehaviour : TestFixture
    {
        /// <summary>
        /// Assert that the expected results have occurred. 
        /// </summary>
        [Assert]
        public void ShouldConvert0X91ToDecimal91Test()
        {
            ((byte)0x91).AsPackedBcd().ToByte().Should().Be(91);
        }

        [Assert]
        public void ShouldConvert0X91ToString91Test()
        {
            ((byte)0x91).AsPackedBcd().ConvertToString().Should().Be("91");
        }

        [Assert]
        public void ShouldAdd0X11To2000ToGet2011Test()
        {
            (((byte)0x11).AsPackedBcd().ToByte() + 2000).Should().Be(2011);
        }

        [Assert]
        public void ShouldStripTrailingFTest()
        {
            ((byte)0x1F).AsPackedBcd().ConvertToString(true).Should().Be("1");
        }

        [Assert]
        public void ShouldNotStripTrailingFTest()
        {
            ((byte)0x1F).AsPackedBcd().ConvertToString(false).Should().Be("1F");
        }

        [Assert]
        public void ShouldThrowWhenTrailingFTest()
        {
            Assert.Throws(() => ((byte)0x1F).AsPackedBcd().ToByte(), typeof(ArgumentOutOfRangeException));
        }

        [Assert]
        public void ShouldNotThrowWhenTrailingFTest()
        {
            Assert.DoesNotThrow(() => ((byte)0x1F).AsPackedBcd().ToByte(true));
        }
    }
}