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
    }
}