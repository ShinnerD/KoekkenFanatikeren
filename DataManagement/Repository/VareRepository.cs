using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Database;
using DataManagement.Model;

namespace DataManagement.Repository
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

        public Model.Vare GetOneVare(int Id)
        {
            var dtovare = DataContext.Products.FirstOrDefault(i => i.Product_Id == Id);

            Vare result = new Vare();
            result.Product_ID = dtovare.Product_Id;
            result.ProductGroup_ID = dtovare.ProductGroup_Id;
            result.Price = dtovare.Price;

            result.ProductName = dtovare.ProductName;
            result.Description = dtovare.Product_Description;

            var dtoProductMaterials = DataContext.Product_Materials.Where(i => i.Product_Id == dtovare.Product_Id);
            result.AvailableMaterials = new List<Model.Material>();
            foreach (var dtoProductMaterial in dtoProductMaterials)
            {
                Model.Material material = new Model.Material();
                material.Material_Id = dtoProductMaterial.Material_Id;
                material.MaterialName = DataContext.Materials.FirstOrDefault(i => i.Material_Id == dtoProductMaterial.Material_Id).Material_Name;
                result.AvailableMaterials.Add(material);
            }

            var dtoProductColours = DataContext.Product_Colours.Where(i => i.Product_Id == dtovare.Product_Id);
            result.AvailableColors = new List<KitchenColor>();
            foreach (var dtoProductColour in dtoProductColours)
            {
                Model.KitchenColor colour = new Model.KitchenColor();
                colour.Color_Id = dtoProductColour.Colour_Id;
                colour.Color_Name = DataContext.Colours.FirstOrDefault(i => i.Colour_Id == dtoProductColour.Colour_Id).Colour_Name;
                result.AvailableColors.Add(colour);
            }

            var dtoProductGrips = DataContext.Product_Grips.Where(i => i.Product_Id == dtovare.Product_Id);
            result.AvailableGrips = new List<Model.Grip>();
            foreach (var dtoProductGrip in dtoProductGrips)
            {
                Model.Grip grip = new Model.Grip();
                grip.Grip_Id = dtoProductGrip.Grip_Id;
                grip.Grip_Name = DataContext.Grips.FirstOrDefault(i => i.Grip_Id == dtoProductGrip.Grip_Id).Grip_Name;
                result.AvailableGrips.Add(grip);
            }

            VareGruppeRepository vareGruppeRepository = new VareGruppeRepository();
            result.Varegruppe = vareGruppeRepository.FindEnVaregruppe(dtovare.ProductGroup_Id);

            return result;
        }

        public void SaveNewVare(Model.Vare vare)
        {
            var newProduct = new Database.Product();
            newProduct.Product_Id = newProduct.Product_Id;


            newProduct.Product_Id = vare.Product_ID;
            newProduct.ProductGroup_Id = vare.ProductGroup_ID;
            newProduct.ProductName = vare.ProductName;
            newProduct.Price = vare.Price;
            newProduct.Product_Description = vare.Description;
            newProduct.Length = vare.Length;
            newProduct.Width = vare.Width;
            newProduct.Height = vare.Height;

            DataContext.Products.InsertOnSubmit(newProduct);
            DataContext.SubmitChanges();          
        }
        
        public void EditVare(Model.Vare vare)
        {
            var targetProduct = DataContext.Products.FirstOrDefault(i => i.Product_Id == vare.Product_ID);

            if (targetProduct != null)
            {
                targetProduct.Product_Id = vare.Product_ID;
                targetProduct.ProductGroup_Id = vare.ProductGroup_ID;
                targetProduct.ProductName = vare.ProductName;
                targetProduct.Price = vare.Price;
                targetProduct.Product_Description = vare.Description;
                targetProduct.Length = vare.Length;
                targetProduct.Width = vare.Width;
                targetProduct.Height = vare.Height;

            }
        }
        
        public void DeleteVare(Model.Vare vare)
        {
            if (vare != null)
            {
                var targetProduct = DataContext.Products.FirstOrDefault(i => i.Product_Id == vare.Product_ID);

                if( targetProduct != null)
                {

                    DataContext.Products.DeleteOnSubmit(targetProduct);
                    DataContext.SubmitChanges();
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(vare));
            }
        }

    }
}