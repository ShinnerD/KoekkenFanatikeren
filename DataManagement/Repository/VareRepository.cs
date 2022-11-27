using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Database;
using KundeManagement.Model;

namespace KundeManagement.Repository
{
  

    public class VareRepository
    {
        public KFDataClassesDataContext DataContext { get; set; }

        public VareRepository()
        {
            DataContext = new KFDataClassesDataContext();
        }

        public List<Vare> GetAllVare()
        {
            List<Vare> result = new List<Vare>();

            var VareIdListe = DataContext.Products;

            foreach (var vare in VareIdListe)
            {
                result.Add(GetOneVare(vare.Product_Id));
            }
            return result;
        }

        public Vare GetOneVare(int Id)
        {
            var dtovare = DataContext.Products.FirstOrDefault(i => i.Product_Id == Id);

            Vare result = new Vare();
            result.Product_ID = dtovare.Product_Id;
            result.ProductGroup_ID = dtovare.ProductGroup_Id;
            result.ProductName = dtovare.ProductName;
            result.Price = dtovare.Price;
            result.Material = dtovare.Material;
            result.Colour = dtovare.Colour;
            result.Grip = dtovare.Grip;

            VareGruppeRepository vareGruppeRepository = new VareGruppeRepository();
            result.Varegruppe = vareGruppeRepository.FindEnVaregruppe(dtovare.ProductGroup_Id);

            return result;
        }
       
    }
}