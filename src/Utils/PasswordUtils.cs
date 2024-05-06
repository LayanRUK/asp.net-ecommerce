using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Utils
{
    public class PasswordUtils
    {
        public static void HashPassword(string plainePasssword, out string hashPassword, byte[] pepper)
        {
            var algo = new HMACSHA256(pepper);
            var passToByte = Encoding.UTF8.GetBytes(plainePasssword);
            hashPassword = BitConverter.ToString(algo.ComputeHash(passToByte));
        }
        public static bool VerifyPassword(string plainePassword, string hashedPassword, byte[] pepper)
        {
            HashPassword(plainePassword, out string hashToCompare, pepper);
            return hashToCompare == hashedPassword;
        }
    }
}