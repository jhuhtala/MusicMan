namespace MusicMan
{
    public partial class Person
    {
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string PersonList
        {
            get
            {
                return LastName + ", " + FirstName +" " +Phone + " " + Email + (IsPaypal.HasValue && IsPaypal.Value ? " PayPal" : " Venmo");
            }
        }
    }
}