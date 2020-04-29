﻿namespace MusicMan
{
    partial class Login
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtPass = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(149, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Email:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(96, 131);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(147, 32);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password:";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(248, 57);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtEmail.MaxLength = 50;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(580, 38);
      this.txtEmail.TabIndex = 0;
      this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
      // 
      // txtPass
      // 
      this.txtPass.Location = new System.Drawing.Point(248, 129);
      this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPass.MaxLength = 50;
      this.txtPass.Name = "txtPass";
      this.txtPass.PasswordChar = '*';
      this.txtPass.Size = new System.Drawing.Size(580, 38);
      this.txtPass.TabIndex = 1;
      this.txtPass.UseSystemPasswordChar = true;
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(619, 203);
      this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(216, 52);
      this.btnLogin.TabIndex = 2;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.button1_Click);
      // 
      // Login
      // 
      this.AcceptButton = this.btnLogin;
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(963, 303);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPass);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Login";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MusicMan";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
    }
}

