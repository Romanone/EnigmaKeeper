using System;
using EnigmaKeeper.Models;
using EnigmaKeeper.DataAccess;

namespace EnigmaKeeper
{
    class Presenter
    {
        NewPasswordWindow newPasswordWindow = null;
        GodPasswordWindow godPassword = null;
        IModel model = null;
        Main main = null;
        //IPassword password = null;

        #region *** Constructors ***
        public Presenter() { }
        public Presenter(GodPasswordWindow godPassword)
        {
            this.godPassword = godPassword;
            this.model = new Model();
            this.godPassword.AddGodPasswordEvent += GodPassword_AddGodPasswordEvent;
        }

        public Presenter(NewPasswordWindow newPasswordWindow)
        {
            this.newPasswordWindow = newPasswordWindow;
            this.model = new Model();
            this.newPasswordWindow.AddPasswordEvent += NewPasswordWindow_AddPasswordEvent;
        }

        public Presenter(Main main)
        {
            this.main = main;
            this.model = new Model();
            //this.main.Encrypt += new EventHandler(main_EncryptEvent);
            //this.main.Search += new EventHandler(main_SearchPasswordEvent);
            this.main.LoadPasswordEvent += Main_LoadPasswordEvent;
        }
        #endregion

        #region *** Event Handler ***
        
        private IPassword Main_LoadPasswordEvent(int index)
        {
            return model.GetPassword(index) as IPassword;
        }

        private void NewPasswordWindow_AddPasswordEvent(string name, string login, string password)
        {
            model.AddPassword(name, login, password);
        }

        private void GodPassword_AddGodPasswordEvent(string godPassword)
        {
            model.SetGodPassword(godPassword);
        }

        //void main_EncryptEvent(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < RegularPassword.GetPasswordCount(); i++)
        //    {
        //        model.LoadPassword(i);
        //        model.EncryptField(model.Name, main.Password);
        //        model.EncryptField(model.Login, main.Password);
        //        model.EncryptField(model.Password, main.Password);
        //    }
        //}

        //void main_SearchPasswordEvent(object sender, EventArgs e)
        //{
        //    main.Name = this.model.SearchPassword(main.PasswordName).Name;
        //    main.Login = this.model.SearchPassword(main.PasswordName).Login;
        //    main.Password = this.model.SearchPassword(main.PasswordName).Password;
        //}
        #endregion

        //public int PasswordCounter() // Повертає кількість паролей в списку
        //{
        //    model.PasswordsCounter();
        //    return model.PasswordCount;
        //}

        //public void LoadPasswordPresenter(int index) // Повертає імя, логін, пароль
        //{
        //    model.LoadPassword(index);
        //}

    }
}
