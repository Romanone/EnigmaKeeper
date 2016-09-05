using System;
using System.Collections.Generic;
using System.Linq;

namespace EnigmaKeeper.Password
{
    public interface IPassword
    {
        void AddPassword(string name, string login, string password, bool encrypted);
        void RemovePassword(string name);
        void UpdatePassword(string oldName, string name, string login, string password);
        void RemoveAllPasswords();
        IPassword GetPassword(string name);
        IPassword GetPassword(int index);
        void SetGodPassword(string password, string oldPassword);
        int GetPasswordCount();
        void EncryptAll();
        void DecryptAll();
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        bool Encrypted { get; set; }

        bool CheckControlWord();
        void SetControlWord(string controlWord);

        //string ControlWord { get; set; }

    }

    internal class ConcretePassword : IPassword
    {
        private static List<ConcretePassword> PasswordBox = new List<ConcretePassword>();

        public ConcretePassword() { }

        private ConcretePassword(string name, string login, string password, bool encrypted)
        {
            Name = name;
            Login = login;
            Password = password;
            Encrypted = encrypted;
        }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Encrypted { get; set; }

        private string godPassword = null;


        private string ControlWord { get; set; }

        public void AddPassword(string name, string login, string password, bool encrypted) //Add password in PasswordBox using constructor 
        {
            if (String.IsNullOrEmpty(name))
                return;
            foreach (var item in PasswordBox)
            {
                if(name == item.Name)
                {
                    return;
                }
            }
            PasswordBox.Add(new ConcretePassword(name, login, password, encrypted));
        }

        public IPassword GetPassword(string name)
        {
            foreach (var item in PasswordBox)
            {
                if (item.Name == name)
                {
                    return item;
                }  
            }
            return null;
        }

        public IPassword GetPassword(int index)
        {
            return PasswordBox[index];
        }

        public void SetGodPassword(string password, string oldPassword)
        {
            //if (godPassword == null)
            //{
                godPassword = password;
                //return;
            //}

            //else
            //{
            //    if (oldPassword == godPassword)
            //    {
            //        godPassword = password;
            //        return;
            //    }
            //}
        }

        public int GetPasswordCount()
        {
            return PasswordBox.Count;
        }

        public void EncryptAll() //Encrypt all unencrypted password in PasswordBox
        {
            SetControlWord(PasswordBox[0].Login);

            for (int i = 0; i < PasswordBox.Count; i++)
            {
                if (PasswordBox[i].Encrypted == false)
                {
                    PasswordBox[i].Login = Encryptor.EncryptProcess(PasswordBox[i].Login, godPassword);
                    PasswordBox[i].Password = Encryptor.EncryptProcess(PasswordBox[i].Password, godPassword);
                    PasswordBox[i].Encrypted = true;
                }
            }
        }

        public void DecryptAll() //Decrypt all undecrypted password in PasswordBox
        {
            for (int i = 0; i < PasswordBox.Count(); i++)
            {
                if (PasswordBox[i].Encrypted == true)
                {
                    PasswordBox[i].Login = Encryptor.EncryptProcess(PasswordBox[i].Login, godPassword);
                    PasswordBox[i].Password = Encryptor.EncryptProcess(PasswordBox[i].Password, godPassword);
                    PasswordBox[i].Encrypted = false;
                }
            }

            CheckControlWord();
        }

        public void RemovePassword(string name)
        {
            int index = 0;

            foreach (var item in PasswordBox)
            {
                if(name == item.Name)
                {
                    index = PasswordBox.IndexOf(item);
                }
            }

            PasswordBox.RemoveAt(index);
        }

        public void UpdatePassword(string oldName, string name, string login, string password)
        {
            foreach (var item in PasswordBox)
            {
                if (oldName == item.Name)
                {
                    item.Name = name;
                    item.Login = login;
                    item.Password = password;
                }
            }
        }

        public void RemoveAllPasswords()
        {
            PasswordBox.Clear();
        }

        public bool CheckControlWord()
        {
            if(ControlWord == PasswordBox[0].Login)
            {
                return true;
            }

            return false;
        }

        public void SetControlWord(string controlWord)
        {
            ControlWord = controlWord;
        }
    }
}
