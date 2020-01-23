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
    public class ToLiteralByteExtensionsBehaviour : TestFixture
    {
        [Test]
        public void ToLiteralByte00Test()
        {
            "00".NetMf().ToLiteralByte.Should().Be(0x00);
        }

        [Test]
        public void ToLiteralByte01Test()
        {
            "01".NetMf().ToLiteralByte.Should().Be(0x01);
        }

        [Test]
        public void ToLiteralByte02Test()
        {
            "02".NetMf().ToLiteralByte.Should().Be(0x02);
        }

        [Test]
        public void ToLiteralByte03Test()
        {
            "03".NetMf().ToLiteralByte.Should().Be(0x03);
        }

        [Test]
        public void ToLiteralByte04Test()
        {
            "04".NetMf().ToLiteralByte.Should().Be(0x04);
        }

        [Test]
        public void ToLiteralByte05Test()
        {
            "05".NetMf().ToLiteralByte.Should().Be(0x05);
        }

        [Test]
        public void ToLiteralByte06Test()
        {
            "06".NetMf().ToLiteralByte.Should().Be(0x06);
        }

        [Test]
        public void ToLiteralByte07Test()
        {
            "07".NetMf().ToLiteralByte.Should().Be(0x07);
        }

        [Test]
        public void ToLiteralByte08Test()
        {
            "08".NetMf().ToLiteralByte.Should().Be(0x08);
        }

        [Test]
        public void ToLiteralByte09Test()
        {
            "09".NetMf().ToLiteralByte.Should().Be(0x09);
        }

        [Test]
        public void ToLiteralByte10Test()
        {
            "0A".NetMf().ToLiteralByte.Should().Be(0x0A);
        }

        [Test]
        public void ToLiteralByte11Test()
        {
            "0B".NetMf().ToLiteralByte.Should().Be(0x0B);
        }

        [Test]
        public void ToLiteralByte12Test()
        {
            "0C".NetMf().ToLiteralByte.Should().Be(0x0C);
        }

        [Test]
        public void ToLiteralByte13Test()
        {
            "0D".NetMf().ToLiteralByte.Should().Be(0x0D);
        }

        [Test]
        public void ToLiteralByte14Test()
        {
            "0E".NetMf().ToLiteralByte.Should().Be(0x0E);
        }

        [Test]
        public void ToLiteralByte15Test()
        {
            "0F".NetMf().ToLiteralByte.Should().Be(0x0F);
        }
    }
}