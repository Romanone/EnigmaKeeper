using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaKeeper
{
    public partial class NewPasswordWindow : Form
    {
        public NewPasswordWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public event EventHandler NewPassword = null; //GOOD

        private void SavePassword(object sender, EventArgs e) //GOOD
        {
            Name = tbName.Text;
            Login = tbLogin.Text;
            Password = tbPassword.Text;
            NewPassword.Invoke(sender, e);
        }

        private void btnSavePassword_Click(object sender, EventArgs e) //GOOD
        {
            SavePassword(sender, e);
        }

        private void btnSaveAndClosePassword_Click(object sender, EventArgs e) //GOOD
        {
            SavePassword(sender, e);
            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e) //GOOD
        {
            this.Close();
        }        

    }
}
