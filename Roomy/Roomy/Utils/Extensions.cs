using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Roomy.Utils
{
    public static class Extensions
    {
        public static string HashMD5(this string value)
        {
            byte[] textBytes = System.Text.Encoding.Default.GetBytes(value);

            try
            {
                MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider();
                byte[] hash = crypto.ComputeHash(textBytes);

                return System.Text.Encoding.Default.GetString(hash);
            }
            catch
            {
                throw;
            }
        }
    }
}