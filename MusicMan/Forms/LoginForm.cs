using System;
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


  }
}
