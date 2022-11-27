using DataManagement.Model;
using System.Collections.Generic;

namespace DataManagement.Service
{
    public class VareService
    {
        public List<Vare> RetunererAlleVareService()
        {
            var VareRepository = new Repository.VareRepository();
            return VareRepository.GetAllVare();
        }
    }
}