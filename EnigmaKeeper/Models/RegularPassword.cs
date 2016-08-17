using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper.Models
{
    class RegularPassword
    {
        //private static List<RegularPassword> PasswordBox = new List<RegularPassword>(); //GOOD

        //public string Name { get; set; }
        //public string Login { get; set; }
        //public string Password { get; set; }
        //public bool Encrypted { get; set; }

        //public static string GodPassword { get; set; } // Main password

        //private RegularPassword(string name, string login, string password, bool encrypted) //GOOD
        //{
        //    Name = name;
        //    Login = login;
        //    Password = password;
        //    Encrypted = encrypted;
        //}

        //internal static void AddPassword(string name, string login, string password) //GOOD
        //{
        //    if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(login) && String.IsNullOrEmpty(password))
        //        return;
        //    PasswordBox.Add(new RegularPassword(name, login, password, false));
        //}

        //internal static RegularPassword GetPassword(int index)
        //{
        //    return PasswordBox[index];
        //}

        //internal static int GetPasswordCount() //GOOD
        //{
        //    return PasswordBox.Count;
        //}

        //internal static RegularPassword SearchPassword(string name)
        //{
        //    foreach (var item in PasswordBox)
        //    {
        //        if(item.Name == name)
        //        {
        //            return item;
        //        }    
        //    }
        //    return null;
        //}
    }
}
