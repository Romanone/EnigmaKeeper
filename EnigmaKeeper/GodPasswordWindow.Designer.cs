﻿namespace EnigmaKeeper
{
    partial class GodPasswordWindow
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
            this.btnSaveGodPassword = new System.Windows.Forms.Button();
            this.tbGodPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveGodPassword
            // 
            this.btnSaveGodPassword.Location = new System.Drawing.Point(186, 38);
            this.btnSaveGodPassword.Name = "btnSaveGodPassword";
            this.btnSaveGodPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGodPassword.TabIndex = 0;
            this.btnSaveGodPassword.Text = "Save";
            this.btnSaveGodPassword.UseVisualStyleBackColor = true;
            this.btnSaveGodPassword.Click += new System.EventHandler(this.btnSaveGodPassword_Click);
            // 
            // tbGodPassword
            // 
            this.tbGodPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGodPassword.Location = new System.Drawing.Point(72, 12);
            this.tbGodPassword.Name = "tbGodPassword";
            this.tbGodPassword.Size = new System.Drawing.Size(301, 20);
            this.tbGodPassword.TabIndex = 1;
            // 
            // GodPasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 66);
            this.Controls.Add(this.tbGodPassword);
            this.Controls.Add(this.btnSaveGodPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GodPasswordWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GodPasswordWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveGodPassword;
        private System.Windows.Forms.TextBox tbGodPassword;
    }
}