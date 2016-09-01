namespace EnigmaKeeper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadPasswords = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.dgvPasswordList = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnEncryptAll = new System.Windows.Forms.Button();
            this.btnDecryptAll = new System.Windows.Forms.Button();
            this.btnCopyLogin = new System.Windows.Forms.Button();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.gbAddNewPassword = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewPasswordName = new System.Windows.Forms.TextBox();
            this.tbNewPasswordPassword = new System.Windows.Forms.TextBox();
            this.tbNewPasswordLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNewPassword = new System.Windows.Forms.Button();
            this.gbGodPassword = new System.Windows.Forms.GroupBox();
            this.btnSetGodPassword = new System.Windows.Forms.Button();
            this.tbGodPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.gbAddNewPassword.SuspendLayout();
            this.gbGodPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPasswords
            // 
            this.btnLoadPasswords.Location = new System.Drawing.Point(213, 192);
            this.btnLoadPasswords.Name = "btnLoadPasswords";
            this.btnLoadPasswords.Size = new System.Drawing.Size(195, 23);
            this.btnLoadPasswords.TabIndex = 6;
            this.btnLoadPasswords.Text = "Load passwords";
            this.btnLoadPasswords.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(72, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(277, 20);
            this.tbName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(72, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(277, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Location = new System.Drawing.Point(72, 45);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(277, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // dgvPasswordList
            // 
            this.dgvPasswordList.AllowUserToAddRows = false;
            this.dgvPasswordList.AllowUserToDeleteRows = false;
            this.dgvPasswordList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPasswordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName});
            this.dgvPasswordList.Location = new System.Drawing.Point(12, 12);
            this.dgvPasswordList.Name = "dgvPasswordList";
            this.dgvPasswordList.ReadOnly = true;
            this.dgvPasswordList.RowHeadersVisible = false;
            this.dgvPasswordList.Size = new System.Drawing.Size(195, 466);
            this.dgvPasswordList.TabIndex = 9;
            this.dgvPasswordList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswordList_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Accounts";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Controls.Add(this.tbPassword);
            this.gbDetails.Controls.Add(this.tbLogin);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Location = new System.Drawing.Point(213, 12);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(355, 101);
            this.gbDetails.TabIndex = 11;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // btnEncryptAll
            // 
            this.btnEncryptAll.Location = new System.Drawing.Point(213, 221);
            this.btnEncryptAll.Name = "btnEncryptAll";
            this.btnEncryptAll.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptAll.TabIndex = 12;
            this.btnEncryptAll.Text = "Encrypt All";
            this.btnEncryptAll.UseVisualStyleBackColor = true;
            this.btnEncryptAll.Click += new System.EventHandler(this.btnEncryptAll_Click);
            // 
            // btnDecryptAll
            // 
            this.btnDecryptAll.Location = new System.Drawing.Point(427, 192);
            this.btnDecryptAll.Name = "btnDecryptAll";
            this.btnDecryptAll.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptAll.TabIndex = 13;
            this.btnDecryptAll.Text = "Decrypt All";
            this.btnDecryptAll.UseVisualStyleBackColor = true;
            this.btnDecryptAll.Click += new System.EventHandler(this.btnDecryptAll_Click);
            // 
            // btnCopyLogin
            // 
            this.btnCopyLogin.Location = new System.Drawing.Point(213, 134);
            this.btnCopyLogin.Name = "btnCopyLogin";
            this.btnCopyLogin.Size = new System.Drawing.Size(175, 23);
            this.btnCopyLogin.TabIndex = 14;
            this.btnCopyLogin.Text = "Copy Login";
            this.btnCopyLogin.UseVisualStyleBackColor = true;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Location = new System.Drawing.Point(394, 134);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(174, 23);
            this.btnCopyPassword.TabIndex = 15;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(213, 163);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(175, 23);
            this.btnUpdatePassword.TabIndex = 16;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.Location = new System.Drawing.Point(394, 163);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(174, 23);
            this.btnDeletePassword.TabIndex = 17;
            this.btnDeletePassword.Text = "Delete Password";
            this.btnDeletePassword.UseVisualStyleBackColor = true;
            // 
            // gbAddNewPassword
            // 
            this.gbAddNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddNewPassword.Controls.Add(this.btnAddNewPassword);
            this.gbAddNewPassword.Controls.Add(this.label4);
            this.gbAddNewPassword.Controls.Add(this.tbNewPasswordName);
            this.gbAddNewPassword.Controls.Add(this.tbNewPasswordPassword);
            this.gbAddNewPassword.Controls.Add(this.tbNewPasswordLogin);
            this.gbAddNewPassword.Controls.Add(this.label5);
            this.gbAddNewPassword.Controls.Add(this.label6);
            this.gbAddNewPassword.Location = new System.Drawing.Point(213, 271);
            this.gbAddNewPassword.Name = "gbAddNewPassword";
            this.gbAddNewPassword.Size = new System.Drawing.Size(355, 127);
            this.gbAddNewPassword.TabIndex = 18;
            this.gbAddNewPassword.TabStop = false;
            this.gbAddNewPassword.Text = "Add New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // tbNewPasswordName
            // 
            this.tbNewPasswordName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordName.Location = new System.Drawing.Point(72, 19);
            this.tbNewPasswordName.Name = "tbNewPasswordName";
            this.tbNewPasswordName.Size = new System.Drawing.Size(277, 20);
            this.tbNewPasswordName.TabIndex = 0;
            // 
            // tbNewPasswordPassword
            // 
            this.tbNewPasswordPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordPassword.Location = new System.Drawing.Point(72, 71);
            this.tbNewPasswordPassword.Name = "tbNewPasswordPassword";
            this.tbNewPasswordPassword.Size = new System.Drawing.Size(277, 20);
            this.tbNewPasswordPassword.TabIndex = 2;
            // 
            // tbNewPasswordLogin
            // 
            this.tbNewPasswordLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordLogin.Location = new System.Drawing.Point(72, 45);
            this.tbNewPasswordLogin.Name = "tbNewPasswordLogin";
            this.tbNewPasswordLogin.Size = new System.Drawing.Size(277, 20);
            this.tbNewPasswordLogin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // btnAddNewPassword
            // 
            this.btnAddNewPassword.Location = new System.Drawing.Point(6, 97);
            this.btnAddNewPassword.Name = "btnAddNewPassword";
            this.btnAddNewPassword.Size = new System.Drawing.Size(343, 23);
            this.btnAddNewPassword.TabIndex = 7;
            this.btnAddNewPassword.Text = "Add Password";
            this.btnAddNewPassword.UseVisualStyleBackColor = true;
            this.btnAddNewPassword.Click += new System.EventHandler(this.btnAddNewPassword_Click);
            // 
            // gbGodPassword
            // 
            this.gbGodPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGodPassword.Controls.Add(this.btnSetGodPassword);
            this.gbGodPassword.Controls.Add(this.tbGodPassword);
            this.gbGodPassword.Controls.Add(this.label9);
            this.gbGodPassword.Location = new System.Drawing.Point(213, 404);
            this.gbGodPassword.Name = "gbGodPassword";
            this.gbGodPassword.Size = new System.Drawing.Size(355, 74);
            this.gbGodPassword.TabIndex = 19;
            this.gbGodPassword.TabStop = false;
            this.gbGodPassword.Text = "Set God Password";
            // 
            // btnSetGodPassword
            // 
            this.btnSetGodPassword.Location = new System.Drawing.Point(6, 45);
            this.btnSetGodPassword.Name = "btnSetGodPassword";
            this.btnSetGodPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetGodPassword.Size = new System.Drawing.Size(343, 23);
            this.btnSetGodPassword.TabIndex = 7;
            this.btnSetGodPassword.Text = "Set God Password";
            this.btnSetGodPassword.UseVisualStyleBackColor = true;
            this.btnSetGodPassword.Click += new System.EventHandler(this.btnSetGodPassword_Click);
            // 
            // tbGodPassword
            // 
            this.tbGodPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGodPassword.Location = new System.Drawing.Point(72, 19);
            this.tbGodPassword.Name = "tbGodPassword";
            this.tbGodPassword.Size = new System.Drawing.Size(277, 20);
            this.tbGodPassword.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(294, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 503);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gbGodPassword);
            this.Controls.Add(this.gbAddNewPassword);
            this.Controls.Add(this.btnDeletePassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.btnCopyLogin);
            this.Controls.Add(this.btnDecryptAll);
            this.Controls.Add(this.btnEncryptAll);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvPasswordList);
            this.Controls.Add(this.btnLoadPasswords);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma Keeper";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbAddNewPassword.ResumeLayout(false);
            this.gbAddNewPassword.PerformLayout();
            this.gbGodPassword.ResumeLayout(false);
            this.gbGodPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadPasswords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dgvPasswordList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnEncryptAll;
        private System.Windows.Forms.Button btnDecryptAll;
        private System.Windows.Forms.Button btnCopyLogin;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnDeletePassword;
        private System.Windows.Forms.GroupBox gbAddNewPassword;
        private System.Windows.Forms.Button btnAddNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewPasswordName;
        private System.Windows.Forms.TextBox tbNewPasswordPassword;
        private System.Windows.Forms.TextBox tbNewPasswordLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbGodPassword;
        private System.Windows.Forms.Button btnSetGodPassword;
        private System.Windows.Forms.TextBox tbGodPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

