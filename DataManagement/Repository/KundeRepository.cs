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

                    kunde.KundeID = dbKunde.;
                    kunde.FirstName = dbKunde.;
                    kunde.LastName = dbKunde.;
                    kunde.Street = dbKunde.;
                    kunde.City = dbKunde.;
                    kunde.Address=dbKunde.;
                    kunde.Zipcode = dbKunde.e;
                    kunde.PhoneNumber = dbKunde.;
                }
                return result;
            }
        }
    
}