using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twilio;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MusicMan
{
  public class BillingService
  {
    /// <summary>Creates the invoices for the current month.</summary>

  public static void CreateInvoices()
    {
      var date = DateTime.Now.AddMonths(-1);
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
                      x.BillMonth >= fromDate && x.BillMonth < toDate);

        if (billCount == 0)
        {
          var total = 0;
          using (var db = new MusicManEntities())
          {
            var studentQuery = from r in db.Relationships
              join p in db.People on r.ChildID equals p.PersonID
              join s in db.Schedules on p.PersonID equals s.PersonID
              where r.ParentID == parentId
              select new {p.PersonID, p.Rate, s.DayOfTheWeek, };

            var studentView = studentQuery.ToList();

            foreach (var student in studentView)
            {
              var dayOfWeek = (DayOfWeek)student.DayOfTheWeek;
              var numLessons = CountDays(dayOfWeek, fromDate, toDate);

              total += numLessons * student.Rate.Value;
            }
            if (total > 0) CreateBillingEntry(parentId, total, fromDate);
          }
        }
      }
    }

    static int CountDays(DayOfWeek day, DateTime start, DateTime end)
    {
      TimeSpan ts = end - start;                       // Total duration
      int count = (int)Math.Floor(ts.TotalDays / 7);   // Number of whole weeks
      int remainder = (int)(ts.TotalDays % 7);         // Number of remaining days
      int sinceLastDay = (int)(end.DayOfWeek - day);   // Number of days since last [day]
      if (sinceLastDay < 0) sinceLastDay += 7;         // Adjust for negative days since last [day]

      // If the days in excess of an even week are greater than or equal to the number days since the last [day], then count this one, too.
      if (remainder >= sinceLastDay) count++;

      return count;
    }




    /// <summary>Creates the billing entry.</summary>
    /// <param name="parentId">The parent identifier.</param>
    /// <param name="total">The total.</param>
    private static void CreateBillingEntry(int parentId, int total, DateTime fromDate)
    {
      using (var db = new MusicManEntities())
      {
        var bill = new BillingDetail
        {
          PersonID = parentId,
          BilledDate = DateTime.Today,
          Amount = total,
          IsInvoiced = false,
          IsPaid = false,
          BillMonth = fromDate
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
          orderby b.BillMonth
          where p.PersonID == parentId && b.BillMonth >= start && b.BillMonth <= end
          select new {b.BillingDetailID, b.BillMonth, b.Amount, b.IsInvoiced, b.IsPaid};

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



    public static void SendInvoices()
    {
      using (var db = new MusicManEntities())
      {
        var unsentInvoices = db.BillingDetails.Where( x => x.IsInvoiced == false);
        foreach (var unsentInvoice in unsentInvoices)
        {
          if (unsentInvoice.Person.InvoiceDay <= DateTime.Today.Day) 
          {
            SendInvoice(unsentInvoice, unsentInvoice.Person.Phone);
          }

          unsentInvoice.IsInvoiced = true;
          
        }
        db.SaveChanges();
      }

    }

    private static void SendInvoice(BillingDetail invoice, string phone)
    {
      var body = BuildBody(invoice);
      
      MessageService.SendMessage(body, "+1"+phone);
    }

    private static string BuildBody(BillingDetail invoice)
    {
      var month = invoice.BillMonth.Value.ToString("MMMM");
      var user = User.GetDefaultUser();

      var body = new StringBuilder();
      body.Append("Your invoice for ");
      body.Append(user.CompanyName);
      body.Append(" for the month of ");
      body.Append(month);
      body.Append(" is due. Your total is $");
      body.Append(invoice.Amount);
      body.Append(". You can send a PayPal to ");
      body.Append(user.PayPalEmail);
      body.Append(" or Venmo to ");
      body.Append(user.VenmoUser);
      return body.ToString();
    }
  }
}