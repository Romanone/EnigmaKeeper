namespace EnigmaKeeper
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_OpenNewPasswordWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_OpenGodPasswordWindow = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_OpenNewPasswordWindow,
            this.tsm_OpenGodPasswordWindow});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsm_OpenNewPasswordWindow
            // 
            this.tsm_OpenNewPasswordWindow.Name = "tsm_OpenNewPasswordWindow";
            this.tsm_OpenNewPasswordWindow.Size = new System.Drawing.Size(186, 22);
            this.tsm_OpenNewPasswordWindow.Text = "Add new password";
            this.tsm_OpenNewPasswordWindow.Click += new System.EventHandler(this.tsm_OpenNewPasswordWindow_Click);
            // 
            // tsm_OpenGodPasswordWindow
            // 
            this.tsm_OpenGodPasswordWindow.Name = "tsm_OpenGodPasswordWindow";
            this.tsm_OpenGodPasswordWindow.Size = new System.Drawing.Size(186, 22);
            this.tsm_OpenGodPasswordWindow.Text = "Create God password";
            this.tsm_OpenGodPasswordWindow.Click += new System.EventHandler(this.tsm_OpenGodPasswordWindow_Click);
            // 
            // btnLoadPasswords
            // 
            this.btnLoadPasswords.Location = new System.Drawing.Point(222, 158);
            this.btnLoadPasswords.Name = "btnLoadPasswords";
            this.btnLoadPasswords.Size = new System.Drawing.Size(195, 23);
            this.btnLoadPasswords.TabIndex = 6;
            this.btnLoadPasswords.Text = "Load passwords";
            this.btnLoadPasswords.UseVisualStyleBackColor = true;
            this.btnLoadPasswords.Click += new System.EventHandler(this.btnLoadPasswords_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 20);
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
            this.tbPassword.Location = new System.Drawing.Point(72, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(256, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(72, 45);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(256, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // dgvPasswordList
            // 
            this.dgvPasswordList.AllowUserToAddRows = false;
            this.dgvPasswordList.AllowUserToDeleteRows = false;
            this.dgvPasswordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName});
            this.dgvPasswordList.Location = new System.Drawing.Point(12, 27);
            this.dgvPasswordList.Name = "dgvPasswordList";
            this.dgvPasswordList.ReadOnly = true;
            this.dgvPasswordList.RowHeadersVisible = false;
            this.dgvPasswordList.Size = new System.Drawing.Size(195, 360);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Controls.Add(this.tbPassword);
            this.gbDetails.Controls.Add(this.tbLogin);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Location = new System.Drawing.Point(213, 27);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(341, 101);
            this.gbDetails.TabIndex = 11;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // btnEncryptAll
            // 
            this.btnEncryptAll.Location = new System.Drawing.Point(222, 187);
            this.btnEncryptAll.Name = "btnEncryptAll";
            this.btnEncryptAll.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptAll.TabIndex = 12;
            this.btnEncryptAll.Text = "Encrypt All";
            this.btnEncryptAll.UseVisualStyleBackColor = true;
            this.btnEncryptAll.Click += new System.EventHandler(this.btnEncryptAll_Click);
            // 
            // btnDecryptAll
            // 
            this.btnDecryptAll.Location = new System.Drawing.Point(342, 187);
            this.btnDecryptAll.Name = "btnDecryptAll";
            this.btnDecryptAll.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptAll.TabIndex = 13;
            this.btnDecryptAll.Text = "Decrypt All";
            this.btnDecryptAll.UseVisualStyleBackColor = true;
            this.btnDecryptAll.Click += new System.EventHandler(this.btnDecryptAll_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 418);
            this.Controls.Add(this.btnDecryptAll);
            this.Controls.Add(this.btnEncryptAll);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvPasswordList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLoadPasswords);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma Keeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_OpenNewPasswordWindow;
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
        private System.Windows.Forms.ToolStripMenuItem tsm_OpenGodPasswordWindow;
        private System.Windows.Forms.Button btnEncryptAll;
        private System.Windows.Forms.Button btnDecryptAll;
    }
}

