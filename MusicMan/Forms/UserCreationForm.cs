using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicMan.Forms
{
  public partial class UserCreationForm : Form
  {
    public UserCreationForm()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (txtPassword.Text != txtPassRepeat.Text)
      {
        MessageBox.Show(@"Passwords do not match.");
        return;
      }

      User.CreateUser(txtEmail.Text,txtPassword.Text);

      Close();
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
      SetSaveEnabled();
    }

    private void SetSaveEnabled()
    {
      btnSave.Enabled = !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtEmail.Text);
    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {
      SetSaveEnabled();
    }

    private void txtEmail_Leave(object sender, EventArgs e)
    {
      Regex mRegxExpression;
      if (txtEmail.Text.Trim() != string.Empty)
      {
        mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

        if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
        {
          MessageBox.Show(@"E-mail address format is not correct.", @"Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtEmail.Focus();
        }
      }
    }

    private void txtPassword_Leave(object sender, EventArgs e)
    {
      var pass = txtPassword.Text;

      var hasNumber = new Regex(@"[0-9]+");
      var hasUpperChar = new Regex(@"[A-Z]+");
      var hasMinimum8Chars = new Regex(@".{8,}");

      if (!(hasNumber.IsMatch(pass) && hasUpperChar.IsMatch(pass) && hasMinimum8Chars.IsMatch(pass)))
      {
        MessageBox.Show(@"Password must contain at least one number, one upper case letter, and be at least 8 characters.", @"Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtPassword.Focus();
      }
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}
