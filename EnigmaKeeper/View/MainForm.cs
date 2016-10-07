using System;
using System.Windows.Forms;
using EnigmaKeeper.BL;

namespace EnigmaKeeper
{
    public delegate void LoadPasswordByIndex(int index);
    public delegate void LoadPasswordByName(string name);
    public delegate bool CheckControlWord(string controlWord);
  
    interface IMainForm
    {
        string Path { get; set; }
        string Name { get; set; }
        string Login { get; set; }
        string OldName { get; set; }
        string Password { get; set; }
        int PasswordCount { get; set; }
        string GodPassword { get; set; }

        event EventHandler EncryptAllEvent;
        event EventHandler DecryptAllEvent;
        event EventHandler AddPasswordEvent;
        event EventHandler UpdatePasswordEvent;
        event EventHandler SetGodPasswordEvent;
        event EventHandler RemovePasswordEvent;
        event EventHandler GetPasswordCountEvent;
        event EventHandler RemoveAllPasswordsEvent;
        event EventHandler WritePasswordsToFileEvent;
        event CheckControlWord CheckControlWordEvent;
        event EventHandler ReadPasswordsFromFileEvent;
        event LoadPasswordByName LoadPasswordByNameEvent;
        event LoadPasswordByIndex LoadPasswordByIndexEvent;
    }

    public partial class MainForm : Form, IMainForm
    {
        #region *** Constructors ***

        public MainForm()
        {
            InitializeComponent();
            new Presenter(this, new Model());
        }

        #endregion *** End of Constructors ***

        #region *** Properties & Events ***

        public string Path { get; set; }
        public string Login { get; set; }
        public string OldName { get; set; }
        public new string Name { get; set; }
        public string Password { get; set; }
        public int PasswordCount { get; set; }
        public string GodPassword { get; set; }

        public event EventHandler EncryptAllEvent;
        public event EventHandler DecryptAllEvent;
        public event EventHandler AddPasswordEvent;
        public event EventHandler UpdatePasswordEvent;
        public event EventHandler SetGodPasswordEvent;
        public event EventHandler RemovePasswordEvent;
        public event EventHandler GetPasswordCountEvent;
        public event EventHandler RemoveAllPasswordsEvent;
        public event EventHandler WritePasswordsToFileEvent;
        public event CheckControlWord CheckControlWordEvent;
        public event EventHandler ReadPasswordsFromFileEvent;
        public event LoadPasswordByName LoadPasswordByNameEvent;
        public event LoadPasswordByIndex LoadPasswordByIndexEvent;

        #endregion *** End of Properties & Events ***

        #region *** Event Handlers ***

        private void btnAddNewPassword_Click(object sender, EventArgs e)
        {
            Name = tbNewPasswordName.Text;
            Login = tbNewPasswordLogin.Text;
            Password = tbNewPasswordPassword.Text;

            AddPasswordEvent.Invoke(sender, e);

            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);

            tbNewPasswordName.Text = "";
            tbNewPasswordLogin.Text = "";
            tbNewPasswordPassword.Text = "";
        }

        private void btnSetGodPassword_Click(object sender, EventArgs e)
        {
            GodPassword = tbGodPassword.Text;

            SetGodPasswordEvent.Invoke(sender, e);

            FormUpdate();
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

            if (!CheckControlWord("control word"))
            {
                MessageBox.Show("Wrong Pass");
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormUpdate();

            LoadPasswordFromFile(sender, e);
            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }

        private void btnSavePasswordsToFile_Click(object sender, EventArgs e)
        {
            SavePasswordsToFile(sender, e);
        }

        private void btnLoadPasswordsFromFile_Click(object sender, EventArgs e)
        {
            LoadPasswordFromFile(sender, e);
            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }


        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            OldName = Name;
            Name = tbName.Text;
            Login = tbLogin.Text;
            Password = tbPassword.Text;

            UpdatePasswordEvent(sender, e);
            LoadPasswords(sender, e);
            LoadSelectedPassword(sender, e);
        }

        private void btnRemovePassword_Click(object sender, EventArgs e)
        {
            RemovePasswordEvent.Invoke(sender, e);
            LoadPasswords(sender, e);
        }

        private void btnCopyLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLogin.Text);
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPassword.Text);
        }

        #endregion *** End of Event Handlers ***

        #region *** Methods ***

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

        private void LoadPasswordFromFile(object sender, EventArgs e)
        {
            Path = @"PasswordBox.txt";
            RemoveAllPasswordsEvent.Invoke(sender, e);
            ReadPasswordsFromFileEvent.Invoke(sender, e);
            LoadPasswords(sender, e);
        }

        private void SavePasswordsToFile(object sender, EventArgs e)
        {
            Path = @"PasswordBox.txt"; //TODO here logic
            WritePasswordsToFileEvent.Invoke(sender, e);
        }
        

        public void FormUpdate()
        {
            if (String.IsNullOrWhiteSpace(GodPassword))
            {
                btnEncryptAll.Enabled = false;
                btnDecryptAll.Enabled = false;
            }

            else
            {
                btnEncryptAll.Enabled = true;
                btnDecryptAll.Enabled = true;
            }
        }

        public bool CheckControlWord(string controlWord)
        {
            return CheckControlWordEvent.Invoke(controlWord);
        }

        #endregion *** End of Methods ***
    }
}
