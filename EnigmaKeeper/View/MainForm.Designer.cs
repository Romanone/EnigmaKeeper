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
            this.btnAddNewPassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewPasswordName = new System.Windows.Forms.TextBox();
            this.tbNewPasswordPassword = new System.Windows.Forms.TextBox();
            this.tbNewPasswordLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbGodPassword = new System.Windows.Forms.GroupBox();
            this.btnSetGodPassword = new System.Windows.Forms.Button();
            this.tbGodPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEnableSettings = new System.Windows.Forms.CheckBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadPasswords = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.gbAddNewPassword.SuspendLayout();
            this.gbGodPassword.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(100, 24);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 23);
            this.tbName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(100, 86);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(189, 23);
            this.tbPassword.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Location = new System.Drawing.Point(100, 55);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(189, 23);
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
            this.dgvPasswordList.Location = new System.Drawing.Point(12, 28);
            this.dgvPasswordList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPasswordList.Name = "dgvPasswordList";
            this.dgvPasswordList.ReadOnly = true;
            this.dgvPasswordList.RowHeadersVisible = false;
            this.dgvPasswordList.Size = new System.Drawing.Size(259, 526);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
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
            this.gbDetails.Location = new System.Drawing.Point(277, 28);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetails.Size = new System.Drawing.Size(295, 117);
            this.gbDetails.TabIndex = 11;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // btnEncryptAll
            // 
            this.btnEncryptAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptAll.Location = new System.Drawing.Point(3, 80);
            this.btnEncryptAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncryptAll.Name = "btnEncryptAll";
            this.btnEncryptAll.Size = new System.Drawing.Size(135, 28);
            this.btnEncryptAll.TabIndex = 12;
            this.btnEncryptAll.Text = "Encrypt All";
            this.btnEncryptAll.UseVisualStyleBackColor = true;
            this.btnEncryptAll.Click += new System.EventHandler(this.btnEncryptAll_Click);
            // 
            // btnDecryptAll
            // 
            this.btnDecryptAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecryptAll.Location = new System.Drawing.Point(144, 80);
            this.btnDecryptAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecryptAll.Name = "btnDecryptAll";
            this.btnDecryptAll.Size = new System.Drawing.Size(136, 28);
            this.btnDecryptAll.TabIndex = 13;
            this.btnDecryptAll.Text = "Decrypt All";
            this.btnDecryptAll.UseVisualStyleBackColor = true;
            this.btnDecryptAll.Click += new System.EventHandler(this.btnDecryptAll_Click);
            // 
            // btnCopyLogin
            // 
            this.btnCopyLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyLogin.Location = new System.Drawing.Point(3, 4);
            this.btnCopyLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopyLogin.Name = "btnCopyLogin";
            this.btnCopyLogin.Size = new System.Drawing.Size(135, 30);
            this.btnCopyLogin.TabIndex = 14;
            this.btnCopyLogin.Text = "Copy Login";
            this.btnCopyLogin.UseVisualStyleBackColor = true;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPassword.Location = new System.Drawing.Point(144, 4);
            this.btnCopyPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(136, 30);
            this.btnCopyPassword.TabIndex = 15;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(3, 42);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(135, 26);
            this.btnUpdatePassword.TabIndex = 16;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePassword.Location = new System.Drawing.Point(144, 42);
            this.btnDeletePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(136, 26);
            this.btnDeletePassword.TabIndex = 17;
            this.btnDeletePassword.Text = "Delete Password";
            this.btnDeletePassword.UseVisualStyleBackColor = true;
            // 
            // gbAddNewPassword
            // 
            this.gbAddNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddNewPassword.Controls.Add(this.btnAddNewPassword);
            this.gbAddNewPassword.Controls.Add(this.cbEnableSettings);
            this.gbAddNewPassword.Controls.Add(this.label4);
            this.gbAddNewPassword.Controls.Add(this.tbNewPasswordName);
            this.gbAddNewPassword.Controls.Add(this.tbNewPasswordPassword);
            this.gbAddNewPassword.Controls.Add(this.tbNewPasswordLogin);
            this.gbAddNewPassword.Controls.Add(this.label5);
            this.gbAddNewPassword.Controls.Add(this.label6);
            this.gbAddNewPassword.Location = new System.Drawing.Point(277, 299);
            this.gbAddNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAddNewPassword.Name = "gbAddNewPassword";
            this.gbAddNewPassword.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAddNewPassword.Size = new System.Drawing.Size(295, 156);
            this.gbAddNewPassword.TabIndex = 18;
            this.gbAddNewPassword.TabStop = false;
            this.gbAddNewPassword.Text = "Add New Password";
            // 
            // btnAddNewPassword
            // 
            this.btnAddNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPassword.Location = new System.Drawing.Point(6, 119);
            this.btnAddNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewPassword.Name = "btnAddNewPassword";
            this.btnAddNewPassword.Size = new System.Drawing.Size(283, 28);
            this.btnAddNewPassword.TabIndex = 7;
            this.btnAddNewPassword.Text = "Add Password";
            this.btnAddNewPassword.UseVisualStyleBackColor = true;
            this.btnAddNewPassword.Click += new System.EventHandler(this.btnAddNewPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // tbNewPasswordName
            // 
            this.tbNewPasswordName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordName.Location = new System.Drawing.Point(100, 23);
            this.tbNewPasswordName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPasswordName.Name = "tbNewPasswordName";
            this.tbNewPasswordName.Size = new System.Drawing.Size(189, 23);
            this.tbNewPasswordName.TabIndex = 0;
            // 
            // tbNewPasswordPassword
            // 
            this.tbNewPasswordPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordPassword.Location = new System.Drawing.Point(100, 87);
            this.tbNewPasswordPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPasswordPassword.Name = "tbNewPasswordPassword";
            this.tbNewPasswordPassword.Size = new System.Drawing.Size(189, 23);
            this.tbNewPasswordPassword.TabIndex = 2;
            // 
            // tbNewPasswordLogin
            // 
            this.tbNewPasswordLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordLogin.Location = new System.Drawing.Point(100, 55);
            this.tbNewPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPasswordLogin.Name = "tbNewPasswordLogin";
            this.tbNewPasswordLogin.Size = new System.Drawing.Size(189, 23);
            this.tbNewPasswordLogin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // gbGodPassword
            // 
            this.gbGodPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGodPassword.Controls.Add(this.btnSetGodPassword);
            this.gbGodPassword.Controls.Add(this.tbGodPassword);
            this.gbGodPassword.Controls.Add(this.label9);
            this.gbGodPassword.Location = new System.Drawing.Point(277, 463);
            this.gbGodPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGodPassword.Name = "gbGodPassword";
            this.gbGodPassword.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGodPassword.Size = new System.Drawing.Size(295, 91);
            this.gbGodPassword.TabIndex = 19;
            this.gbGodPassword.TabStop = false;
            this.gbGodPassword.Text = "Set God Password";
            // 
            // btnSetGodPassword
            // 
            this.btnSetGodPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetGodPassword.Location = new System.Drawing.Point(6, 53);
            this.btnSetGodPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetGodPassword.Name = "btnSetGodPassword";
            this.btnSetGodPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetGodPassword.Size = new System.Drawing.Size(283, 30);
            this.btnSetGodPassword.TabIndex = 7;
            this.btnSetGodPassword.Text = "Set God Password";
            this.btnSetGodPassword.UseVisualStyleBackColor = true;
            this.btnSetGodPassword.Click += new System.EventHandler(this.btnSetGodPassword_Click);
            // 
            // tbGodPassword
            // 
            this.tbGodPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGodPassword.Location = new System.Drawing.Point(96, 23);
            this.tbGodPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGodPassword.Name = "tbGodPassword";
            this.tbGodPassword.Size = new System.Drawing.Size(193, 23);
            this.tbGodPassword.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password";
            // 
            // cbEnableSettings
            // 
            this.cbEnableSettings.AutoSize = true;
            this.cbEnableSettings.Location = new System.Drawing.Point(140, 0);
            this.cbEnableSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEnableSettings.Name = "cbEnableSettings";
            this.cbEnableSettings.Size = new System.Drawing.Size(128, 20);
            this.cbEnableSettings.TabIndex = 20;
            this.cbEnableSettings.Text = "Enable settings";
            this.cbEnableSettings.UseVisualStyleBackColor = true;
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.tableLayoutPanel1);
            this.gbControls.Location = new System.Drawing.Point(277, 152);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(295, 140);
            this.gbControls.TabIndex = 21;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpdatePassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDeletePassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyLogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyPassword, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDecryptAll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEncryptAll, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 112);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadPasswords});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnLoadPasswords
            // 
            this.btnLoadPasswords.Name = "btnLoadPasswords";
            this.btnLoadPasswords.Size = new System.Drawing.Size(158, 22);
            this.btnLoadPasswords.Text = "Load passwords";
            this.btnLoadPasswords.Click += new System.EventHandler(this.btnLoadPasswords_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 580);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbGodPassword);
            this.Controls.Add(this.gbAddNewPassword);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvPasswordList);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 619);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma Keeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbAddNewPassword.ResumeLayout(false);
            this.gbAddNewPassword.PerformLayout();
            this.gbGodPassword.ResumeLayout(false);
            this.gbGodPassword.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.CheckBox cbEnableSettings;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLoadPasswords;
    }
}

