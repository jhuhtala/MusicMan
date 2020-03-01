using System.Collections.Generic;
using System.Linq;

namespace MusicMan
{
  public partial class Person
  {
    public string FullName => LastName + ", " + FirstName;

    public string FirstLast => FirstName + " " + LastName;

    public string PersonList => LastName + ", " + FirstName + " " + Phone + " " + Email +
                                (IsPaypal.HasValue && IsPaypal.Value ? " PayPal" : " Venmo");

    /// <summary>Gets the parent from a given student.</summary>
    /// <param name="person">The person.</param>
    /// <returns></returns>
    public Person GetParent()
    {
      using (var db = new MusicManEntities())
      {
        var relationship = db.Relationships
          .FirstOrDefault(s => s.ChildID == PersonID);

        if (relationship != null)
        {
          var parent = db.People.Find(relationship.ParentID);
          return parent;
        }

        return null;
      }
    }

    public static Person GetPersonFromId(int personId)
    {
      using (var db = new MusicManEntities())
      {
        var person = db.People.FirstOrDefault(x => x.PersonID == personId);
        return person;
      }
    }

    //Static methods
    /// <summary>Gets all parents.</summary>
    /// <returns></returns>
    public static List<Person> GetParents()
    {
      using (var db = new MusicManEntities())
      {
        var parents = db.People.Where(x => x.IsParent == true);
        return parents.ToList();
      }
    }

    public static object GetParentGridList()
    {
      var context = new MusicManEntities();
      return context.People.Where(x => x.IsParent == true).OrderBy(x => x.LastName)
        .Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.IsVenmo, x.IsPaypal }).ToList();
    }

    public static object GetStudentGridList()
    {
      var context = new MusicManEntities();
      return context.People.Where(x => x.IsParent == false).OrderBy(x => x.LastName)
        .Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.Rate, x.IsActive }).ToList();
    }


  }
}