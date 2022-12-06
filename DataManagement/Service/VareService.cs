﻿using DataManagement.Model;
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

        public Model.Vare GetOneVare(int Id)
        {
            return new Repository.VareRepository().GetOneVare(Id);
        }

        public void SaveNewVare(Model.Vare vare)
        {
            new Repository.VareRepository().SaveNewVare(vare);
        }

        public void EditVare(Model.Vare vare)
        {
            new Repository.VareRepository().EditVare(vare);
        }

        public void DeleteVare(Model.Vare vare)
        {
            new Repository.VareRepository().DeleteVare(vare);
        }
    }
}