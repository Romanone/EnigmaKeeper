using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EnigmaKeeper.Password;

namespace EnigmaKeeper.BL
{
    public interface IFileController
    {
        void WriteToFile(string path);
        void ReadFromFile(string path);
    }

    public class FileController : IFileController
    {
        private readonly IPassword _password;

        public FileController()
        {
            _password = new ConcretePassword();
        }

        //public static string Path { get; set; }

        //DirectoryInfo Directory = new DirectoryInfo(Path.ToString());

        public bool IsExist(string path)
        {
            DirectoryInfo Directory = new DirectoryInfo(path);

            if (Directory.Exists)
            {
                return true;
            }
            return false;
        }

        public void WriteToFile(string path)
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
                    + _password.GetPassword(i).Password);
            }
            writer.Close();

        }

        public void ReadFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            string lineBeforeSplit;

            while ((lineBeforeSplit = reader.ReadLine()) != null)   
            {
                string[] line = lineBeforeSplit.Split(';');
                _password.AddPassword(line[0], line[1], line[2]);
            }
            reader.Close();
        }
    }
}
