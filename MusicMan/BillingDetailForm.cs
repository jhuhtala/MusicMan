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
    public partial class BillingDetailForm : Form
    {
        private readonly int _billingDetailKey;

        public BillingDetailForm(int billingDetailKey)
        {
            _billingDetailKey = billingDetailKey;
            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            using (var db = new MusicManEntities())
            {
                var billingDetail = db.BillingDetails.FirstOrDefault(x => x.BillingDetailID == _billingDetailKey);
                if (billingDetail != null)
                {
                    if (billingDetail.BilledDate != null)
                        txtInvoiceDate.Text = billingDetail.BilledDate.Value.ToShortDateString();
                    txtParentName.Text = billingDetail.Person.FullName;
                    txtTotal.Text = billingDetail.Amount.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new MusicManEntities())
            {
                var billingDetail = db.BillingDetails.FirstOrDefault(x => x.BillingDetailID == _billingDetailKey);

                if (billingDetail == null) return;
                billingDetail.Amount = Convert.ToDecimal(txtTotal.Text);
                db.SaveChanges();
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
