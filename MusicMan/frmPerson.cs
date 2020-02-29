using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicMan
{
    public partial class FrmPerson : Form
    {
        public int PersonKey { get; }
        public int ParentKey { get; set; }
        public bool IsParent { get; }
        public bool IsNew { get; }

        public FrmPerson(int personKey, bool isParent, bool isNew)
        {
            PersonKey = personKey;
            IsParent = isParent;
            IsNew = isNew;

            InitializeComponent();
            SetValues();
            SetVisibility();
        }

        private void SetVisibility()
        {
            chkPaypal.Visible = IsParent;
            chkVenmo.Visible = IsParent;
            lblInvoiceDay.Visible = IsParent;
            numInvoiceDay.Visible = IsParent;
            lblRate.Visible = !IsParent;
            numRate.Visible = !IsParent;
            lblParent.Visible = !IsParent;
            cboParent.Visible = !IsParent;
        }

        private void SetValues()
        {
            if (!IsNew)
            {
                using (var db = new MusicManEntities())
                {
                    var person = db.People.FirstOrDefault(x => x.PersonID == PersonKey);
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

                        LoadParentName(person);
                    }
                }
            }
        }

        private void LoadParentName(Person person)
        {
            var parent = person.GetParent(person);

            var parents = Person.GetParents();
            cboParent.DisplayMember = "FirstLast";
            cboParent.ValueMember = "PersonID";

            cboParent.DataSource = parents;

            if (parent != null)
            {
                cboParent.SelectedValue = parent.PersonID;
                ParentKey = parent.PersonID;
            }
            else
            {
                cboParent.SelectedItem = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                return;
            }
            Save();
            Close();
        }

        private void Save()
        {


            using (var db = new MusicManEntities())
            {
                var person = PersonKey > 0 ? db.People.FirstOrDefault(x => x.PersonID == PersonKey) : new Person();
       
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
                person.IsParent = IsParent;

                if (!IsParent)
                {
                    if (cboParent.SelectedItem is Person selectedParent &&  ParentKey != selectedParent.PersonID)
                    {
                        if (person.Relationships.FirstOrDefault() != null)
                        {
                            person.Relationships.FirstOrDefault().ParentID = selectedParent.PersonID;
                        }
                        else
                        {
                            var relationship = new Relationship { ChildID = PersonKey, ParentID = selectedParent.PersonID };
                            db.Relationships.Add(relationship);
                        }
                    }
                }

                if (PersonKey == 0)
                {
                    db.People.Add(person);
                }

                db.SaveChanges();
            }
        }

        private bool ValidateSave()
        {


            if (txtFirstName.Text == "")
            {
                errProvider.SetError(txtFirstName, @"Please enter a first name.");
                return false;
            }
            errProvider.Clear();

            if (txtLastName.Text == "")
            {
                errProvider.SetError(txtLastName, @"Please enter a last name.");
                return false;
            }
            errProvider.Clear();

            if (!IsParent && cboParent.SelectedItem == null)
            {
                errProvider.SetError(cboParent, @"Please select a parent for this student.");
                return false;
            }
            errProvider.Clear();

            if (!IsParent && cboDayOfWeek.SelectedItem == null)
            {
                errProvider.SetError(cboDayOfWeek, @"Please select a day of the week.");
                return false;
            }

            errProvider.Clear();
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
