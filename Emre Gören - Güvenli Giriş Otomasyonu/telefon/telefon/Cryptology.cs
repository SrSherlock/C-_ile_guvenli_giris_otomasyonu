using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefon
{
    class Cryptology
    {
        /* sezar algoritma şifreleme 
         * öteleme haraketi yapar
         * abc key=2 cde yapar
         */
       public static string Encryption(string text ,int key)
        {
            char[] sifreleme = text.ToCharArray();
            string encryptionText = null;
            foreach (char item in sifreleme)
            {
                encryptionText += Convert.ToChar(item + key);
            }
            return encryptionText;
        }
        public static string Decryption(string text, int key)
        {
            char[] sifreleme = text.ToCharArray();
            string decryptionText = null;
            foreach (char item in sifreleme)
            {
                decryptionText += Convert.ToChar(item - key);
            }
            return decryptionText;
        }
    }
}
