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
    public delegate void AddPassword(string name, string login, string password);

    public partial class NewPasswordWindow : Form
    {
        public NewPasswordWindow()
        {
            InitializeComponent();
            //new Presenter(this);
        }

        public event AddPassword AddPasswordEvent = null;

        private void AddPassword(object sender, EventArgs e)
        {
            AddPasswordEvent.Invoke(tbName.Text, tbLogin.Text, tbPassword.Text);
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            AddPassword(sender, e);
        }

        private void btnSaveAndClosePassword_Click(object sender, EventArgs e)
        {
            AddPassword(sender, e);
            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

    }
}
