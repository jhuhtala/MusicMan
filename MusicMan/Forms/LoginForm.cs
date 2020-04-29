using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicMan
{
  public partial class Login : Form
  {
    public User user;
    public Login()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      user = User.GetUserFromEmail(txtEmail.Text);

      if (user == null)
      {
        MessageBox.Show(@"Incorrect Username or Password");
        return;
      }
      var result = SecurePasswordHasher.Verify(txtPass.Text, user.PasswordHash);
      if (!result)
      {
        MessageBox.Show(@"Incorrect Username or Password");
        return;
      }

      DialogResult = DialogResult.OK;
      Close();
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
  }
}
