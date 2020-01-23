namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class DecodedItem : IEmvElement
    {
        /// <summary>
        /// The function to apply to this item when converting to its string
        /// representation.
        /// </summary>
        private Func<byte[], string> toString;

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodedItem"/> class.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="value">The value.</param>
        public DecodedItem(TagLengthValueType tag, byte[] value)
        {
            Value = value;
            Tag = tag;
            ApplyToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodedItem"/> class.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="ArgumentOutOfRangeException"><c>tag</c> is out of range.</exception>
        public DecodedItem(byte[] tag, byte[] value)
        {
            Value = value;
            switch (tag.Length)
            {
                case 1:
                    Tag = (TagLengthValueType)tag[0];
                    RawTag = new[] { tag[0] };
                    break;
                case 2:
                    var i = BitConverter.ToInt32(new byte[] { tag[1], tag[0], 0x00, 0x00 }, 0);
                    RawTag = new[] { tag[0], tag[1] };
                    Tag = (TagLengthValueType)i;
                    break;
                case 3:
                    RawTag = new[] { tag[0], tag[1], tag[2] };
                    Tag =
                        (TagLengthValueType)
                        BitConverter.ToInt32(new byte[] { tag[2], tag[1], tag[0], 0x00 }, 0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("tag", @"Only a tag length of between 1 and 3 supported.");
            }

            if (Tag == TagLengthValueType.PrimaryAccountNumber)
            {
                Value = Value.TakeWhile(x => x != 0xFF).ToArray();
            }
            ApplyToString();
        }

        private void ApplyToString()
        {
            const string format = "{0,33} {1,6}: {2} [{3}]";
            switch (Tag)
            {
                case TagLengthValueType.ApplicationExpirationDate:
                case TagLengthValueType.ApplicationEffectiveDate:
                    toString = b => string.Format(format, Tag, RawTag.AsString(false), b.DefaultDecoder(), b.DateDecoder());
                    break;

                case TagLengthValueType.PrimaryAccountNumber:
                    toString =
                        b =>
                        string.Format(
                            format,
                            Tag,
                            RawTag.AsString(false),
                            b.DefaultDecoder().ObfuscateCardNumber(), 
                            b.BcdDecoder().ObfuscateCardNumber());
                    break;

                case TagLengthValueType.IccTrack2EquivData:
                    toString = b => string.Format("{0,33} {1,6}: {2}", Tag, RawTag.AsString(false), b.ObfuscateTrack2());
                    break;

                case TagLengthValueType.CardMovementTrack2Data:
                    toString = b => string.Format("{0,33} {1,6}: {2}", Tag, RawTag.AsString(false), b.ObfuscateTrack2(b.Count()));
                    break;

                case TagLengthValueType.CardholderName:
                case TagLengthValueType.PreferredName:
                    toString = b => string.Format(format, Tag, RawTag.AsString(false), b.DefaultDecoder(), b.AsciiDecoder());
                    break;

                case TagLengthValueType.InformationDescription:
                    toString = b => string.Format("{0,33} {1,6}: {2}", Tag, RawTag.AsString(false), Encoding.ASCII.GetString(b));
                    break;

                default:
                    toString = b => string.Format("{0,33} {1,6}: {2}", Tag, RawTag.AsString(false), b.DefaultDecoder());
                    break;
            }
        }

        /// <summary>
        /// Gets the decoded items tag value as a <see cref="TagLengthValueType"/> enumeration.
        /// </summary>
        public TagLengthValueType Tag { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public byte[] RawTag { get; private set; }

        /// <summary>
        /// Gets the value of the decoded item.
        /// </summary>
        public byte[] Value { get; private set; }

        /// <summary>
        /// Gets the length of the decoded value
        /// </summary>
        public int Length { get { return Value.Length;  } }

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IEmvElementVisitor visitor)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public DeviceKeyPressed KeyboardData 
        { 
            get
            {
                return (Tag == TagLengthValueType.KeyboardData) 
                    ? (DeviceKeyPressed) Value[0] 
                    : DeviceKeyPressed.None;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsKeyboardData { get { return (Tag == TagLengthValueType.KeyboardData); } }

        /// <summary>
        /// 
        /// </summary>
        public CardMovements CardMovement
        {
            get
            {
                if (Tag != TagLengthValueType.CardMovement)
                    return CardMovements.None;

                var result = CardMovements.None;
                var byte1 = Value[0].ToLazyBitArray();
                if (byte1.Value[0])
                    result |= CardMovements.CardInSlot;

                if (byte1.Value[1])
                    result |= CardMovements.CardReturningEmvAsynchronousCard;

                if (byte1.Value[2])
                    result |= CardMovements.CardReturningSynchronousCard;

                if (byte1.Value[3])
                    result |= CardMovements.CardReturningI2CCard;

                var byte2 = Value[1].ToLazyBitArray();
                if (byte2.Value[0])
                    result |= CardMovements.CardSuccessfullySwiped;
                if (byte2.Value[1])
                    result |= CardMovements.Track1Available;
                if (byte2.Value[2])
                    result |= CardMovements.Track2Available;
                if (byte2.Value[3])
                    result |= CardMovements.Track3Available;

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsCardMovement { get { return (Tag == TagLengthValueType.CardMovement); } }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            try
            {
                return toString(Value);
            }
            catch(Exception ex)
            {
                return string.Format("{0,40}: {1}", Tag, ex.Message);
            }
        }

        /// <summary>
        /// Reads the language command byte array that is sent to the connected device.
        /// </summary>
        /// <returns></returns>
        public byte[] ReadLanguage()
        {
            var s = new MemoryStream();
            s.Write(Tag.RawValue().ToArray(), 0, Tag.Length());
            s.WriteByte((byte)Value.Length);
            s.Write(Value, 0, Value.Length);
            return s.ToArray();
        }
    }
}