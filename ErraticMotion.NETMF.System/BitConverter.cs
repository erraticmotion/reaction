namespace System
{
#if MF_FRAMEWORK_VERSION_V4_1
    public static class BitConverter
#else
    public static class BitConverterMf
#endif
    {
        public static unsafe long DoubleToInt64Bits(double value)
        {
            return *(((long*)&value));
        }

        public static unsafe double Int64BitsToDouble(long value)
        {
            return *(((double*)&value));
        }

        public static byte[] GetBytes(bool value)
        {
            return new[] { (value ? ((byte)1) : ((byte)0)) };
        }

        public static byte[] GetBytes(char value)
        {
            return new[] { (byte)(value & 0xFF), (byte)((value >> 8) & 0xFF) };
        }

        public static byte[] GetBytes(short value)
        {
            return new[] { (byte)(value & 0xFF), (byte)((value >> 8) & 0xFF) };
        }

        public static byte[] GetBytes(ushort value)
        {
            return new[] { (byte)(value & 0xFF), (byte)((value >> 8) & 0xFF) };
        }

        public static byte[] GetBytes(int value)
        {
            return new[] 
            { 
                (byte)(value & 0xFF), 
                (byte)((value >> 8) & 0xFF), 
                (byte)((value >> 16) & 0xFF), 
                (byte)((value >> 24) & 0xFF) 
            };
        }

        public static byte[] GetBytes(uint value)
        {
            return new[] 
            { 
                (byte)(value & 0xFF), 
                (byte)((value >> 8) & 0xFF), 
                (byte)((value >> 16) & 0xFF), 
                (byte)((value >> 24) & 0xFF) 
            };
        }

        public static byte[] GetBytes(long value)
        {
            return new[] 
            { 
                (byte)(value & 0xFF), 
                (byte)((value >> 8) & 0xFF), 
                (byte)((value >> 16) & 0xFF), 
                (byte)((value >> 24) & 0xFF), 
                (byte)((value >> 32) & 0xFF), 
                (byte)((value >> 40) & 0xFF), 
                (byte)((value >> 48) & 0xFF), 
                (byte)((value >> 56) & 0xFF) 
            };
        }

        public static byte[] GetBytes(ulong value)
        {
            return new[] 
            { 
                (byte)(value & 0xFF), 
                (byte)((value >> 8) & 0xFF), 
                (byte)((value >> 16) & 0xFF), 
                (byte)((value >> 24) & 0xFF), 
                (byte)((value >> 32) & 0xFF), 
                (byte)((value >> 40) & 0xFF), 
                (byte)((value >> 48) & 0xFF), 
                (byte)((value >> 56) & 0xFF) 
            };
        }

        public static unsafe byte[] GetBytes(float value)
        {
            var val = *((int*)&value);
            return GetBytes(val);
        }

        public static unsafe byte[] GetBytes(double value)
        {
            var val = *((long*)&value);
            return GetBytes(val);
        }

        public static bool ToBoolean(byte[] value, int index = 0)
        {
            return value[index] != 0;
        }

        public static char ToChar(byte[] value, int index = 0)
        {
            return (char)(value[0 + index] << 0 | value[1 + index] << 8);
        }

        public static short ToInt16(byte[] value, int index = 0)
        {
            return (short)(value[0 + index] << 0 | value[1 + index] << 8);
        }

        public static int ToInt32(byte[] value, int index = 0)
        {
            return
                (
                value[0 + index] << 0 |
                value[1 + index] << 8 |
                value[2 + index] << 16 |
                value[3 + index] << 24
                );
        }

        public static long ToInt64(byte[] value, int index = 0)
        {
            return
                (
                (long)value[0 + index] << 0 |
                (long)value[1 + index] << 8 |
                (long)value[2 + index] << 16 |
                (long)value[3 + index] << 24 |
                (long)value[4 + index] << 32 |
                (long)value[5 + index] << 40 |
                (long)value[6 + index] << 48 |
                (long)value[7 + index] << 56
                );
        }

        public static ushort ToUInt16(byte[] value, int index = 0)
        {
            return (ushort)(value[0 + index] << 0 | value[1 + index] << 8);
        }

        public static uint ToUInt32(byte[] value, int index = 0)
        {
            return (uint)
                (
                value[0 + index] << 0 |
                value[1 + index] << 8 |
                value[2 + index] << 16 |
                value[3 + index] << 24
                );
        }

        public static ulong ToUInt64(byte[] value, int index = 0)
        {
            return
                (
                (ulong)value[0 + index] << 0 |
                (ulong)value[1 + index] << 8 |
                (ulong)value[2 + index] << 16 |
                (ulong)value[3 + index] << 24 |
                (ulong)value[4 + index] << 32 |
                (ulong)value[5 + index] << 40 |
                (ulong)value[6 + index] << 48 |
                (ulong)value[7 + index] << 56
                );
        }

        public static unsafe float ToSingle(byte[] value, int index = 0)
        {
            var i = ToInt32(value);
            return *(((float*)&i));
        }

        public static unsafe double ToDouble(byte[] value, int index = 0)
        {
            var l = ToInt64(value);
            return *(((double*)&l));
        }

        public static string ToString(byte[] value, int index = 0)
        {
            return ToString(value, index, value.Length - index);
        }

        public static string ToString(byte[] value, int index, int length)
        {
            var c = new char[length * 3];
            for (int y = 0, x = 0; y < length; ++y, ++x)
            {
                var b = (byte)(value[index + y] >> 4);
                c[x] = (char)(b > 9 ? b + 0x37 : b + 0x30);
                b = (byte)(value[index + y] & 0xF);
                c[++x] = (char)(b > 9 ? b + 0x37 : b + 0x30);
                c[++x] = '-';
            }
            return new string(c, 0, c.Length - 1);
        }
    }
}
