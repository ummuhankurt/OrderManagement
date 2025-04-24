using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    internal static class CryptoHelper
    {

        public static string EncryptPassword(string password)
        {
            string result = "";
            foreach (char c in password)
            {
                result += (char)(c + 3);
            }
            return result;
        }

    }
}
