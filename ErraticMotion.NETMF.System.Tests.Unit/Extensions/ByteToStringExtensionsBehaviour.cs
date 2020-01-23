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
    public class ByteToStringExtensionsBehaviour : TestFixture
    {
        [Test]
        public void FromLiteralByte00Test()
        {
            ((byte)0x00).NetMf().Format("X").Should().Be("00");
        }

        [Test]
        public void FromLiteralByte01Test()
        {
            ((byte)0x01).NetMf().Format("X").Should().Be("01");
        }

        [Test]
        public void FromLiteralByte02Test()
        {
            ((byte)0x02).NetMf().Format("X").Should().Be("02");
        }

        [Test]
        public void FromLiteralByte03Test()
        {
            ((byte)0x03).NetMf().Format("X").Should().Be("03");
        }

        [Test]
        public void FromLiteralByte04Test()
        {
            ((byte)0x04).NetMf().Format("X").Should().Be("04");
        }

        [Test]
        public void FromLiteralByte05Test()
        {
            ((byte)0x05).NetMf().Format("X").Should().Be("05");
        }

        [Test]
        public void FromLiteralByte06Test()
        {
            ((byte)0x06).NetMf().Format("X").Should().Be("06");
        }

        [Test]
        public void FromLiteralByte07Test()
        {
            ((byte)0x07).NetMf().Format("X").Should().Be("07");
        }

        [Test]
        public void FromLiteralByte08Test()
        {
            ((byte)0x08).NetMf().Format("X").Should().Be("08");
        }

        [Test]
        public void FromLiteralByte09Test()
        {
            ((byte)0x09).NetMf().Format("X").Should().Be("09");
        }

        [Test]
        public void FromLiteralByte10Test()
        {
            ((byte)0x0A).NetMf().Format("X").Should().Be("0A");
        }

        [Test]
        public void FromLiteralByte11Test()
        {
            ((byte)0x0B).NetMf().Format("X").Should().Be("0B");
        }

        [Test]
        public void FromLiteralByte12Test()
        {
            ((byte)0x0C).NetMf().Format("X").Should().Be("0C");
        }

        [Test]
        public void FromLiteralByte13Test()
        {
            ((byte)0x0D).NetMf().Format("X").Should().Be("0D");
        }

        [Test]
        public void FromLiteralByte14Test()
        {
            ((byte)0x0E).NetMf().Format("X").Should().Be("0E");
        }

        [Test]
        public void FromLiteralByte15Test()
        {
            ((byte)0x0F).NetMf().Format("X").Should().Be("0F");
        }

        [Test]
        public void FromLiteralByte15LowerTest()
        {
            ((byte)0x0F).NetMf().Format("x").Should().Be("0f");
        }
    }
}