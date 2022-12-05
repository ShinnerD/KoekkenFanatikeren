using DataManagement.Model;
using System.Collections.Generic;

//Skrevet og vedligeholdt af Erik
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
            new Repository.KundeRepository().SaveNewKunde(kunde);
        }

        public void EditKunde(Kunde kunde)
        {
            new Repository.KundeRepository().EditKunde(kunde);
        }

        public void DeleteKunde(Kunde kunde)
        {
            new Repository.KundeRepository().DeleteKunde(kunde);
        }
    }
}