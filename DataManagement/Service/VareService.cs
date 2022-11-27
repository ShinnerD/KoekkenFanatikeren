using DataManagement.Model;
using System.Collections.Generic;

namespace DataManagement.Service
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