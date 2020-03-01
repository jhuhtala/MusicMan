using System;
using System.Linq;
using System.Windows.Forms;


namespace MusicMan
{
  public partial class FrmPerson : Form
  {
    /// <summary>
    ///   <para>
    ///     Initializes a new instance of the <see cref="FrmPerson" /> class.
    ///   </para>
    /// </summary>
    /// <param name="personKey">The student key.</param>
    /// <param name="isParent">if set to <c>true</c> [is parent].</param>
    /// <param name="isNew">if set to <c>true</c> [is new].</param>
    public FrmPerson(int personKey, bool isParent, bool isNew)
    {
      PersonKey = personKey;
      IsParent = isParent;
      IsNew = isNew;

      InitializeComponent();
      SetInitialFormValues();
      SetVisibility();
    }

    public int PersonKey { get; }
    public int ParentKey { get; set; }
    public bool IsParent { get; }
    public bool IsNew { get; }

    /// <summary>Sets the visibility.</summary>
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

    /// <summary>Sets the initial form values.</summary>
    private void SetInitialFormValues()
    {
      if (!IsNew)
      {
        var person = Person.GetPersonFromId(PersonKey);

        if (person != null)
        {
          txtFirstName.Text = person.FirstName;
          txtLastName.Text = person.LastName;
          txtEmail.Text = person.Email;
          txtPhone.Text = person.Phone;
          chkActive.Checked = (bool) person.IsActive;
          chkPaypal.Checked = (bool) person.IsPaypal;
          chkVenmo.Checked = (bool) person.IsVenmo;
          if (person.Rate != null) numRate.Value = (decimal) person.Rate;
          if (person.InvoiceDay != null) numInvoiceDay.Value = (decimal) person.InvoiceDay;


          cboDayOfWeek.DataSource = Enum.GetNames(typeof(DaysOfWeekEnum.WeekDays));

          var dt = DateTime.Now;
          var schedule = Schedule.GetScheduleFromStudentId(person.PersonID);
          if (schedule != null)
          {
            var dayOfWeek = (DaysOfWeekEnum.WeekDays)schedule.DayOfTheWeek;
            cboDayOfWeek.SelectedItem = dayOfWeek.ToString();
            var time = schedule.TimeOfDay;
            dt = (DateTime) (dt.Date + time);
          }
          
            
          if (dt.Minute % 30 > 15)
          {
            _initialValue = true;
            dtTime.Value = dt.AddMinutes(dt.Minute % 30);
          }
          else
          {
            _initialValue = true;
            dtTime.Value = dt.AddMinutes(-(dt.Minute % 30));
          }

          _prevDate = dtTime.Value;
          
          



          

          LoadParentName(person);
        }
        
      }
    }

    /// <summary>Loads the name of the parent.</summary>
    /// <param name="student">The student.</param>
    private void LoadParentName(Person student)
    {
      var parent = student.GetParent();

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
      if (!ValidateSave()) return;
      Save();
      Close();
    }

    /// <summary>Saves, or creates if new this instance of person.</summary>
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
        person.InvoiceDay = (int?) numInvoiceDay.Value;
        person.IsActive = chkActive.Checked;
        person.IsVenmo = chkVenmo.Checked;
        person.IsPaypal = chkPaypal.Checked;
        person.IsParent = IsParent;


        //Set values specific to a student
        if (!IsParent)
        {
          if (cboParent.SelectedItem is Person selectedParent && ParentKey != selectedParent.PersonID)
          {
            if (person.Relationships.FirstOrDefault() != null)
            {
              person.Relationships.FirstOrDefault().ParentID = selectedParent.PersonID;
            }
            else
            {
              var relationship = new Relationship {ChildID = PersonKey, ParentID = selectedParent.PersonID};
              db.Relationships.Add(relationship);
            }
          }

          person.Rate = (int?)numRate.Value;

          Enum.TryParse<DayOfWeek>(cboDayOfWeek.SelectedValue.ToString(), out var dayOfWeek);

          Schedule.UpdateScheduleFromStudentId(person.PersonID, dayOfWeek, dtTime.Value.TimeOfDay);
        }

        //Create a new person if a key was not passed in when the form was created.
        if (PersonKey == 0) db.People.Add(person);

        db.SaveChanges();
      }
    }


    private bool ValidateSave()
    {
      errProvider.Clear();
      if (txtFirstName.Text == "")
      {
        errProvider.SetError(txtFirstName, @"Please enter a first name.");
        return false;
      }

      if (txtLastName.Text == "")
      {
        errProvider.SetError(txtLastName, @"Please enter a last name.");
        return false;
      }

      if (!IsParent && cboParent.SelectedItem == null)
      {
        errProvider.SetError(cboParent, @"Please select a parent for this student.");
        return false;
      }

      if (!IsParent && cboDayOfWeek.SelectedItem == null)
      {
        errProvider.SetError(cboDayOfWeek, @"Please select a day of the week.");
        return false;
      }

      if (!IsParent && numRate.Value == 0)
      {
        errProvider.SetError(numRate, @"Please select a rate.");
        return false;
      }

      if (IsParent && numInvoiceDay.Value == 0)
      {
        errProvider.SetError(numInvoiceDay, @"Please select an invoice day.");
        return false;
      }

      return true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }




    private DateTime _prevDate;
    private bool _initialValue = false;

    private void dtTime_ValueChanged(object sender, EventArgs e)
    {
      
        if (_initialValue)
        {
          _initialValue = false;
          return;
        }

        var dt = dtTime.Value;
        var diff = dt - _prevDate;

        dtTime.Value = diff.Ticks < 0 ? _prevDate.AddMinutes(-30) : _prevDate.AddMinutes(30);

        _prevDate = dtTime.Value;
      
    }
  }
}