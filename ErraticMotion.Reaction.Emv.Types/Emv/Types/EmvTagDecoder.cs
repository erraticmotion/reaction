namespace Servebase.Pceft.Ped.Emv
{
    using System.Collections;
    using System.IO;

    /// <summary>
    /// Responsible for decoding an EMV byte array into it's constituent parts, Tag, Length and Value
    /// </summary>
    internal static class EmvTagDecoder
    {
        public static EmvTagDecoderResult Decode(byte[] item)
        {
            return Decode(new MemoryStream(item));
        }

        public static EmvTagDecoderResult Decode(Stream item)
        {
            var tag = new byte[3];
            byte length;
            tag[0] = (byte)item.ReadByte();
            var ba1 = new BitArray(new[] { tag[0] });

            if (ba1[0] && ba1[1] && ba1[2] && ba1[3] && ba1[4])
            {
                tag[1] = (byte)item.ReadByte();
                var ba2 = new BitArray(new[] { tag[1] });
                if (ba2[7])
                {
                    length = 0x03;
                    tag[2] = (byte)item.ReadByte();
                }
                else
                {
                    length = 0x02;
                }
            }
            else
            {
                length = 0x01;
            }

            return new EmvTagDecoderResult(tag, length);
        }
    }
}
