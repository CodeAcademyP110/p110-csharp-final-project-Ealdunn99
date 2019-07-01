using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FitnessClub.Utilities
{
    public static class Hash
    {
        public static string GetHash(string password)
        {
            byte[] bytes = new ASCIIEncoding().GetBytes(password);
            byte[] encrytedBytes = new SHA256Managed().ComputeHash(bytes);
            return new ASCIIEncoding().GetString(encrytedBytes);
        }

        public static bool CheckHash(string hashedWord, string word)
        {
            return hashedWord == GetHash(word);
        }
    }

    public enum Roles : byte
    {
        Admin = 1,
        Cashier = 2,
        
    }
}
