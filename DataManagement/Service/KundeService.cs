using DataManagement.Model;
using System.Collections.Generic;

namespace DataManagement.Service
{
    public class KundeService
    {
        public List<Kunde> GetAllKunder()
        {
            return new Repository.KundeRepository().GetAllKunder();
        }
        public Kunde GetKunde(int kundeId)
        {
            return new Repository.KundeRepository().GetKunde(kundeId);
        }
        public void SaveNewKunde(Kunde kunde)
        {
            new Repository.KundeRepository().SaveNewKunde( kunde);
        }
        public void EditEmployee(Kunde kunde)
        {
             new Repository.KundeRepository().EditEmployee(kunde);
        }
        public void DeleteKunde(Kunde kunde)
        {
             new Repository.KundeRepository().DeleteKunde(kunde);
        }
    }
}