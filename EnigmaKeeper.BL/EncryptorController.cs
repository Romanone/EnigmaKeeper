using System;
using System.Collections.Generic;

namespace EnigmaKeeper.Encryptor
{
    interface IEncryptor
    {
        string StartEncrypt(string text, string key);
    }
    
    internal class XOR_EncryptorController : IEncryptor
    {
        #region *** Properties ***

        private string EncryptedText { get; set; }
        private List<ulong> Keys = new List<ulong>();

        #endregion *** End of Properties ***

        #region *** Methods ***

        private int Divider(int lenght)                         //Diveder. Return count of needed devides
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

        private void StringToLong(string key)                   //Keymaker. String key to ULONG
        {
            if (String.IsNullOrWhiteSpace(key))
                return;
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
                int divides = Divider(strPreKey.Length);
                int i, j;
                for (i = 0, j = 1; i < divides; i++, j++)
                {
                    int a = i * (strPreKey.Length / divides);                           //Start index
                    int b = strPreKey.Length / divides;                                 //Lenght         
                    Keys.Add(Convert.ToUInt64(strPreKey.Substring((int)a, (int)b)));    //Ignores fractional share here
                }
            }
            else
            {
                Keys.Add(Convert.ToUInt64(strPreKey));
            }
        }

        public string StartEncrypt(string text, string key)     //Start of encryption process
        {
            StringToLong(key);
            DoEncrypt(text, Keys);
            return EncryptedText;
        }

        private void DoEncrypt(string text, List<ulong> keys)   //Encrypt using "XOR" operator
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

        #endregion *** End of Methods ***
    }
}
