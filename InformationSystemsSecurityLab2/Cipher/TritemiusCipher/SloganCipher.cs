using System;
using System.Windows;

namespace InformationSystemsSecurityLab2.Cipher.TritemiusCipher
{
    public class SloganCipher : ICipher
    {

        public string Encrypt(string input, string key)
        {
            char[] letters = input.ToCharArray();
            char[] keyLetters = key.ToCharArray();
            for(int i = 0; i < letters.Length; i++)
            {
                letters[i] += keyLetters[(i+1) % keyLetters.Length];
            }
            return new string(letters);
        }

        public string Decrypt(string input, string key)
        {
            char[] letters = input.ToCharArray();
            char[] keyLetters = key.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] -= keyLetters[(i + 1) % keyLetters.Length];
            }
            return new string(letters);
        }

        public bool ValidateKey(string key)
        {
            if (double.TryParse(key, out _))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
