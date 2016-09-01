using System;
using System.Windows.Forms;
using EnigmaKeeper.DataAccess;

namespace EnigmaKeeper
{
    //public delegate void ReturnByPassword(string name);

    public delegate object LoadPasswordByIndex(int index);
    public delegate object LoadPasswordByName(string name);

    interface IMainForm
    {
        void LoadPasswords();
        void EncryptAllPasswords();
        void DecryptAllPasswords();
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string GodPassword { get; set; }

        event EventHandler AddPasswordEvent;
        event EventHandler SetGodPasswordEvent;

        event EventHandler EncryptAllEvent;
        event EventHandler DecryptAllEvent;
        //event ReturnByPassword LoadPasswordEvent;
    }

    public partial class MainForm : Form, IMainForm
    {

        public MainForm()
        {
            InitializeComponent();
            //new Presenter(this);            
        }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string GodPassword { get; set; }

        public event EventHandler EncryptAllEvent;
        public event EventHandler DecryptAllEvent;
        public event EventHandler AddPasswordEvent;
        public event EventHandler SetGodPasswordEvent;


        public event LoadPasswordByIndex LoadPasswordByIndexEvent = null;
        public event LoadPasswordByName LoadPasswordByNameEvent = null;
        //public event ReturnByPassword ReturnByPasswordEvent = null;


        private void btnAddNewPassword_Click(object sender, EventArgs e)
        {
            Name = tbNewPasswordName.Text;
            Login = tbNewPasswordLogin.Text;
            Password = tbNewPasswordPassword.Text;

            AddPasswordEvent.Invoke(sender, e);
        }

        private void btnSetGodPassword_Click(object sender, EventArgs e)
        {
            GodPassword = tbGodPassword.Text;

            SetGodPasswordEvent.Invoke(sender, e);
        }














        //private void btnLoadPasswords_Click(object sender, EventArgs e) //TODO
        //{
        //    dgvPasswordList.Rows.Clear();
        //    for (int i = 0; i < presenter.GetPasswordCount(); i++)
        //    {
        //        dgvPasswordList.Rows.Add();
        //        IPassword pswrd = LoadPasswordEvent.Invoke(i) as IPassword;
        //        dgvPasswordList.Rows[i].Cells[0].Value = pswrd.Name;
        //    }
        //}

        private void dgvPasswordList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPassword = (IPassword)ReturnByPasswordEvent.Invoke((string)dgvPasswordList.CurrentRow.Cells[0].Value);
            tbName.Text = selectedPassword.Name;
            tbLogin.Text = selectedPassword.Login;
            tbPassword.Text = selectedPassword.Password;
        }



        private void btnEncryptAll_Click(object sender, EventArgs e)
        {
            EncryptAllEvent.Invoke(sender, e);
        }

        private void btnDecryptAll_Click(object sender, EventArgs e)
        {
            DecryptAllEvent.Invoke(sender, e);
        }

    }
}
