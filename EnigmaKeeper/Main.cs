﻿using System;
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
            dgvPasswordList.Rows.Clear();
            for (int i = 0; i < RegularPassword.GetPasswordCount(); i++)
            {
                RegularPassword.LoadPassword(i);
                this.dgvPasswordList.Rows.Add();
                dgvPasswordList.Rows[0].Cells[i].Value = (RegularPassword.LoadPassword(i).Name);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

        }
    }
}