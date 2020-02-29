using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace MusicMan
{
    public partial class Person
    {
        public string FullName => LastName + ", " + FirstName;

        public string FirstLast => FirstName + " " + LastName;
        
        public string PersonList => LastName + ", " + FirstName +" " +Phone + " " + Email + (IsPaypal.HasValue && IsPaypal.Value ? " PayPal" : " Venmo");

        public Person GetParent(Person person)
        {
            using (var db = new MusicManEntities())
            {
                var relationship = db.Relationships
                    .FirstOrDefault(s => s.ChildID == person.PersonID);

                if (relationship != null)
                {
                    var parent = db.People.Find(relationship.ParentID);
                    return parent;
                }

                return null;
            }
        }

        public static List<Person> GetParents()
        {
            using (var db = new MusicManEntities())
            {
                var parents = db.People.Where(x => x.IsParent == true);
                return parents.ToList();
            }
        }
    }
}