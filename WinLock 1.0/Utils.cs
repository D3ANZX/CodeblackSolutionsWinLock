using System.Security.Cryptography;
using System.Text;

namespace com.codeBlack.winLock
{
    class Utils
    {
        public static string HashPassword(string password)
        {
            string salt = "AccessControlSystem2026";

            using (SHA256 sha256 = SHA256.Create())
            {
                string saltedPassword = password + salt;

                byte[] hash = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(saltedPassword));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in hash)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}
