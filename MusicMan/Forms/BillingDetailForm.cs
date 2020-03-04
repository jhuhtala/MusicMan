using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicMan
{
  public partial class BillingDetailForm : Form
  {
    private readonly int _billingDetailKey;


    /// <summary>Initializes a new instance of the <see cref="BillingDetailForm" /> class.</summary>
    /// <param name="billingDetailKey">The billing detail key.</param>
    public BillingDetailForm(int billingDetailKey)
    {
      _billingDetailKey = billingDetailKey;
      InitializeComponent();
      SetInitialValues();
    }

    /// <summary>Sets the initial form control values.</summary>
    private void SetInitialValues()
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

    /// <summary>Handles the Click event of the btnSave control. Saves changes to the current billing record.
    /// Only the amount can change </summary>
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