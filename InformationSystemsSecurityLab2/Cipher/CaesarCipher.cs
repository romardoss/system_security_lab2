﻿using System.Windows;

namespace InformationSystemsSecurityLab2.Cipher
{
    public class CaesarCipher
    {
        public static string Encrypt(string input, int key)
        {
            char charKey = (char)key;
            char[] letters = input.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] += charKey;
            }
            return new string(letters);
        }

        public static string Encrypt(string input, string key)
        {
            if (ValidateKey(key))
            {
                return Encrypt(input, int.Parse(key));
            }
            return input;
        }

        public static string Decrypt(string input, string key)
        {
            if (ValidateKey(key))
            {
                return Encrypt(input, -int.Parse(key));
            }
            return input;
        }

        private static bool ValidateKey(string key)
        {
            if (int.TryParse(key, out _))
            {
                return true;
            }
            else
            {
                //тут можна ключ зі строки перевести у цифровий за кодами символів
                MessageBox.Show("Key must be a number");
                return false;
            }
        }
    }
}
