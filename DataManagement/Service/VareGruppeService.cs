using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KundeManagement.Model;

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