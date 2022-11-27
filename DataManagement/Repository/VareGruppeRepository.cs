using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Database;
using KundeManagement.Model;

namespace KundeManagement.Repository
{
    public class VareGruppeRepository
    {
        public KFDataClassesDataContext DataContext { get; set; }

        public VareGruppeRepository()
        {
            DataContext = new KFDataClassesDataContext();
        }

        public Varegruppe FindEnVaregruppe(int id)
        {
            var dtoVaregruppe = DataContext.ProductGroups.FirstOrDefault(i => i.ProductGroup_Id == id);

            Varegruppe result = new Varegruppe();
            result.ProductGroup_Id = dtoVaregruppe.ProductGroup_Id;
            result.ProductGroupName = dtoVaregruppe.ProductGroupName;

            return result;
           
        }
         
    }
}