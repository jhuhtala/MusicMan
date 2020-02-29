using System;
using System.Linq;

namespace MusicMan
{
    public class BillingService
    {
        public static void CreateInvoices()
        {
            var date = DateTime.Now;
            var fromDate = new DateTime(date.Year, date.Month, 1);
            var toDate = fromDate.AddMonths(1);

            var context = new MusicManEntities();
            var parents = context.People.Where(x => x.IsParent == true && x.IsActive == true)
                .Select(x => new { x.PersonID}).ToList();

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
                            select new { p.PersonID, p.Rate};

                        var studentList = students.ToList();

                        foreach (var student in studentList)
                        {
                            total += student.Rate ?? 0;
                        }

                        if (total > 0)
                        {
                            CreateBillingEntry(parentId, total);
                        }
                    }
                }
            }
        }

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

        public static object GetBillingEntryList(int personID, DateTime start, DateTime end)
        {
            using (var db = new MusicManEntities())
            {
                var billingEntries = from p in db.People
                    join b in db.BillingDetails on p.PersonID equals b.PersonID
                    orderby b.BilledDate
                    where p.PersonID == personID && b.BilledDate >= start && b.BilledDate <= end
                    select new { b.BillingDetailID, b.BilledDate, b.Amount, b.IsInvoiced, b.IsPaid, };

                return billingEntries.ToList();
            }
        }
    }
}