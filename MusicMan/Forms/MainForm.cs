﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

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
      //Store previously selected row
      //var selected = 0;
      //if (grdBilling.RowCount > 0) selected = grdBilling.SelectedCells[0].RowIndex;

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

      //Restore selected row
      //if (selected != 0) grdBilling.Rows[selected].Selected = true;
    }

    private void monthView1_SelectionChanged(object sender, EventArgs e)
    {
      calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
    }

    private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
    {

      var span = new TimeSpan(0, 0, 30, 0, 0);

      var calendarItem = new CalendarItem(calendar1, DateTime.Now, span,"Test");

      //foreach (CalendarItem item in loadedItems)
      //{
        calendar1.Items.Add(calendarItem);
      //}

      //Or even better....
      //calendar1.Items.AddRange(loadedItems);
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

    private void grdParents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnEditParent_Click(null, null);
    }

    private void lstBillParents_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadBillingGrid();
    }

    private void btnNewStudent_Click(object sender, EventArgs e)
    {
      var m = new FrmPerson(0, false, true);
      m.ShowDialog();
      LoadStudentGrid();
    }

    private void btnEditStudent_Click(object sender, EventArgs e)
    {
      var selectedRowIndex = grdStudents.SelectedCells[0].RowIndex;
      var selectedRow = grdStudents.Rows[selectedRowIndex];
      var personID = Convert.ToInt16(selectedRow.Cells["PersonID"].Value);

      var m = new FrmPerson(personID, false, false);
      m.ShowDialog();
      LoadStudentGrid();
    }

    private void grdStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnEditStudent_Click(null, null);
    }

    private void dtToOrFrom_ValueChanged(object sender, EventArgs e)
    {
      LoadBillingGrid();
    }

    private void btnInvoice_Click(object sender, EventArgs e)
    {
      BillingService.CreateInvoices();
      MessageBox.Show(@"Invoices Created");
      LoadBillingGrid();
    }

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

    private void grdBilling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnEditInvoice_Click(null, null);
    }

    private void btnMarkPaid_Click(object sender, EventArgs e)
    {
      var selectedRowIndex = grdBilling.SelectedCells[0].RowIndex;

      var selectedRow = grdBilling.Rows[selectedRowIndex];
      var billingId = Convert.ToInt16(selectedRow.Cells["BillingDetailID"].Value);

      BillingService.MarkInvoiceAsPaid(billingId);

      LoadBillingGrid();
    }

    private void btnSendInvoices_Click(object sender, EventArgs e)
    {
      BillingService.SendInvoices();
    }
  }
}