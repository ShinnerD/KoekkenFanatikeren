using DataManagement.Database;
using System.Collections.Generic;
using DataManagement.Model;
using System.Linq;

//Skrevet af Erik og vedligholdt 
namespace DataManagement.Repository
{
    public class KundeRepository
    {
        private KFDataClassesDataContext DataContext { get; set; }

        public KundeRepository()
        {
            DataContext = new KFDataClassesDataContext();
        }

        public List<Kunde> GetAllKunder()
        {
            List<Kunde> result = new List<Kunde>();

            var dbKundes = DataContext.Customers;
            foreach (var dbKunde in dbKundes)
            {
                Kunde kunde = new Kunde();

                kunde.KundeID = dbKunde.Customer_Id;
                kunde.FirstName = dbKunde.FirstName;
                kunde.LastName = dbKunde.LastName;
                kunde.Street = dbKunde.Streetname;
                kunde.City = dbKunde.City;
                kunde.Zipcode = dbKunde.Zipcode;
                kunde.PhoneNumber = dbKunde.Phonenumber;
                kunde.Email = dbKunde.Email;

                result.Add(kunde);
            }
            return result;
        }

        public Kunde GetKunde(int kundeId)
        {
            Kunde kunde = new Kunde();

            var dbKunde = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == kundeId);

            kunde.KundeID = dbKunde.Customer_Id;
            kunde.FirstName = dbKunde.FirstName;
            kunde.LastName = dbKunde.LastName;
            kunde.Street = dbKunde.Streetname;
            kunde.City = dbKunde.City;
            kunde.Zipcode = dbKunde.Zipcode;
            kunde.PhoneNumber = dbKunde.Phonenumber;
            kunde.Email = dbKunde.Email;

            return kunde;
        }


    }

}