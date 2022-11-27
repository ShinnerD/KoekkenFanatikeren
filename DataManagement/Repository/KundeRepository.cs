using DataHandling.Model;
using DataManagement.Database;
using System.Collections.Generic;
using System.Linq;
using KundeManagement.Model;
using DataManagement.Model;

namespace KundeManagement.Repository

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
                }
                return result;
            //Skrevet af Erik og vedligholdt 
        }
    }
    
}