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
    }
}