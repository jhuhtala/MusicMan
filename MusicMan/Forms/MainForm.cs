using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using MusicMan.Forms;
using GridPrintPreviewLib;

namespace MusicMan
{
  public partial class Main : Form
  {
    private List<CalendarItem> _items = new List<CalendarItem>();
    private CalendarItem contextItem = null;

    public Main()
    {
      InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
      dtFrom.Value = DateTime.Today.AddDays(-90);
      LoadBillParentsList();
      LoadParentGrid();
      LoadStudentGrid();
      LoadBillingGrid();
      LoadUserConfig();
      calendar1_LoadItems(null, null);
    }

    /// <summary>Loads the user configuration.</summary>
    private void LoadUserConfig()
    {
      var user = User.GetDefaultUser();

      if (user == null)
      {
        var m = new UserCreationForm();
        m.ShowDialog();
        user = User.GetDefaultUser();
      }
      else
      {
        var m = new Login();
        var result = m.ShowDialog();
        user = result == DialogResult.OK ? m.user : null;
      }

      if (user == null)
      {
        Close();
        return;
      }

      txtEmail.Text = user.Email;
      txtBizName.Text = user.CompanyName;
      txtPayPalEmail.Text = user.PayPalEmail;
      txtVenmo.Text = user.VenmoUser;
      txtTwilioSID.Text = user.TwilioAccountSid;
      txtTwilioAuthKey.Text = user.TwilioAuthToken;
      txtTwilioPhone.Text = user.TwilioPhoneNumber;
    }

    /// <summary>Loads the bill parents list.</summary>
    private void LoadBillParentsList()
    {
      var parents = Person.GetParents();
      lstBillParents.DataSource = parents;
      lstBillParents.DisplayMember = "FullName";
      lstBillParents.ValueMember = "PersonID";
    }

    /// <summary>Loads the parent grid.</summary>
    private void LoadParentGrid()
    {
      var selected = 0;
      if (grdParents.RowCount > 0) selected = grdParents.SelectedCells[0].RowIndex;

      var parentList = Person.GetParentGridList();

      grdParents.DataSource = parentList;
      if (grdParents.Columns["PersonID"] != null)
      {
        grdParents.Columns["PersonID"].Visible = false;
        grdParents.Columns["PersonID"].Tag = true;
      }

      grdParents.Columns[1].HeaderCell.Value = "Last";
      grdParents.Columns[2].HeaderCell.Value = "First";
      grdParents.Columns[3].HeaderCell.Value = "Phone";
      grdParents.Columns[3].DefaultCellStyle.Format = "(###)###-####";
      grdParents.Columns[4].HeaderCell.Value = "Email";
      grdParents.Columns[5].HeaderCell.Value = "Venmo";
      grdParents.Columns[6].HeaderCell.Value = "PayPal";

      if (selected != 0) grdParents.Rows[selected].Selected = true;
    }

    /// <summary>Loads the student grid.</summary>
    private void LoadStudentGrid()
    {
      //Store previously selected row
      var selected = 0;
      if (grdStudents.RowCount > 0) selected = grdStudents.SelectedCells[0].RowIndex;

      var studentList = Person.GetStudentGridList();

      //Set Primary Key Field and hide it
      grdStudents.DataSource = studentList;
      if (grdStudents.Columns["PersonID"] != null)
      {
        grdStudents.Columns["PersonID"].Visible = false;
        grdStudents.Columns["PersonID"].Tag = true;
      }

      //Set header values
      grdStudents.Columns[1].HeaderCell.Value = "Last";
      grdStudents.Columns[2].HeaderCell.Value = "First";
      grdStudents.Columns[3].HeaderCell.Value = "Phone";
      grdStudents.Columns[4].HeaderCell.Value = "Email";
      grdStudents.Columns[5].HeaderCell.Value = "Rate";
      grdStudents.Columns[6].HeaderCell.Value = "Active";

      //Restore previously selected row
      if (selected != 0) grdStudents.Rows[selected].Selected = true;
    }

    /// <summary>Loads the billing grid.</summary>
    private void LoadBillingGrid()
    {
      
      if (!(lstBillParents.SelectedItem is Person selectedPerson)) return;

      //Get list of billing entries related to the parent
      var billingList = BillingService.GetBillingEntryList(selectedPerson.PersonID, dtFrom.Value, dtTo.Value);

      //Set primary key field and hide that column
      grdBilling.DataSource = billingList;
      if (grdBilling.Columns["BillingDetailID"] != null)
      {
        grdBilling.Columns["BillingDetailID"].Visible = false;
        grdBilling.Columns["BillingDetailID"].Tag = true;
      }

      //Set header Names
      grdBilling.Columns[1].HeaderCell.Value = "Date";
      grdBilling.Columns[2].HeaderCell.Value = "Amount";
      grdBilling.Columns[3].HeaderCell.Value = "Invoiced";
      grdBilling.Columns[4].HeaderCell.Value = "Paid";

    }

    /// <summary>Handles the SelectionChanged event of the monthView1 control.</summary>
    private void monthView1_SelectionChanged(object sender, EventArgs e)
    {
      calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
    }

    /// <summary>Handles the LoadItems event of the calendar1 control.</summary>
    private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
    {
      var start = monthView1.SelectionStart;
      var end = monthView1.SelectionEnd;

      foreach (var student in Person.GetActiveStudents())
      {
        var schedule = Schedule.GetScheduleFromStudentId(student.PersonID);
        var dayOfWeek = (DayOfWeek)schedule.DayOfTheWeek;
        var scheduleDays = Schedule.GetDayOfWeekDatesBetween(start, end, dayOfWeek);
        var timeSpan = schedule.TimeOfDay.Value;

        foreach (var scheduleDay in scheduleDays)
        {
          var span = new TimeSpan(0, 0, 30, 0, 0);

          var dt = scheduleDay.Date + timeSpan;

          var calendarItem = new CalendarItem(calendar1, dt, span, student.FirstLast);
          calendarItem.ApplyColor(Color.DarkTurquoise);
          calendar1.Items.Add(calendarItem);
        }
      }
    }

    /// <summary>Handles the Click event of the btnEditParent control.</summary>
    private void btnEditParent_Click(object sender, EventArgs e)
    {
      var selectedRowIndex = grdParents.SelectedCells[0].RowIndex;
      var selectedRow = grdParents.Rows[selectedRowIndex];
      var parentId = Convert.ToInt16(selectedRow.Cells["PersonID"].Value);

      var m = new FrmPerson(parentId, true, false);
      m.ShowDialog();
      LoadParentGrid();
    }

    /// <summary>Handles the Click event of the btnNewParent control.</summary>
    private void btnNewParent_Click(object sender, EventArgs e)
    {
      var m = new FrmPerson(0, true, true);
      m.ShowDialog();
      LoadParentGrid();
    }

    /// <summary>Handles the CellDoubleClick event of the grdParents control.</summary>
    private void grdParents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnEditParent_Click(null, null);
    }

    /// <summary>Handles the SelectedIndexChanged event of the lstBillParents control.</summary>
    private void lstBillParents_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadBillingGrid();
    }

    /// <summary>Handles the Click event of the btnNewStudent control.</summary>
    private void btnNewStudent_Click(object sender, EventArgs e)
    {
      var m = new FrmPerson(0, false, true);
      m.ShowDialog();
      LoadStudentGrid();
    }

    /// <summary>Handles the Click event of the btnEditStudent control.</summary>
    private void btnEditStudent_Click(object sender, EventArgs e)
    {
      var selectedRowIndex = grdStudents.SelectedCells[0].RowIndex;
      var selectedRow = grdStudents.Rows[selectedRowIndex];
      var personID = Convert.ToInt16(selectedRow.Cells["PersonID"].Value);

      var m = new FrmPerson(personID, false, false);
      m.ShowDialog();
      LoadStudentGrid();
    }

    /// <summary>Handles the CellDoubleClick event of the grdStudents control.</summary>
    private void grdStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnEditStudent_Click(null, null);
    }

    /// <summary>Handles the ValueChanged event of the dtToOrFrom control.</summary>
    private void dtToOrFrom_ValueChanged(object sender, EventArgs e)
    {
      LoadBillingGrid();
    }

    /// <summary>Handles the Click event of the btnInvoice control.</summary>
    private void btnInvoice_Click(object sender, EventArgs e)
    {
      BillingService.CreateInvoices();
      MessageBox.Show(@"Invoices Created");
      LoadBillingGrid();
    }

    /// <summary>Handles the Click event of the btnEditInvoice control.</summary>
    private void btnEditInvoice_Click(object sender, EventArgs e)
    {
      if (grdBilling.RowCount > 0)
      {
        var selectedRowIndex = grdBilling.SelectedCells[0].RowIndex;

        var selectedRow = grdBilling.Rows[selectedRowIndex];
        var billingId = Convert.ToInt16(selectedRow.Cells["BillingDetailID"].Value);

        var m = new BillingDetailForm(billingId);
        m.ShowDialog();
        LoadBillingGrid();
      }
    }

    /// <summary>Handles the CellDoubleClick event of the grdBilling control.</summary>
    private void grdBilling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnEditInvoice_Click(null, null);
    }

    /// <summary>Handles the Click event of the btnMarkPaid control.</summary>
    private void btnMarkPaid_Click(object sender, EventArgs e)
    {
      var selectedRowIndex = grdBilling.SelectedCells[0].RowIndex;

      var selectedRow = grdBilling.Rows[selectedRowIndex];
      var billingId = Convert.ToInt16(selectedRow.Cells["BillingDetailID"].Value);

      BillingService.MarkInvoiceAsPaid(billingId);

      LoadBillingGrid();
    }

    /// <summary>Handles the Click event of the btnSendInvoices control.</summary>
    private void btnSendInvoices_Click(object sender, EventArgs e)
    {
      if (!MessageService.IsMessagingSetup())
      {
        MessageBox.Show(@"Twilio has not yet been setup.  Please do so on the config tab.");
        return;
      }
      BillingService.SendInvoices();
      MessageBox.Show(@"Invoices Sent");
      LoadBillingGrid();
    }

    /// <summary>Handles the Click event of the btnChangePass control.</summary>
    private void btnChangePass_Click(object sender, EventArgs e)
    {
      var m = new ChangePassForm();
      m.ShowDialog();
    }

    /// <summary>Handles the Click event of the btnSave control.</summary>
    private void btnSave_Click(object sender, EventArgs e)
    {
      User.UpdateUser(txtEmail.Text, txtBizName.Text, txtPayPalEmail.Text, txtVenmo.Text, txtTwilioSID.Text, txtTwilioAuthKey.Text, txtTwilioPhone.Text);
      MessageBox.Show("Changes Saved");
    }

    /// <summary>Handles the LinkClicked event of the linkLabel1 control.</summary>
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      linkLabel1.LinkVisited = true;
      System.Diagnostics.Process.Start("https://www.twilio.com/");
    }

    /// <summary>Handles the Click event of the btnPrint control.</summary>
    private void btnPrint_Click(object sender, EventArgs e)
    {
      var doc = new GridPrintDocument(grdBilling,grdBilling.Font, true);
      doc.DocumentName = "Billing Report";

      var printPreviewDialog = new PrintPreviewDialog
      {
        ClientSize = new Size(400, 300),
        Location = new Point(29, 29),
        Name = "Print Preview Dialog",
        UseAntiAlias = true,
        Document = doc
      };
      printPreviewDialog.ShowDialog();
      doc.Dispose();
      doc = null;
    }

  }
}