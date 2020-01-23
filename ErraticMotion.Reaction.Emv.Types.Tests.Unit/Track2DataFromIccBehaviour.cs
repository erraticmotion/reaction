namespace ErraticMotion.Reaction
{
    using System;
    using System.Bcd;
    using System.IO;

#if MF_FRAMEWORK_VERSION_V4_1
    using MUnit.Framework;
    using MUnit.Framework.FluentAssertions;
#else
	using FluentAssertions;
    using NUnit.Framework;
	using Moq;
#endif
	
    /// <summary>
    /// 
    /// </summary>
	[TestFixture]
    public class Track2DataFromIccBehaviour : ArrangeActAssert
    {
        private ITrack2 sut;
        private MemoryStream ms;

        /// <summary>
        /// Arrange all necessary preconditions and inputs.  
        /// </summary>
        protected override void Arrange()
        {
            ms = new MemoryStream();
            ms.WriteByte(0x53);
            ms.WriteByte(0x01);
            ms.WriteByte(0x23);
            ms.WriteByte(0x43);
            ms.WriteByte(0x77);
            ms.WriteByte(0x77);
            ms.WriteByte(0x90);
            ms.WriteByte(0x04);
            ms.WriteByte(0xD1);
            ms.WriteByte(0x10);
            ms.WriteByte(0x32);
            ms.WriteByte(0x01);
            ms.WriteByte(0x83);
            ms.WriteByte(0x30);
            ms.WriteByte(0x00);
            ms.WriteByte(0x00);
            ms.WriteByte(0x00);
            ms.WriteByte(0x00);
            ms.WriteByte(0x1F);
        }

        /// <summary>
        /// Act on the object or method under test.  
        /// </summary>
        protected override void Act()
        {
            sut = Track2DataFromIcc.Parse(ms.ToArray());
        }

        /// <summary>
        /// Assert that the expected results have occurred. 
        /// </summary>
		[Assert]
        public void IccTrack2ExpectCardNumberAssert()
        {
            sut.CardNumber.Should().Be("5301234377779004");
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateYearAssert()
        {
            sut.ExpiryDateYear.Should().Be(0x11);
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateYearByteAssert()
        {
            sut.ExpiryDateYear.AsPackedBcd().ToByte().Should().Be(0x0B);
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateYearUnPackedAssert()
        {
            sut.ExpiryDateYear.AsPackedBcd().ToByte().Should().Be(11);
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateMonthAssert()
        {
            sut.ExpiryDateMonth.Should().Be(0x03);
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateMonthByteAssert()
        {
            sut.ExpiryDateMonth.AsPackedBcd().ToByte().Should().Be(0x03);
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateMonthUnPackedAssert()
        {
            sut.ExpiryDateMonth.AsPackedBcd().ToByte().Should().Be(3);
        }

        [Assert]
        public void IccTrack2ExpectServiceCodeAssert()
        {
            sut.ServiceCode.Should().Be(201);
        }

        [Assert]
        public void IccTrack2DiscretionaryDataAssert()
        {
            sut.DiscretionaryData.Should().Be("8330000000001F");
        }

        [Assert]
        public void IccTrack2ExpectExpiryDateAssert()
        {
            sut.Expiry().Date.Should().Be(new DateTime(2011, 3, 31, 23, 59, 59));
        }

        [Assert]
        public void IccTrack2BinRangeLastFourAssert()
        {
            sut.BinRange().LastFour.Should().Be("9004");
        }

        [Assert]
        public void IccTrack2BinRangeFirstSixAssert()
        {
            sut.BinRange().FirstSix.Should().Be("530123");
        }

        [Assert]
        public void IccTrack2BinRangeBinAssert()
        {
            sut.BinRange().Bin(4).Should().Be(5301);
        }

        [Assert]
        public void IccTrack2ServiceCodeDigitOneAssert()
        {
            sut.Emv().ServiceCodeDigit1.Should().Be(2);
        }

        [Assert]
        public void IccTrack2ServiceCodeDigitTwoAssert()
        {
            sut.Emv().ServiceCodeDigit2.Should().Be(0);
        }

        [Assert]
        public void IccTrack2ServiceCodeDigitThreeAssert()
        {
            sut.Emv().ServiceCodeDigit3.Should().Be(1);
        }

        [Assert]
        public void IccTrack2CardNumberLuhnCheckAssert()
        {
            Luhn.IsValid(sut.CardNumber).Should().BeTrue();
        }
    }
}