﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper
{
    class RegularPassword : IPassword
    {
        private static List<RegularPassword> PasswordBox = new List<RegularPassword>();

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Encrypted { get; set; }

        public static string GodPassword { get; set; } // Main password

        private RegularPassword(string name, string login, string password, bool encrypted)
        {
            Name = name;
            Login = login;
            Password = password;
            Encrypted = encrypted;
        }

        public static void CreatePassword(string name, string login, string password)
        {
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(login) && String.IsNullOrEmpty(password))
                return;
            PasswordBox.Add(new RegularPassword(name, login, password, false));
        }

        public static RegularPassword LoadPassword(int index)
        {
            return PasswordBox[index];
        }

        public static int GetPasswordCount()
        {
            return PasswordBox.Count;
        }
    }
}