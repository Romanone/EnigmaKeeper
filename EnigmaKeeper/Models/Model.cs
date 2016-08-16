using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper.Models
{
    public interface IModel
    {
        string EncryptField(string text, string key);
        void CreatePassword(string name, string login, string password);
        void SetGodPassword(string godPassword);
    }

    class Model : IModel
    {
        public string Name { get; set; } //GOOD
        public string Login { get; set; } //GOOD
        public string Password { get; set; } //GOOD
        public bool Encrypted { get; set; } //GOOD

        internal int PasswordCount { get; private set; }

        public string EncryptField(string text, string key)
        {
             return Encryptor.EncryptProcess(text, key);
        }

        public void CreatePassword(string name, string login, string password)
        {
            RegularPassword.AddPassword(name, login, password);
        }

        public void SetGodPassword(string godPassword)
        {
            RegularPassword.GodPassword = godPassword;
        }

        public RegularPassword SearchPassword(string name)
        {
            return RegularPassword.SearchPassword(name);
        }

        public int PasswordsCounter()
        {
            PasswordCount = RegularPassword.GetPasswordCount();
            return PasswordCount;
        }

        //public RegularPassword LoadPasswords(int index)
        //{
        //    return RegularPassword.GetPassword(index);
        //}

        public void LoadPassword(int index)
        {
            Name = RegularPassword.GetPassword(index).Name;
            Login = RegularPassword.GetPassword(index).Login;
            Password = RegularPassword.GetPassword(index).Password;
        }

    }
}
