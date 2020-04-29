using System.Linq;

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

    public static void UpdateUser(string email, string companyName, string payPal, string venmo, string twilioSID, string twilioAuthKey, string twilioPhone)
    {
      using (var db = new MusicManEntities())
      {
        var user = db.Users.FirstOrDefault(x => x.Email == email);
        if (user != null)
        {
          user.CompanyName = companyName;
          user.PayPalEmail = payPal;
          user.VenmoUser = venmo;
          user.TwilioAccountSid = twilioSID;
          user.TwilioAuthToken = twilioAuthKey;
          user.TwilioPhoneNumber = twilioPhone;
          db.SaveChanges();
        }
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