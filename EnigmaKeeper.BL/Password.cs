using System;
using System.Collections.Generic;

namespace EnigmaKeeper.Password
{
    public interface IPassword
    {
        string Name { get; set; }
        string Login { get; set; }
        bool Encrypted { get; set; }
        string Password { get; set; }
        
        int GetPasswordCount();
        void RemoveAllPasswords();
        void RemovePassword(string name);
        IPassword GetPassword(int index);
        IPassword GetPassword(string name);
        void AddPassword(string name, 
                         string login, 
                         string password, 
                         bool encrypted);
        void UpdatePassword(string oldName, 
                            string name, 
                            string login, 
                            string password);
    }

    internal class ConcretePassword : IPassword
    {

        #region *** Constructors ***

        public ConcretePassword() { }

        private ConcretePassword(string name, string login, string password, bool encrypted)
        {
            Name = name;
            Login = login;
            Password = password;
            Encrypted = encrypted;
        }

        #endregion *** End of Constructor ***

        #region *** Properties & Fieds ***

        public string Name { get; set; }
        public string Login { get; set; }
        public bool Encrypted { get; set; }
        public string Password { get; set; }
        private static List<ConcretePassword> PasswordBox = new List<ConcretePassword>();

        #endregion *** End of Properties & Fieds ***

        #region *** Methods ***

        public int GetPasswordCount()                   //Return count of passwords in PasswordBox
        {
            return PasswordBox.Count;
        }
        public void RemoveAllPasswords()                //Remove all passwords from PasswordBox
        {
            PasswordBox.Clear();
        }
        public void RemovePassword(string name)         //Remove password by name
        {
            int index = 0;

            foreach (var item in PasswordBox)
            {
                if (name == item.Name)
                {
                    index = PasswordBox.IndexOf(item);
                }
            }

            PasswordBox.RemoveAt(index);
        }
        public IPassword GetPassword(int index)         //Return password by index
        {
            return PasswordBox[index];
        }        
        public IPassword GetPassword(string name)       //Return password by name
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
        public void AddPassword(string name, 
                                string login, 
                                string password, 
                                bool encrypted)         //Add password to PasswordBox throw constructor
        {
            if (String.IsNullOrEmpty(name))
            {
                return;
            }

            foreach (var item in PasswordBox)
            {
                if(name == item.Name)
                {
                    return;
                }
            }
            PasswordBox.Add(new ConcretePassword(name, login, password, encrypted));
        }        
        public void UpdatePassword(string oldName, 
                                   string name, 
                                   string login, 
                                   string password)     //Update password
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

        #endregion *** End of Methods ***

    }
}
