using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper
{
    class Presenter
    {
        NewPasswordWindow newPasswordWindow = null;
        GodPasswordWindow godPassword = null;
        Model model = null;
        Main main = null;

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
        }

        void newPasswordWindow_NewPasswordEvent(object sender, EventArgs e)
        {
            this.model.CreatePassword(newPasswordWindow.Name, newPasswordWindow.Login, newPasswordWindow.Password);
        }

        void godPasswordWindow_GodPasswordEvent(object sender, EventArgs e)
        {
            this.model.  CreatePassword(newPasswordWindow.Name, newPasswordWindow.Login, newPasswordWindow.Password);
        }

        void main_EncryptEvent(object sender, EventArgs e) //TODO todotest
        {
            //this.model.EncryptField(text, main.Key);  godPassword_NewPasswordEvent
        }






    }
}
