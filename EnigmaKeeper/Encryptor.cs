using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper
{
    class Encryptor
    {
        private string EncryptedText { get; set; }
        public List<ulong> Keys = new List<ulong>(); //пріват зробити
        private char[] TextCharacters { get; set; }

        public string Encrypt(string text, string key) // Цей метод для виклику шифрування (методів реалізації та їх послідовності)
        {
            StringToLong(key);
            DoEncrypt(text, Keys);
            return EncryptedText;
        }

        //public string Decrypt(string text, string key) // Цей метод для виклику дешифрування (методів реалізації та їх послідовності)
        //{
        //    StringToLong(key);
        //    return DoEncrypt(text, Keys);
        //}

        private void DoEncrypt(string text, List<ulong> keys) // Шифрування
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

        public void StringToLong(string key) // зробити пріват
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

        private int Divider(int lenght) // записати цей результат, так буде швидше, замість того щоб кожен раз обчислювати
        {
            int count = 1;
            int tempLength = lenght;
            while (tempLength > 19)
            {
                tempLength /= 2;
                count*=2;

            }
            return count;
        }
    }
}
