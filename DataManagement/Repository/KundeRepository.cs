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


        public void SaveNewKunde(Kunde kunde)
        {
            Database.Customer newCustomer = new Database.Customer();

            newCustomer.FirstName = kunde.FirstName;
            newCustomer.LastName = kunde.LastName;
            newCustomer.Streetname = kunde.Street;
            newCustomer.City = kunde.City;
            newCustomer.Zipcode = kunde.Zipcode;
            newCustomer.Phonenumber = kunde.PhoneNumber;
            newCustomer.Email = kunde.Email;

            DataContext.Customers.InsertOnSubmit(newCustomer);
            DataContext.SubmitChanges();
        }


        public void EditEmployee(Kunde kunde)
        {
            var targetKunde = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == kunde.KundeID);

            if (targetKunde != null)
            {
                targetKunde.FirstName = kunde.FirstName;
                targetKunde.LastName = kunde.LastName;
                targetKunde.Phonenumber = kunde.PhoneNumber;
                targetKunde.Streetname = kunde.Street;
                targetKunde.City = kunde.City;
                targetKunde.Zipcode = kunde.Zipcode;
                targetKunde.Email = kunde.Email;

                DataContext.SubmitChanges();
            }
        }
    }
}