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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public string Key { get; set; }
        //private static string name;
        //private static string login;
        //private static string password;

        public event EventHandler Encrypt = null;

        private void EncryptProcess(object sender, EventArgs e)
        {
            Encrypt.Invoke(sender, e);
        }




        private void tsm_OpenNewPasswordWindow_Click(object sender, EventArgs e)
        {
            NewPasswordWindow newPasswordWindow = new NewPasswordWindow();
            newPasswordWindow.ShowDialog();
        }

        private void btnLoadPasswords_Click(object sender, EventArgs e)
        {
            tvPasswordList.Nodes.Clear();
            for (int i = 0; i < RegularPassword.GetPasswordCount(); i++)
            {
                RegularPassword.LoadPassword(i);
                tvPasswordList.Nodes.Add(RegularPassword.LoadPassword(i).Name);
            }


        }

        private void tvPasswordList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RegularPassword selectedPassword = RegularPassword.LoadPassword(Convert.ToInt32(tvPasswordList.SelectedNode));
            //name = selectedPassword.Name;
            //login = selectedPassword.Login;
            //password = selectedPassword.Password;

            ReadUI();
        }
        // private bool encrypted; // ???

        void ReadUI()
        {
            //tbName.Text = name;
            //tbLogin.Text = login;
            //tbPassword.Text = password;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

        }
    }
}
