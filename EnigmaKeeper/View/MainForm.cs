using System;
using System.Windows.Forms;
using EnigmaKeeper.BL;

namespace EnigmaKeeper
{
    public delegate void LoadPasswordByIndex(int index);
    public delegate void LoadPasswordByName(string name);

    interface IMainForm
    {
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string GodPassword { get; set; }
        int PasswordCount { get; set; }

        event EventHandler AddPasswordEvent;
        event EventHandler SetGodPasswordEvent;
        event EventHandler GetPasswordCountEvent;
        event LoadPasswordByIndex LoadPasswordByIndexEvent;
        event LoadPasswordByName LoadPasswordByNameEvent;
        event EventHandler EncryptAllEvent;
        event EventHandler DecryptAllEvent;
    }

    public partial class MainForm : Form, IMainForm
    {

        public MainForm()
        {
            InitializeComponent();
            new Presenter(this, new Model());            
        }

        public new string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string GodPassword { get; set; }
        public int PasswordCount { get; set; }

        public event EventHandler EncryptAllEvent;
        public event EventHandler DecryptAllEvent;
        public event EventHandler AddPasswordEvent;
        public event EventHandler GetPasswordCountEvent;
        public event EventHandler SetGodPasswordEvent;
        public event LoadPasswordByIndex LoadPasswordByIndexEvent;
        public event LoadPasswordByName LoadPasswordByNameEvent;

        private void btnAddNewPassword_Click(object sender, EventArgs e)
        {
            Name = tbNewPasswordName.Text;
            Login = tbNewPasswordLogin.Text;
            Password = tbNewPasswordPassword.Text;

            AddPasswordEvent.Invoke(sender, e);

            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }

        private void btnSetGodPassword_Click(object sender, EventArgs e)
        {
            GodPassword = tbGodPassword.Text;

            SetGodPasswordEvent.Invoke(sender, e);
        }

        private void btnLoadPasswords_Click(object sender, EventArgs e)
        {
            LoadPasswords(sender, e);
        }

        private void dgvPasswordList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSelectedPassword(sender, e);
        }

        private void btnEncryptAll_Click(object sender, EventArgs e)
        {
            EncryptAllEvent.Invoke(sender, e);
            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }

        private void btnDecryptAll_Click(object sender, EventArgs e)
        {
            DecryptAllEvent.Invoke(sender, e);
            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }

        private void LoadPasswords(object sender, EventArgs e)
        {
            dgvPasswordList.Rows.Clear();

            GetPasswordCountEvent.Invoke(sender, e);

            for (int i = 0; i < PasswordCount; i++)
            {
                dgvPasswordList.Rows.Add();
                LoadPasswordByIndexEvent.Invoke(i);
                dgvPasswordList.Rows[i].Cells[0].Value = Name;
            }
        }

        private void LoadSelectedPassword(object sender, EventArgs e)
        {
            try
            {
                LoadPasswordByNameEvent.Invoke((string)dgvPasswordList.CurrentRow.Cells[0].Value);

                tbName.Text = Name;
                tbLogin.Text = Login;
                tbPassword.Text = Password;
            }
            catch (Exception)
            {

            }

        }
    }
}
