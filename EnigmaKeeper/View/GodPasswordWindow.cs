using System;
using System.Windows.Forms;

namespace EnigmaKeeper
{
    public partial class GodPasswordWindow : Form
    {
        public GodPasswordWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public static string GodPassword { get; set; }

        public event EventHandler NewGodPassword = null;

        private void SaveGodPassword(object sender, EventArgs e)
        {
            GodPassword = tbGodPassword.Text;
            NewGodPassword.Invoke(sender, e);
        }

        private void btnSaveGodPassword_Click(object sender, EventArgs e)
        {
            SaveGodPassword(sender, e);
            this.Close();
        }
    }
}
