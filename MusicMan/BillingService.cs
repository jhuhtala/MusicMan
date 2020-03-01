using System;
using System.Linq;

namespace MusicMan
{
  public class BillingService
  {
    /// <summary>Creates the invoices for the current month.</summary>
    public static void CreateInvoices()
    {
      var date = DateTime.Now;
      var fromDate = new DateTime(date.Year, date.Month, 1);
      var toDate = fromDate.AddMonths(1);

      var context = new MusicManEntities();
      var parents = context.People.Where(x => x.IsParent == true && x.IsActive == true)
        .Select(x => new {x.PersonID}).ToList();

      foreach (var parent in parents)
      {
        var parentId = parent.PersonID;
        var billCount = context.BillingDetails
          .Count(x => x.PersonID == parentId &&
                      x.BilledDate >= fromDate && x.BilledDate < toDate);

        if (billCount == 0)
        {
          var total = 0;
          using (var db = new MusicManEntities())
          {
            var students = from r in db.Relationships
              join p in db.People on r.ChildID equals p.PersonID
              where r.ParentID == parentId
              select new {p.PersonID, p.Rate};

            var studentList = students.ToList();

            foreach (var student in studentList) total += student.Rate ?? 0;

            if (total > 0) CreateBillingEntry(parentId, total);
          }
        }
      }
    }

    /// <summary>Creates the billing entry.</summary>
    /// <param name="parentId">The parent identifier.</param>
    /// <param name="total">The total.</param>
    private static void CreateBillingEntry(int parentId, int total)
    {
      using (var db = new MusicManEntities())
      {
        var bill = new BillingDetail
        {
          PersonID = parentId,
          BilledDate = DateTime.Today,
          Amount = total,
          IsInvoiced = false,
          IsPaid = false
        };

        db.BillingDetails.Add(bill);
        db.SaveChanges();
      }
    }

    /// <summary>Gets the billing entry list.</summary>
    /// <param name="parentId">The parent identifier.</param>
    /// <param name="start">The start date.</param>
    /// <param name="end">The end date.</param>
    /// <returns>A list of billing entries related to a given parent, within a certain date range</returns>
    public static object GetBillingEntryList(int parentId, DateTime start, DateTime end)
    {
      using (var db = new MusicManEntities())
      {
        var billingEntries = from p in db.People
          join b in db.BillingDetails on p.PersonID equals b.PersonID
          orderby b.BilledDate
          where p.PersonID == parentId && b.BilledDate >= start && b.BilledDate <= end
          select new {b.BillingDetailID, b.BilledDate, b.Amount, b.IsInvoiced, b.IsPaid};

        return billingEntries.ToList();
      }
    }

    /// <summary>Marks the invoice as paid.</summary>
    /// <param name="billingId">The billing identifier.</param>
    public static void MarkInvoiceAsPaid(short billingId)
    {
      using (var db = new MusicManEntities())
      {
        var billingDetail = db.BillingDetails.FirstOrDefault(x => x.BillingDetailID == billingId);
        if (billingDetail != null)
        {
          billingDetail.IsPaid = true;
          db.SaveChanges();
        }
      }
    }
  }
}