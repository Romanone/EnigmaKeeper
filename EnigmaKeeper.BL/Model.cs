﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaKeeper.DataAccess;
using EnigmaKeeper.Models;

namespace EnigmaKeeper.Models
{
    public interface IModel : IPassword
    {


    }

    class Model : IModel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        private readonly IPassword _password;

        public void AddPassword(string name, string login, string password) //Add new password
        {
            this._password.AddPassword(name, login, password);
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
    }
}