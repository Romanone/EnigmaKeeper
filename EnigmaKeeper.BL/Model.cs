using EnigmaKeeper.Password;

namespace EnigmaKeeper.BL
{
    public interface IModel : IPassword, IFileController
    {
        // for future
    }

    public class Model : IModel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Encrypted { get; set; }

        private readonly IPassword _password;
        private readonly IFileController _fileController;

        public Model()
        {
            _password = new ConcretePassword();
            _fileController = new FileController();
        }

        public void AddPassword(string name, string login, string password, bool encrypted) //Add new password
        {
            this._password.AddPassword(name, login, password, encrypted);
        }

        public IPassword GetPassword(int index) //Return password by index
        {
            return _password.GetPassword(index);
        }

        public IPassword GetPassword(string name) //Return password by name
        {
            return _password.GetPassword(name);
        }

        public void SetGodPassword(string godPassword, string oldPassword) //Set GOD password
        {
            _password.SetGodPassword(godPassword, oldPassword);
        }

        public int GetPasswordCount() //Return count of passwords
        {
            return _password.GetPasswordCount();
        }  
              
        public void EncryptAll() //Encrypt all 
        {
            _password.EncryptAll();
        }

        public void DecryptAll() //Decrypt all
        {
            _password.DecryptAll();
        }

        public void WriteToFile(string path)
        {
            _fileController.WriteToFile(path);
        }

        public void ReadFromFile(string path)
        {
            _fileController.ReadFromFile(path);
        }

        public void RemovePassword(string name)
        {
            _password.RemovePassword(name);
        }
        public void UpdatePassword(string oldName, string name, string login, string password)
        {
            _password.UpdatePassword(oldName, name, login, password);
        }

        public void RemoveAllPasswords()
        {
            _password.RemoveAllPasswords();
        }

        public bool CheckControlWord()
        {
            return _password.CheckControlWord();
        }

        public void SetControlWord(string controlWord)
        {
            _password.SetControlWord(controlWord);
        }

    }
}
