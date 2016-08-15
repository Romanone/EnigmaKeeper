using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper
{
    public interface IModel
    {
        string EncryptField(string text, string key);
        void CreatePassword(string name, string login, string password);
        void SetGodPassword();


    }

    class Model : IModel
    {
        public string EncryptField(string text, string key)
        {
             return Encryptor.EncryptProcess(text, key);
        }

        public void CreatePassword(string name, string login, string password)
        {
            RegularPassword.CreatePassword(name, login, password);
        }

        public void SetGodPassword()
        {
            RegularPassword.GodPassword = GodPasswordWindow.GodPassword;
        }

    }
}
