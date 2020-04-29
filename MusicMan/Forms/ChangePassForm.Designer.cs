namespace MusicMan.Forms
{
  partial class ChangePassForm
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
      this.txtPass = new System.Windows.Forms.TextBox();
      this.txtNewPass = new System.Windows.Forms.TextBox();
      this.txtNewPass2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtPass
      // 
      this.txtPass.Location = new System.Drawing.Point(207, 141);
      this.txtPass.Name = "txtPass";
      this.txtPass.PasswordChar = '*';
      this.txtPass.Size = new System.Drawing.Size(360, 38);
      this.txtPass.TabIndex = 0;
      this.txtPass.UseSystemPasswordChar = true;
      // 
      // txtNewPass
      // 
      this.txtNewPass.Location = new System.Drawing.Point(207, 212);
      this.txtNewPass.Name = "txtNewPass";
      this.txtNewPass.PasswordChar = '*';
      this.txtNewPass.Size = new System.Drawing.Size(360, 38);
      this.txtNewPass.TabIndex = 1;
      this.txtNewPass.UseSystemPasswordChar = true;
      this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
      // 
      // txtNewPass2
      // 
      this.txtNewPass2.Location = new System.Drawing.Point(207, 285);
      this.txtNewPass2.Name = "txtNewPass2";
      this.txtNewPass2.PasswordChar = '*';
      this.txtNewPass2.Size = new System.Drawing.Size(360, 38);
      this.txtNewPass2.TabIndex = 2;
      this.txtNewPass2.UseSystemPasswordChar = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 144);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(138, 32);
      this.label1.TabIndex = 3;
      this.label1.Text = "Old Pass:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(41, 212);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(149, 32);
      this.label2.TabIndex = 4;
      this.label2.Text = "New Pass:";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(75, 285);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(115, 32);
      this.label3.TabIndex = 5;
      this.label3.Text = "Repeat:";
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(336, 369);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(231, 49);
      this.btnOk.TabIndex = 6;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(81, 369);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(231, 49);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(207, 67);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(360, 38);
      this.txtEmail.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(95, 67);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(95, 32);
      this.label4.TabIndex = 9;
      this.label4.Text = "Email:";
      // 
      // ChangePassForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 485);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNewPass2);
      this.Controls.Add(this.txtNewPass);
      this.Controls.Add(this.txtPass);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChangePassForm";
      this.ShowIcon = false;
      this.Text = "Change Password";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPass;
    private System.Windows.Forms.TextBox txtNewPass;
    private System.Windows.Forms.TextBox txtNewPass2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label4;
  }
}