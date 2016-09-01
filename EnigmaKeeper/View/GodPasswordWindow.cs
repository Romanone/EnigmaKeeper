using System;
using System.Windows.Forms;

namespace EnigmaKeeper
{
    public delegate void AddGodPassword(string godPassword);
    public partial class GodPasswordWindow : Form
    {
        public GodPasswordWindow()
        {
            InitializeComponent();
            //new Presenter(this);
        }

        public event AddGodPassword AddGodPasswordEvent = null;

        private void SaveGodPassword(object sender, EventArgs e)
        {
            AddGodPasswordEvent.Invoke(tbGodPassword.Text);
        }

        private void btnSaveGodPassword_Click(object sender, EventArgs e)
        {
            SaveGodPassword(sender, e);
            this.Close();
        }
    }
}
