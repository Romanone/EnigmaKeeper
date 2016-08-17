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
    }

    class Model : IModel
    {
        private ConcretePassword password = new ConcretePassword();

        public void AddPassword(string name, string login, string password)
        {
            this.password.AddPassword(name, login, password);
        }

        public ConcretePassword GetPassword(int index)
        {
            return password.GetPassword(index);
        }

        public string EncryptField(string text, string key)
        {
            return Encryptor.EncryptProcess(text, key);
        }

        public int GetPasswordCount()
        {
            return ConcretePassword.GetPasswordCount();
        }

        public void SetGodPassword(string godPassword)
        {
            ConcretePassword.GodPassword = godPassword;
        }
    }
}
