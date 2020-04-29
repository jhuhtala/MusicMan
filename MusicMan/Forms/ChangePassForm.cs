using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMan.Forms
{
  public partial class ChangePassForm : Form
  {
    public ChangePassForm()
    {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      if (txtNewPass.Text != txtNewPass2.Text)
      {
        MessageBox.Show(@"New Passwords do not match.");
        return;
      }

      var user = User.GetUserFromEmail(txtEmail.Text);

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

      user.UpdateUser(txtNewPass.Text);




    }

    private void txtNewPass_TextChanged(object sender, EventArgs e)
    {
      var pass = txtNewPass.Text;

      var hasNumber = new Regex(@"[0-9]+");
      var hasUpperChar = new Regex(@"[A-Z]+");
      var hasMinimum8Chars = new Regex(@".{8,}");

      if (!(hasNumber.IsMatch(pass) && hasUpperChar.IsMatch(pass) && hasMinimum8Chars.IsMatch(pass)))
      {
        MessageBox.Show(@"Password must contain at least one number, one upper case letter, and be at least 8 characters.", @"Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNewPass.Focus();
      }
    }
  }
}
