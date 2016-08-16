﻿using System;
using EnigmaKeeper.Models;

namespace EnigmaKeeper
{
    class Presenter
    {
        NewPasswordWindow newPasswordWindow = null;
        GodPasswordWindow godPassword = null;
        Model model = null;
        Main main = null;

        #region *** Constructors ***
        public Presenter() { }
        public Presenter(GodPasswordWindow godPassword)
        {
            this.godPassword = godPassword;
            this.model = new Model();
            this.godPassword.NewGodPassword += new EventHandler(godPasswordWindow_GodPasswordEvent);
        }
        public Presenter(NewPasswordWindow newPasswordWindow)
        {
            this.newPasswordWindow = newPasswordWindow;
            this.model = new Model();
            this.newPasswordWindow.NewPassword += new EventHandler(newPasswordWindow_NewPasswordEvent);
        }
        public Presenter(Main main)
        {
            this.main = main;
            this.model = new Model();
            this.main.Encrypt += new EventHandler(main_EncryptEvent);
            this.main.Search += new EventHandler(main_SearchPasswordEvent);
            this.main.LoadPassword += Main_LoadPassword;
        }

        private void Main_LoadPassword(object sender, EventArgs e)
        {
            LoadPasswordPresenter(main.Index);
            main.Name = model.Name;
            main.Login = model.Login;
            main.Password = model.Password;
        }
        #endregion

        #region *** Event Handler ***
        void newPasswordWindow_NewPasswordEvent(object sender, EventArgs e)
        {
            this.model.CreatePassword(newPasswordWindow.Name, newPasswordWindow.Login, newPasswordWindow.Password);
        }

        void godPasswordWindow_GodPasswordEvent(object sender, EventArgs e)
        {
            this.model.SetGodPassword(GodPasswordWindow.GodPassword);
        }

        void main_EncryptEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < RegularPassword.GetPasswordCount(); i++)
            {
                RegularPassword.GetPassword(i).Name = this.model.EncryptField(RegularPassword.GetPassword(i).Name, RegularPassword.GodPassword);
                RegularPassword.GetPassword(i).Login = this.model.EncryptField(RegularPassword.GetPassword(i).Login, RegularPassword.GodPassword);
                RegularPassword.GetPassword(i).Password = this.model.EncryptField(RegularPassword.GetPassword(i).Password, RegularPassword.GodPassword);//TODO тут переробити через модель
            }
        }

        void main_SearchPasswordEvent(object sender, EventArgs e)
        {
            main.Name = this.model.SearchPassword(main.PasswordName).Name;
            main.Login = this.model.SearchPassword(main.PasswordName).Login;
            main.Password = this.model.SearchPassword(main.PasswordName).Password;
        }
        #endregion

        public int PasswordConter() // Повертає кількість паролей в списку
        {
            return model.PasswordCount;
        }

        public void LoadPasswordPresenter(int index) // Повертає імя, логін, пароль
        {
            model.LoadPassword(index);
        }
    }
}
