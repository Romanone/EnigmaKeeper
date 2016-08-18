using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper.DataAccess
{
    public interface IPassword
    {
        int ID { get; set; }
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        bool Encrypted { get; set; }
        void AddPassword(string name, string login, string password);
        ConcretePassword GetPassword(int index);
    }

    public class ConcretePassword : IPassword
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Encrypted { get; set; }
        public static string GodPassword
        {
            get
            {
                return "1200"; //TODO: LOGIC HERE
            }

            set
            {
                GodPassword = value;
            }
        }
        private static List<ConcretePassword> PasswordBox = new List<ConcretePassword>();
        public ConcretePassword() { }
        private ConcretePassword(int ID, string name, string login, string password, bool encrypted)
        {
            this.ID = ID;
            Name = name;
            Login = login;
            Password = password;
            Encrypted = encrypted;
        }

        public void AddPassword(string name, string login, string password) //Add password in PasswordBox using concstructor 
        {
            if (String.IsNullOrEmpty(name) &&
                String.IsNullOrEmpty(login) &&
                String.IsNullOrEmpty(password))
                return;
            PasswordBox.Add(new ConcretePassword(0, name, login, password, false)); //TODO: Make some ID logic
        }

        public ConcretePassword GetPassword(int index) //Return password by index from PasswordBox
        {
            return PasswordBox[index];
        }

        public static int GetPasswordCount() //Return count of passwords in PasswordBox
        {
            return PasswordBox.Count;
        }

        public static void SetGodPassword(string godPassword) //Set GOD password for encrypt process
        {
            GodPassword = godPassword;
        }

        public static object ReturnByName(string name)
        {
            var query =
                from password in PasswordBox
                where password.Name == name
                select new ConcretePassword
                {
                    Name = password.Name,
                    Login = password.Login,
                    Password = password.Password
                };

            foreach (var item in query)
            {
                return item;
            }
            return null;
        }

        public static void EncryptAll() //Encrypt all unencrypted password in PasswordBox
        {
            for (int i = 0; i < GetPasswordCount(); i++)
            {
                if (PasswordBox[i].Encrypted == false)
                {
                    PasswordBox[i].Login = Encryptor.EncryptProcess(PasswordBox[i].Login, GodPassword);
                    PasswordBox[i].Password = Encryptor.EncryptProcess(PasswordBox[i].Password, GodPassword);

                    PasswordBox[i].Encrypted = true;
                }                
            }
        }

        public static void DecryptAll() //Decrypt all undecrypted password in PasswordBox
        {
            for (int i = 0; i < GetPasswordCount(); i++)
            {
                if (PasswordBox[i].Encrypted == true)
                {
                    PasswordBox[i].Login = Encryptor.EncryptProcess(PasswordBox[i].Login, GodPassword);
                    PasswordBox[i].Password = Encryptor.EncryptProcess(PasswordBox[i].Password, GodPassword);

                    PasswordBox[i].Encrypted = false;
                }                
            }
        }

    }
}
