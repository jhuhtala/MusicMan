using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MusicMan
{
  public class MessageService
  {
    public static bool IsMessagingSetup()
    {
      var user = User.GetDefaultUser();
      return !string.IsNullOrEmpty(user.TwilioAccountSid) && !string.IsNullOrEmpty(user.TwilioAuthToken) && !string.IsNullOrEmpty(user.TwilioPhoneNumber);
    }


    public static void SendMessage(string body, string toPhone)
    {
      var user = User.GetDefaultUser();
      var accountSid = user.TwilioAccountSid;
      var authToken = user.TwilioAuthToken;
      var phoneFrom = user.TwilioPhoneNumber;
      var client = new TwilioRestClient(accountSid, authToken);

      MessageResource.Create(
        to: new PhoneNumber(toPhone),
        from: new PhoneNumber("+"+ phoneFrom),
        body: body,
        client: client);
    }
  }
}