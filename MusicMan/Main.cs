using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            var context = new MusicManEntities();
            using (var db = new MusicManEntities())
            {
                var parents = db.People.Where(x => x.IsParent == true).OrderBy(x => x.LastName).ToList();
                lstBillParents.DataSource = parents;
                lstBillParents.DisplayMember = "FullName";
                lstBillParents.ValueMember = "PersonID";
            }

            LoadParentGrid();
            LoadStudentList();

        }

        private void LoadParentGrid()
        {
            var context = new MusicManEntities();
            grdParents.DataSource = context.People.Where(x => x.IsParent == true).OrderBy(x => x.LastName).Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.IsVenmo, x.IsPaypal }).ToList();
            
        }

        private void LoadStudentList()
        {
            var context = new MusicManEntities();
            using (var db = new MusicManEntities())
            {
                var parents = db.People.Where(x => x.IsParent == false).OrderBy(x => x.LastName).ToList();
                lstStudents.DataSource = parents;
                lstStudents.DisplayMember = "personList";
                lstStudents.ValueMember = "PersonID";
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var m = new FrmPerson(1, true, false);
            m.Show();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var m = new FrmPerson(0, true, true);
            m.Show();
            LoadParentGrid();
        }
    }
}
