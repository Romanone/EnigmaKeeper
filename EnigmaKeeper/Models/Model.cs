using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaKeeper.DataAccess;
using EnigmaKeeper.Models;

namespace EnigmaKeeper.Models
{
    public interface IModel
    {
        void AddPassword(string name, string login, string password);
        ConcretePassword GetPassword(int index);
        void SetGodPassword(string godPassword);
        object ReturnByName(string name);
        void EncryptAll();
        void DecryptAll();
        int GetPasswordCount();
    }

    class Model : IModel
    {
        private ConcretePassword password = new ConcretePassword();

        public void AddPassword(string name, string login, string password) //Add new password
        {
            this.password.AddPassword(name, login, password);
        }

        public ConcretePassword GetPassword(int index) //Return password by index
        {
            return password.GetPassword(index);
        }

        public string EncryptField(string text, string key) //Return encrypted/decrypted string
        {
            return Encryptor.EncryptProcess(text, key);
        }

        public int GetPasswordCount() //Return count of passwords
        {
            return ConcretePassword.GetPasswordCount();
        }

        public void SetGodPassword(string godPassword) //Set GOD password
        {
            ConcretePassword.GodPassword = godPassword;
        }

        public object ReturnByName(string name) //Return password by name
        {
            return ConcretePassword.ReturnByName(name);
        }

        public void EncryptAll() //Encrypt all 
        {
            ConcretePassword.EncryptAll();
        }

        public void DecryptAll() //Decrypt all
        {
            ConcretePassword.DecryptAll();
        }
    }
}
