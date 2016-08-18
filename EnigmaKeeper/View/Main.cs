using System;
using System.Windows.Forms;
using EnigmaKeeper.DataAccess;

namespace EnigmaKeeper
{
    public partial class Main : Form
    {
        public delegate object LoadPassword(int index);
        public delegate object ReturnByPassword(string name);

        public Main()
        {
            InitializeComponent();
            new Presenter(this);            
        }

        Presenter presenter = new Presenter();

        public event EventHandler EncryptAllEvent = null;
        public event EventHandler DecryptAllEvent = null;
        public event LoadPassword LoadPasswordEvent = null;
        public event ReturnByPassword ReturnByPasswordEvent = null;

        #region *** Main Window Event Handler ***
        private void tsm_OpenNewPasswordWindow_Click(object sender, EventArgs e)
        {
            NewPasswordWindow newPasswordWindow = new NewPasswordWindow();
            newPasswordWindow.ShowDialog();
        }

        private void tsm_OpenGodPasswordWindow_Click(object sender, EventArgs e)
        {
            GodPasswordWindow godPasswordWindow = new GodPasswordWindow();
            godPasswordWindow.ShowDialog();
        }
        
        private void btnLoadPasswords_Click(object sender, EventArgs e) //TODO
        {
            dgvPasswordList.Rows.Clear();
            for (int i = 0; i < presenter.GetPasswordCount(); i++)
            {
                dgvPasswordList.Rows.Add();
                IPassword pswrd = LoadPasswordEvent.Invoke(i) as IPassword;
                dgvPasswordList.Rows[i].Cells[0].Value = pswrd.Name;
            }
        }
        
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

        #endregion
    }
}
