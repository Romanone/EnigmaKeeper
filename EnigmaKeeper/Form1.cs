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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                Encryptor test = new Encryptor();

                test.StringToLong(tbTest.Text);
                for (int i = 0; i < test.Keys.Count; i++)
                {
                    richTextBox1.AppendText(test.Keys[i].ToString() + "\n");
                }

                richTextBox3.Text = test.Encrypt(richTextBox2.Text, tbTest.Text);
            }
            catch (Exception)
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RegularPassword.CreatePassword(tbNameIn.Text, tbLoginIn.Text, tbPasswordIn.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RegularPassword mypass = RegularPassword.LoadPassword(0);
            tbNameOut.Text = mypass.Name;
            tbPasswordOut.Text = mypass.Password;
            tbLoginOut.Text = mypass.Login;
        }
    }
}
