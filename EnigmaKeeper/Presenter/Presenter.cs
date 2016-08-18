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

            this.main.ReturnByPasswordEvent += Main_ReturnByPasswordEvent;
            this.main.LoadPasswordEvent += Main_LoadPasswordEvent;
            this.main.EncryptAllEvent += Main_EncryptAllEvent;
            this.main.DecryptAllEvent += Main_DecryptAllEvent;
        }


        #endregion

        #region *** Main Event Handler ***

        private void Main_DecryptAllEvent(object sender, EventArgs e)
        {
            model.DecryptAll();
        }

        private void Main_EncryptAllEvent(object sender, EventArgs e)
        {
            model.EncryptAll();
        }

        private object Main_ReturnByPasswordEvent(string name)
        {
            return model.ReturnByName(name);
        }

        private IPassword Main_LoadPasswordEvent(int index)
        {
            return model.GetPassword(index) as IPassword;
        }

        #endregion



        private void NewPasswordWindow_AddPasswordEvent(string name, string login, string password)
        {
            model.AddPassword(name, login, password);
        }

        private void GodPassword_AddGodPasswordEvent(string godPassword)
        {
            model.SetGodPassword(godPassword);
        }

        public int GetPasswordCount()
        {
            model = new Model(); //TODO: do it
            return model.GetPasswordCount();
        }

    }
}
