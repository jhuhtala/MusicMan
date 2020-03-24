using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MusicMan
{
  public class MessageService
  {
    public static void SendMessage(string body)
    {
      var user = User.GetDefaultUser();
      var accountSid = user.TwilioAccountSid;
      var authToken = user.TwilioAuthToken;
      var client = new TwilioRestClient(accountSid, authToken);

      var message = MessageResource.Create(
        to: new PhoneNumber("+19162039457"),
        from: new PhoneNumber("+12058435845"),
        body: body.ToString(),
        client: client);
    }
  }
}