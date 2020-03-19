using System;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;

namespace MusicMan
{
  public partial class User
  {


    public static User GetDefaultUser()
    {
      using (var db = new MusicManEntities())
      {
        return db.Users.FirstOrDefault();
      }
    }

    public static User GetUserFromEmail(string email)
    {
      using (var db = new MusicManEntities())
      {
        return db.Users.FirstOrDefault(x => x.Email == email);
      }
    }


    public static User CreateUser(string email, string password)
    {
      using (var db = new MusicManEntities())
      {
        var user = new User
        {
          Email = email,
          PasswordHash = SecurePasswordHasher.Hash(password)
        };

        //var hash = SecurePasswordHasher.Hash(password);
        db.Users.Add(user);
        db.SaveChanges();
        // Verify
        //var result = SecurePasswordHasher.Verify("mypassword", hash);


        return db.Users.FirstOrDefault();
      }
    }

    public void UpdateUser(string password)
    {

      using (var db = new MusicManEntities())
      {
        PasswordHash = SecurePasswordHasher.Hash(password);
        db.SaveChanges();
      }
    }


  }
}