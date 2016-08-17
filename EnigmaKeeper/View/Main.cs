using System;
using System.Windows.Forms;
using EnigmaKeeper.DataAccess;

namespace EnigmaKeeper
{
    public partial class Main : Form
    {
        public delegate object LoadPassword(int index);

        public Main()
        {
            InitializeComponent();
            new Presenter(this);            
        }

        Presenter Presenter = new Presenter();
        //IPassword Password = new ConcretePassword();

        
        public string Key { get; set; }
        public event EventHandler Encrypt = null;
        public event EventHandler Search = null;
        public event LoadPassword LoadPasswordEvent = null;


        public string Name { get; set; }
        public string Login { get; set; }
        //public string Password { get; set; }
        public string PasswordName { get; set; }
        public int Index { get; set; }

        // Event methods
        private void EncryptProcess(object sender, EventArgs e)
        {
            Encrypt.Invoke(sender, e);
        }
        private void SearchPassword(object sender, EventArgs e)
        {
             Search.Invoke(sender, e);
        }
        //

        private void tsm_OpenNewPasswordWindow_Click(object sender, EventArgs e)
        {
            NewPasswordWindow newPasswordWindow = new NewPasswordWindow();
            newPasswordWindow.ShowDialog();
        }

        private void btnLoadPasswords_Click(object sender, EventArgs e)
        {
            dgvPasswordList.Rows.Clear();
            for (Index = 0; Index < ConcretePassword.GetPasswordCount(); Index++)
            {
                dgvPasswordList.Rows.Add();
                IPassword pswrd = LoadPasswordEvent.Invoke(Index) as IPassword;
                dgvPasswordList.Rows[Index].Cells[0].Value = pswrd.Name;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < presenter.PasswordCounter(); i++)
            //{
            //    EncryptProcess(sender, e);
            //    presenter.LoadPasswordPresenter(i);
            //}
            
        }

        private void tsm_OpenGodPasswordWindow_Click(object sender, EventArgs e)
        {
            GodPasswordWindow godPasswordWindow = new GodPasswordWindow();
            godPasswordWindow.ShowDialog();
        }

        private void dgvPasswordList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //PasswordName = (string)dgvPasswordList.CurrentRow.Cells[0].Value;
            //var Password = RegularPassword.SearchPassword(PasswordName);
            //tbName.Text = Password.Name;
            //tbLogin.Text = Password.Login;
            //tbPassword.Text = Password.Password;
        }


    }
}
