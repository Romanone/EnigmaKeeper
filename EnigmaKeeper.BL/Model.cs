using System;
using EnigmaKeeper.Password;
using EnigmaKeeper.Encryptor;

namespace EnigmaKeeper.BL
{
    public interface IModel : IPassword, IStorageController
    {
        void EncryptAll();
        void DecryptAll();
        string ControlWord { get; set; }
        void SetControlWord(string controlWord);
        bool CheckControlWord(string controlWord);
        void SetGodPassword(string godPassword, string oldPassword);
    }

    public class Model : IModel
    {
        #region *** Properties & Fields ***

        public string Name { get; set; }
        public string Login { get; set; }
        public bool Encrypted { get; set; }
        public string Password { get; set; }
        public string ControlWord { get; set; }
        private string GodPassword { get; set; } // тут тепер головний пасс

        private readonly IPassword _password;
        private readonly IEncryptor _encryptor;
        private readonly IStorageController _storageController;

        #endregion *** End of Properties & Fields *** 

        #region *** Constructors ***

        public Model(object encryptor, object storageController)
        {
            _password = new ConcretePassword();

            if (encryptor is XOR_EncryptorController)
            {
                _encryptor = encryptor as XOR_EncryptorController;
            }
            
            if(storageController is FILE_StorageController)
            {
                _storageController = storageController as FILE_StorageController;
            }
        }

        #endregion *** End of Constructors ***

        #region *** Methods ***

        public void EncryptAll()                        //Encrypt all
        {
            for (int i = 0; i < _password.GetPasswordCount(); i++)
            {
                if (_password.GetPassword(i).Encrypted == false)
                {
                    _password.GetPassword(i).Login = _encryptor.StartEncrypt(_password.GetPassword(i).Login, GodPassword);
                    _password.GetPassword(i).Password = _encryptor.StartEncrypt(_password.GetPassword(i).Password, GodPassword);
                    _password.GetPassword(i).Encrypted = _password.GetPassword(i).Encrypted = true;
                }

                if (CheckControlWord(ControlWord) == true)
                {
                    ControlWord = _encryptor.StartEncrypt(ControlWord, GodPassword);
                }
            }
        }

        public void DecryptAll()                        //Decrypt all
        {
            if (CheckControlWord(ControlWord) == false)
            {
                if (CheckControlWord(_encryptor.StartEncrypt(ControlWord, GodPassword)) == false)
                {
                    return;
                }

                else
                {
                    ControlWord = _encryptor.StartEncrypt(ControlWord, GodPassword);
                }
            }

            for (int i = 0; i < _password.GetPasswordCount(); i++)
            {
                if (_password.GetPassword(i).Encrypted == true)
                {
                    _password.GetPassword(i).Login = _encryptor.StartEncrypt(_password.GetPassword(i).Login, GodPassword);
                    _password.GetPassword(i).Password = _encryptor.StartEncrypt(_password.GetPassword(i).Password, GodPassword);
                    _password.GetPassword(i).Encrypted = _password.GetPassword(i).Encrypted = false;

                }
            }
        }

        public void SetGodPassword(string godPassword, 
                                   string oldPassword)  //Set God password
        {
            GodPassword = godPassword;
            SetControlWord("control Word");
        }

        public void AddPassword(string name, 
                                string login, 
                                string password, 
                                bool encrypted)         //Add new password
        {
            this._password.AddPassword(name, login, password, encrypted);
        }

        public IPassword GetPassword(int index)         //Return password by index
        {
            return _password.GetPassword(index);
        }

        public IPassword GetPassword(string name)       //Return password by name
        {
            return _password.GetPassword(name);
        }

        public int GetPasswordCount()                   //Return count of passwords
        {
            return _password.GetPasswordCount();
        }

        public void RemoveAllPasswords()                //Remove all passwords
        {
            _password.RemoveAllPasswords();
        }

        public void RemovePassword(string name)         //Remove password by name
        {
            _password.RemovePassword(name);
        }

        public void UpdatePassword(string oldName,
                           string name,
                           string login,
                           string password)             //Update password
        {
            _password.UpdatePassword(oldName, name, login, password);
        }

        public void SaveToStorage(string path)          //Save to storage
        {
            _storageController.SaveToStorage(path);
        }

        public void ReadFromStorage(string path)        //Read from storage
        {
            _storageController.ReadFromStorage(path);
            SetControlWord("control Word"); // зчитати його
        }
                
        public bool CheckControlWord(string controlWord)//Check control word
        {
            if (controlWord == "control Word")
            {
                return true;
            }
            return false;
        }

        public void SetControlWord(string controlWord)  //Set control word
        {
            if (String.IsNullOrEmpty(ControlWord))
            {
                ControlWord = controlWord;
            }            
        }

        #endregion *** End of Methods ***

    }
}
