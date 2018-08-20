using System;

namespace PureFreak.StringHelper
{
    public static class StringParseExtensions
    {
        #region Methods

        public static bool ToBool(this string value, bool defaultValue = default(bool))
        {
            if (bool.TryParse(value, out bool result))
                return result;

            return defaultValue;
        }

        public static byte ToByte(this string value, byte defaultValue = default(byte))
        {
            if (byte.TryParse(value, out byte result))
                return result;

            return defaultValue;
        }

        public static sbyte ToSByte(this string value, sbyte defaultValue = default(sbyte))
        {
            if (sbyte.TryParse(value, out sbyte result))
                return result;

            return defaultValue;
        }

        public static short ToShort(this string value, short defaultValue = default(short))
        {
            if (short.TryParse(value, out short result))
                return result;

            return defaultValue;
        }

        public static ushort ToUShort(this string value, ushort defaultValue = default(ushort))
        {
            if (ushort.TryParse(value, out ushort result))
                return result;

            return defaultValue;
        }

        public static int ToInt(this string value, int defaultValue = default(int))
        {
            if (int.TryParse(value, out int result))
                return result;

            return defaultValue;
        }

        public static uint ToUInt(this string value, uint defaultValue = default(uint))
        {
            if (uint.TryParse(value, out uint result))
                return result;

            return defaultValue;
        }

        public static long ToLong(this string value, long defaultValue = default(long))
        {
            if (long.TryParse(value, out long result))
                return result;

            return defaultValue;
        }

        public static ulong ToULong(this string value, ulong defaultValue = default(ulong))
        {
            if (ulong.TryParse(value, out ulong result))
                return result;

            return defaultValue;
        }

        public static float ToFloat(this string value, float defaultValue = default(float))
        {
            if (float.TryParse(value, out float result))
                return result;

            return defaultValue;
        }

        public static double ToDouble(this string value, double defaultValue = default(double))
        {
            if (double.TryParse(value, out double result))
                return result;

            return defaultValue;
        }

        public static decimal ToDecimal(this string value, decimal defaultValue = default(decimal))
        {
            if (decimal.TryParse(value, out decimal result))
                return result;

            return defaultValue;
        }

        public static DateTime ToDateTime(this string value, DateTime defaultValue = default(DateTime))
        {
            if (DateTime.TryParse(value, out DateTime result))
                return result;

            return defaultValue;
        }

        #endregion
    }
}