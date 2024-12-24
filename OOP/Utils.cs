using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Utils
    {
        public static User registerUser(string username, string password)
        {
            String passwordHash = sha256_hash(password);
            User user = Database.addUser(username, passwordHash);
            return user;
        }
        public static User loginUser(string username, string password)
        {
            String passwordHash = sha256_hash(password);
            User user = Database.getUser(username, passwordHash);
            return user;
        }
        public static String sha256_hash(string data)
        {
            using (SHA256 sha256 = SHA256.Create()) {
                return String.Concat(sha256.ComputeHash(Encoding.UTF8.GetBytes(data)).Select(item => item.ToString("x2")));
            }
        }
    }
}
