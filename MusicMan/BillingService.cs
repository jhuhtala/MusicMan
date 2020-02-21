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
                        var anonymousObjResult = from r in db.Relationships
                            join p in db.People on r.ChildID equals p.PersonID
                            where r.ParentID == parentId 
                            select new { p.PersonID, p.Rate};

                        var studentList = anonymousObjResult.ToList();

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
    }
}