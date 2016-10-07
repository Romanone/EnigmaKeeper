using System;
using System.IO;
using EnigmaKeeper.Password;

namespace EnigmaKeeper.BL
{
    public interface IStorageController
    {
        void SaveToStorage(string path);
        void ReadFromStorage(string path);
    }

    public class StorageController : IStorageController
    {
        private readonly IPassword _password;

        public StorageController()
        {
            _password = new ConcretePassword();
        }

        public bool IsExist(string path)
        {
            DirectoryInfo Directory = new DirectoryInfo(path);

            if (Directory.Exists)
            {
                return true;
            }
            return false;
        }

        public void SaveToStorage(string path)
        {
            var file = new FileInfo(path);
            if (!file.Exists)
            {
                file = new FileInfo(path); //TODO
                FileStream stream = file.Create();
                stream.Close();
            }

            StreamWriter writer = file.CreateText();

            for (int i = 0; i < _password.GetPasswordCount(); i++)
            {
                writer.WriteLine(_password.GetPassword(i).Name + ";"
                    + _password.GetPassword(i).Login + ";"
                    + _password.GetPassword(i).Password + ";"
                    + _password.GetPassword(i).Encrypted + ";");
            }
            writer.Close();

        }

        public void ReadFromStorage(string path)
        {
            StreamReader reader = new StreamReader(path);
            string lineBeforeSplit;

            while ((lineBeforeSplit = reader.ReadLine()) != null)   
            {
                string[] line = lineBeforeSplit.Split(';');
                _password.AddPassword(line[0], line[1], line[2], Convert.ToBoolean(line[3]));
                
            }

            reader.Close();
        }
    }
}
