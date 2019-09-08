using System;
using System.Security.Cryptography;
using System.Text;

namespace LL.Store.UI.Infra.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string senha)
        {
            var salt = "|5B423C9DAF4A4698863D0B2372BEE5DB58D4433F212E4CCD907332C846597A5C";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);
            byte[] hashBytes;

            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
