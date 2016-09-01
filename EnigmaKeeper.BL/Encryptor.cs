using System;
using System.Collections.Generic;

namespace EnigmaKeeper.DataAccess
{
    public static class Encryptor
    {
        private static string EncryptedText { get; set; }
        private static List<ulong> Keys = new List<ulong>();

        public static string EncryptProcess(string text, string key) // Цей метод для виклику шифрування (методів реалізації та їх послідовності)
        {
            StringToLong(key);
            DoEncrypt(text, Keys);
            return EncryptedText;
        }

        private static void DoEncrypt(string text, List<ulong> keys) // Шифрування
        {
            EncryptedText = text;

            for (int i = 0; i < keys.Count; i++)
            {
                char[] characters = EncryptedText.ToCharArray();
                EncryptedText = String.Empty;
                foreach (char character in characters)
                {
                    EncryptedText += (char)(character ^ keys[i]);
                }
            }
        }

        private static void StringToLong(string key) // Keymaker
        {
            string strPreKey = null;
            Keys.Clear();
            char[] passwordCharacters = key.ToCharArray();
            foreach (char character in passwordCharacters)
            {
                int intPreKey = character;
                strPreKey += intPreKey;
            }

            if (strPreKey.Length > 19)
            {
                int i, j;
                for (i = 0, j = 1; i < Divider(strPreKey.Length); i++, j++)
                {
                    int a = i * (strPreKey.Length / Divider(strPreKey.Length));
                    int b = strPreKey.Length / Divider(strPreKey.Length);
                    Keys.Add(Convert.ToUInt64(strPreKey.Substring(a, b))); // тут можна впустити один символ через завкруглення інта
                }
            }
            else
            {
                Keys.Add(Convert.ToUInt64(strPreKey));
            }
        }

        private static int Divider(int lenght) // записати цей результат, так буде швидше, замість того щоб кожен раз обчислювати
        {
            int count = 1;
            int tempLength = lenght;
            while (tempLength > 19)
            {
                tempLength /= 2;
                count *= 2;

            }
            return count;
        }
    }
}
