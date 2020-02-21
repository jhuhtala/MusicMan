using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicMan
{
    public partial class FrmPerson : Form
    {
        private readonly int _personKey;
        private readonly bool _isParent;
        private readonly bool _isNew;

        public FrmPerson(int personKey, bool isParent, bool isNew)
        {
            _personKey = personKey;
            _isParent = isParent;
            _isNew = isNew;

            InitializeComponent();
            SetValues();
            SetVisibility();
        }

        private void SetVisibility()
        {
            chkPaypal.Visible = _isParent;
            chkVenmo.Visible = _isParent;
            lblInvoiceDay.Visible = _isParent;
            numInvoiceDay.Visible = _isParent;
            lblRate.Visible = !_isParent;
            numRate.Visible = !_isParent;
        }

        private void SetValues()
        {
            if (!_isNew)
            {
                using (var db = new MusicManEntities())
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
                        numRate.Value = (decimal)person.Rate;
                        numInvoiceDay.Value = (decimal)person.InvoiceDay;
                    }
                }
            }
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
            Close();
        }

        private void SaveNew()
        {
            using (var db = new MusicManEntities())
            {
                var person = new Person();
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Email = txtEmail.Text;
                person.Phone = txtPhone.Text;
                person.InvoiceDay = (int?)numInvoiceDay.Value;
                person.Rate = (int?)numRate.Value;
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
            using (var db = new MusicManEntities())
            {
                var person = db.People.FirstOrDefault(x => x.PersonID == _personKey);

                if (person == null) return;
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Email = txtEmail.Text;
                person.Phone = txtPhone.Text;
                person.InvoiceDay = (int?) numInvoiceDay.Value;
                person.Rate = (int?) numRate.Value;
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
