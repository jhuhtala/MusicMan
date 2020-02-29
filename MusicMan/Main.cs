using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;


namespace MusicMan
{
    public partial class Main : Form
    {
        List<CalendarItem> _items = new List<CalendarItem>();
        CalendarItem contextItem = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            

            //lstBillParents.SelectedIndex = 1;

            dtFrom.Value = DateTime.Today.AddDays(-90);
            LoadBillParentsList();
            LoadParentGrid();
            LoadStudentGrid();
            LoadBillingGrid();
            

        }

        private void LoadBillParentsList()
        {
            using (var db = new MusicManEntities())
            {
                var parents = db.People.Where(x => x.IsParent == true).OrderBy(x => x.LastName).ToList();
                lstBillParents.DataSource = parents;
                lstBillParents.DisplayMember = "FullName";
                lstBillParents.ValueMember = "PersonID";

            }
        }

        private void LoadParentGrid()
        {
            var selected = 0;
            if (grdParents.RowCount > 0)
            {
                selected = grdParents.SelectedCells[0].RowIndex;
            }

            var parentList = GetParentGridList();

            grdParents.DataSource = parentList;
            if (grdParents.Columns["PersonID"] != null)
            {
                grdParents.Columns["PersonID"].Visible = false;
                grdParents.Columns["PersonID"].Tag = true;
            }
            grdParents.Columns[1].HeaderCell.Value = "Last";
            grdParents.Columns[2].HeaderCell.Value = "First";
            grdParents.Columns[3].HeaderCell.Value = "Phone";
            grdParents.Columns[4].HeaderCell.Value = "Email";
            grdParents.Columns[5].HeaderCell.Value = "Venmo";
            grdParents.Columns[6].HeaderCell.Value = "PayPal";

            if (selected != 0)
            {
                grdParents.Rows[selected].Selected = true;
            }
        }

        private void LoadStudentGrid()
        {
            var selected = 0;
            if (grdStudents.RowCount > 0)
            {
                selected = grdStudents.SelectedCells[0].RowIndex;
            }

            var studentList = GetStudentGridList();

            grdStudents.DataSource = studentList;
            if (grdStudents.Columns["PersonID"] != null)
            {
                grdStudents.Columns["PersonID"].Visible = false;
                grdStudents.Columns["PersonID"].Tag = true;
            }
            grdStudents.Columns[1].HeaderCell.Value = "Last";
            grdStudents.Columns[2].HeaderCell.Value = "First";
            grdStudents.Columns[3].HeaderCell.Value = "Phone";
            grdStudents.Columns[4].HeaderCell.Value = "Email";
            grdStudents.Columns[5].HeaderCell.Value = "Rate";
            grdStudents.Columns[6].HeaderCell.Value = "Active";

            if (selected != 0)
            {
                grdStudents.Rows[selected].Selected = true;
            }
        }

        private void LoadBillingGrid()
        {
            var selected = 0;
            if (grdBilling.RowCount > 0)
            {
                selected = grdBilling.SelectedCells[0].RowIndex;
            }

            if (!(lstBillParents.SelectedItem is Person selectedPerson))
            {
                return;
            }

            var billingList = BillingService.GetBillingEntryList(selectedPerson.PersonID, dtFrom.Value, dtTo.Value);

            grdBilling.DataSource = billingList;
            if (grdBilling.Columns["BillingDetailID"] != null)
            {
                grdBilling.Columns["BillingDetailID"].Visible = false;
                grdBilling.Columns["BillingDetailID"].Tag = true;
            }

            grdBilling.Columns[1].HeaderCell.Value = "Date";
            grdBilling.Columns[2].HeaderCell.Value = "Amount";
            grdBilling.Columns[3].HeaderCell.Value = "Invoiced";
            grdBilling.Columns[4].HeaderCell.Value = "Paid";

            if (selected != 0)
            {
                grdBilling.Rows[selected].Selected = true;
            }
            
        }

        private object GetParentGridList()
        {
            var context = new MusicManEntities();
            return context.People.Where(x => x.IsParent == true).OrderBy(x => x.LastName)
                .Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.IsVenmo, x.IsPaypal }).ToList();
        }

        private object GetStudentGridList()
        {
            var context = new MusicManEntities();
            return context.People.Where(x => x.IsParent == false).OrderBy(x => x.LastName)
                .Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.Rate, x.IsActive }).ToList();
        }

        

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MusicManEntities db = new MusicManEntities())
            {
                var parents = db.People.Where(x => x.IsParent == true);

                //lstBillParents.;
            }
        }

        private void btnEditParent_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = grdParents.SelectedCells[0].RowIndex;
            var selectedRow = grdParents.Rows[selectedRowIndex];
            var personID = Convert.ToInt16(selectedRow.Cells["PersonID"].Value);


            var m = new FrmPerson(personID, true, false);
            m.ShowDialog();
            LoadParentGrid();

        }

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

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadBillingGrid();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
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
            if (grdBilling.RowCount>0)
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
            btnEditInvoice_Click(null,null);
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = grdBilling.SelectedCells[0].RowIndex;

            var selectedRow = grdBilling.Rows[selectedRowIndex];
            var billingId = Convert.ToInt16(selectedRow.Cells["BillingDetailID"].Value);

            using (var db = new MusicManEntities())
            {
                var billingDetail = db.BillingDetails.FirstOrDefault(x => x.BillingDetailID == billingId);
                if (billingDetail != null)
                {
                    billingDetail.IsPaid = true;
                    db.SaveChanges();
                }
            }
            LoadBillingGrid();
        }
    }
}
