//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicMan
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string CompanyName { get; set; }
        public string PayPalEmail { get; set; }
        public string VenmoUser { get; set; }
        public string TwilioAccountSid { get; set; }
        public string TwilioAuthToken { get; set; }
        public string TwilioPhoneNumber { get; set; }
    }
}
