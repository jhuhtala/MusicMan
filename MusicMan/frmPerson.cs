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
            lblParent.Visible = !_isParent;
            txtParent.Visible = !_isParent;
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
                        if (person.Rate != null) numRate.Value = (decimal) person.Rate;
                        if (person.InvoiceDay != null) numInvoiceDay.Value = (decimal) person.InvoiceDay;

                        var parent = person.GetParent(person);
                        if (parent != null)
                        {
                            txtParent.Text = parent.FirstLast;
                        }
                         
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            using (var db = new MusicManEntities())
            {
                var person = _personKey > 0 ? db.People.FirstOrDefault(x => x.PersonID == _personKey) : new Person();
       
                if (person == null) return;
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

                if (_personKey == 0)
                {
                    db.People.Add(person);
                }

                db.SaveChanges();
            }
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectParent_Click(object sender, EventArgs e)
        {
            lstParents.Visible = true;
            var parents = Person.GetParents();
            //lstParents.Items.Clear();

            lstParents.DisplayMember = "FirstLast";
            lstParents.ValueMember = "PersonID";
            lstParents.DataSource = parents;


            //foreach (var parent in parents)
            //{
            //    lstParents.Items.Add(parent.p);
            //}
        }

        private void lstParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstParents.Visible = false;
        }
    }
}
