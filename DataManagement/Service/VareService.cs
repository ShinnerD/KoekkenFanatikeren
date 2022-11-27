using KundeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeManagement.Service
{
    public class VareService
    {
        public List<Vare> RetunererAlleVarerService()
        {
            var VareRepository = new Repository.VareRepository();
            return VareRepository.GetAllVare();
        }
    }
}