namespace DataManagement.Model
{
    //Customer Model
    public class Kunde
    {
        public int KundeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string Email { get; set; }

        public string FullName
        { get { return FirstName + " " + LastName; } }
        //Skrevet af Erik og vedligholdt
    }
}