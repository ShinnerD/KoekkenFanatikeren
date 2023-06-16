using DataManagement.Model;
using System.Collections.Generic;

namespace DataManagement.Service
{
    public class VareGruppeService
    {
        public List<Varegruppe> RetunererAlleVaregruppeService()
        {
            var VaregruppeRepository = new Repository.VareGruppeRepository();
            return VaregruppeRepository.FindAlleVaregruppe();
        }
    }
}