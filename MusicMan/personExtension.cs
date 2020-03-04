using System.Collections.Generic;
using System.Linq;

namespace MusicMan
{
  public partial class Person
  {
    /// <summary>Gets the full name with "Last, First" format.</summary>
    /// <value>The full name.</value>
    public string FullName => LastName + ", " + FirstName;

    /// <summary>Gets the full name with "First Last" format.</summary>
    /// <value>The first last.</value>
    public string FirstLast => FirstName + " " + LastName;


    /// <summary>
    ///   <para>
    ///  Gets the person list.
    /// </para>
    /// </summary>
    /// <value>The person list.</value>
    public string PersonList => LastName + ", " + FirstName + " " + Phone + " " + Email +
                                (IsPaypal.HasValue && IsPaypal.Value ? " PayPal" : " Venmo");

    /// <summary>Gets the parent from the current student.</summary>
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
    

    //public static Person GetStudentsFromParentId(int parentId)
    //{
    //  using (var db = new MusicManEntities())
    //  {
    //    var relationship = db.Relationships
    //      .ToList(s => s.ParentID == parentId);

    //    if (relationship != null)
    //    {
    //      var parent = db.People.Find(relationship.ParentID);
    //      return parent;
    //    }

    //    return null;
    //  }
    //}
    


    /// <summary>Gets the person from primary key.</summary>
    /// <param name="personId">The person identifier.</param>
    /// <returns></returns>
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
    
    /// <summary>Gets the parent grid list.</summary>
    /// <returns></returns>
    public static object GetParentGridList()
    {
      var context = new MusicManEntities();
      return context.People.Where(x => x.IsParent == true).OrderBy(x => x.LastName)
        .Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.IsVenmo, x.IsPaypal }).ToList();
    }

    /// <summary>Gets the student grid list.</summary>
    /// <returns></returns>
    public static object GetStudentGridList()
    {
      var context = new MusicManEntities();

      return context.People.Where(x => x.IsParent == false).OrderBy(x => x.LastName)
        .Select(x => new { x.PersonID, x.LastName, x.FirstName, x.Phone, x.Email, x.Rate, x.IsActive }).ToList();
    }

  }
}