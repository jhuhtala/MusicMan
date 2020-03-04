using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMan
{
    public partial class Login : Form
    {
        private const string HashKey = "2c9d3c27-bb3d-4959-8909-40c2ec8e3f64";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(HashPass(txtPass.Text));
            Hide();
            var m = new Main();
            m.Show();
            

        }

        private string HashPass(string inputString)
        {
            var data = Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }
    }
}
