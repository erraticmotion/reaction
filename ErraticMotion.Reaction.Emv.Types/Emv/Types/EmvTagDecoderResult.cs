namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// Contains the result from applying the <see cref="EmvTagDecoder"/> to a byte array
    /// </summary>
    internal class EmvTagDecoderResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmvTagDecoderResult"/> class.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="length">The actual tag length.</param>
        public EmvTagDecoderResult(byte[] tag, int length)
        {
            switch (length)
            {
                case 1:
                    RawTag = new[] { tag[0] };
                    Tag = (TagLengthValueType)tag[0];
                    break;
                case 2:
                    RawTag = new[] { tag[0], tag[1] };
                    Tag = (TagLengthValueType)BitConverter.ToInt32(new byte[] { tag[1], tag[0], 0x00, 0x00 }, 0);
                    break;
                case 3:
                    RawTag = new[] { tag[0], tag[1], tag[2] };
                    Tag = (TagLengthValueType)BitConverter.ToInt32(new byte[] { tag[2], tag[1], tag[0], 0x00 }, 0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("tag", @"Only a tag length of between 1 and 3 supported.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TagLengthValueType Tag { get; private set; }

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <value>The tag.</value>
        public byte[] RawTag { get; private set; }
    }
}
