using System;
using System.Security.Cryptography;
using System.Text;

namespace PureFreak.StringHelper
{
    public static class Md5
    {
        #region Fields

        private static readonly MD5 _md5 = MD5.Create();

        #endregion

        #region Hash

        public static string Create(string value)
        {
            return Create(value, Encoding.UTF8);
        }

        public static string Create(string value, Encoding encoding)
        {
            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            var stringData = encoding.GetBytes(value);
            var hashData = _md5.ComputeHash(stringData);

            return BitConverter.ToString(hashData)
                .Replace("-", string.Empty);
        }

        #endregion
    }
}