
using System;
using System.Text;

namespace Assignment_2_Server.Security
{
    public static class Helper
    {
        private const string Key = "adef@@kfxcbv@";

        public static string Encrypt(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            text += Key;
            var textBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBytes);
        }

        public static string Decrypt(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            var textBytes = Convert.FromBase64String(text);
            var result = Encoding.UTF8.GetString(textBytes);
            result = result[..^Key.Length];
            return result;
        }
    }
}