using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      User.CreateUser(txtEmail.Text,txtPassword.Text);

      Close();
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
      btnSave.Enabled = true;
    }
  }
}
