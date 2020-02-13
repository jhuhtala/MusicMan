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
    public partial class FrmPerson : Form
    {
        private int _personKey;
        private bool _isParent;
        private bool _isNew;

        public FrmPerson(int personKey, bool isParent, bool isNew)
        {
            _personKey = personKey;
            _isParent = isParent;
            _isNew = isNew;

            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            if (!_isNew)
            {
                using (MusicManEntities db = new MusicManEntities())
                {
                    var person = db.People.FirstOrDefault(x => x.PersonID == _personKey);
                    if (person != null)
                    {
                        txtFirstName.Text = person.FirstName;
                        txtLastName.Text = person.LastName;
                        txtEmail.Text = person.Email;
                        txtPhone.Text = person.Phone;
                        chkActive.Checked = (bool)person.IsActive;
                        chkPaypal.Checked = (bool)person.IsPaypal;
                        chkVenmo.Checked = (bool)person.IsVenmo;
                    }
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                SaveNew();
            }
            else
            {
                SaveUpdate();
            }
        }

        private void SaveNew()
        {
            using (MusicManEntities db = new MusicManEntities())
            {
                var person = new Person();
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Email = txtEmail.Text;
                person.Phone = txtPhone.Text;
                person.InvoiceDay = (int?)numInvoiceDay.Value;
                person.IsActive = chkActive.Checked;
                person.IsVenmo = chkVenmo.Checked;
                person.IsPaypal = chkPaypal.Checked;
                person.IsParent = _isParent;

                db.People.Add(person);
                db.SaveChanges();
            }
        }

        private void SaveUpdate()
        {
            using (MusicManEntities db = new MusicManEntities())
            {
                var person = db.People.FirstOrDefault(x => x.PersonID == _personKey);

                if (person == null) return;
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Email = txtEmail.Text;
                person.Phone = txtPhone.Text;
                person.InvoiceDay = (int?) numInvoiceDay.Value;
                person.IsActive = chkActive.Checked;
                person.IsVenmo = chkVenmo.Checked;
                person.IsPaypal = chkPaypal.Checked;
                person.IsParent = _isParent;

                db.SaveChanges();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
