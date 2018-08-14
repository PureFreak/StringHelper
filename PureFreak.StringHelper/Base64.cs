using System;
using System.Text;

namespace PureFreak.StringHelper
{
    public static class Base64
    {
        #region Encode

        public static string Encode(byte value)
        {
            return Encode(value.ToString());
        }

        public static string Encode(int value)
        {
            return Encode(value.ToString());
        }

        public static string Encode(short value)
        {
            return Encode(value.ToString());
        }

        public static string Encode(float value)
        {
            return Encode(value.ToString());
        }

        public static string Encode(double value)
        {
            return Encode(value.ToString());
        }

        public static string Encode(decimal value)
        {
            return Encode(value.ToString());
        }

        public static string Encode(string value)
        {
            var data = Encoding.UTF8.GetBytes(value ?? string.Empty);
            return Convert.ToBase64String(data);
        }

        #endregion

        #region Decode

        public static string Decode(string value)
        {
            var data = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(data);
        }

        #endregion
    }
}