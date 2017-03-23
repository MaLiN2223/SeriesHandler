using System.Security.Cryptography;
using System.Text;

namespace ServerLibrary
{
    public static class Security
    {
        public static byte[] Hash(this string password)
        {
            using (var alg = SHA256.Create())
            {
                return alg.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static string GetString(this byte[] array)
        {
            StringBuilder builder = new StringBuilder(array.Length);
            foreach (var item in array)
            {
                builder.Append((char)item);
            }
            return builder.ToString();
        }
    }
}