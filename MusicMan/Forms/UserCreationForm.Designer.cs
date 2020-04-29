﻿namespace MusicMan.Forms
{
  partial class UserCreationForm
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
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtPassRepeat = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(76, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Email:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 117);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(147, 32);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password:";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(177, 56);
      this.txtEmail.MaxLength = 50;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(409, 38);
      this.txtEmail.TabIndex = 0;
      this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
      this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(177, 117);
      this.txtPassword.MaxLength = 50;
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(409, 38);
      this.txtPassword.TabIndex = 1;
      this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
      this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
      // 
      // btnSave
      // 
      this.btnSave.Enabled = false;
      this.btnSave.Location = new System.Drawing.Point(369, 232);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(217, 74);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtPassRepeat
      // 
      this.txtPassRepeat.Location = new System.Drawing.Point(177, 176);
      this.txtPassRepeat.MaxLength = 50;
      this.txtPassRepeat.Name = "txtPassRepeat";
      this.txtPassRepeat.PasswordChar = '*';
      this.txtPassRepeat.Size = new System.Drawing.Size(409, 38);
      this.txtPassRepeat.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(56, 176);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(115, 32);
      this.label3.TabIndex = 5;
      this.label3.Text = "Repeat:";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // UserCreationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(691, 332);
      this.Controls.Add(this.txtPassRepeat);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserCreationForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create User";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtPassRepeat;
    private System.Windows.Forms.Label label3;
  }
}