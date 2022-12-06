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

            result.Length = dtovare.Length;
            result.Height = dtovare.Height;
            result.Width = dtovare.Width;

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

            newProduct.ProductGroup_Id = vare.ProductGroup_ID;
            newProduct.ProductName = vare.ProductName;
            newProduct.Price = vare.Price;
            newProduct.Product_Description = vare.Description;
            newProduct.Length = vare.Length;
            newProduct.Width = vare.Width;
            newProduct.Height = vare.Height;

            DataContext.Products.InsertOnSubmit(newProduct);
            DataContext.SubmitChanges();

            //Tilføjer valgte gyldige farver til Product_Color tabellen.
            foreach (Model.KitchenColor color in vare.AvailableColors)
            {
                Database.Product_Colour colorReference = new Database.Product_Colour();
                colorReference.Product_Id = newProduct.Product_Id;
                colorReference.Colour_Id = color.Color_Id;
                DataContext.Product_Colours.InsertOnSubmit(colorReference);
                DataContext.SubmitChanges();
            }

            //Tilføjer valgte gyldige materialer til Product_Material tabellen.
            foreach (Model.Material material in vare.AvailableMaterials)
            {
                Database.Product_Material materialReference = new Database.Product_Material();
                materialReference.Product_Id = newProduct.Product_Id;
                materialReference.Material_Id = material.Material_Id;
                DataContext.Product_Materials.InsertOnSubmit(materialReference);
                DataContext.SubmitChanges();
            }

            //Tilføjer valgte gyldige Grips til Product_Grip tabellen.
            foreach (Model.Grip grip in vare.AvailableGrips)
            {
                Database.Product_Grip gripReference = new Database.Product_Grip();
                gripReference.Product_Id = newProduct.Product_Id;
                gripReference.Grip_Id = grip.Grip_Id;
                DataContext.Product_Grips.InsertOnSubmit(gripReference);
                DataContext.SubmitChanges();
            }
        }

        public void EditVare(Model.Vare vare)
        {
            var targetProduct = DataContext.Products.FirstOrDefault(i => i.Product_Id == vare.Product_ID);

            if (targetProduct != null)
            {
                targetProduct.ProductGroup_Id = vare.ProductGroup_ID;
                targetProduct.ProductName = vare.ProductName;
                targetProduct.Price = vare.Price;
                targetProduct.Product_Description = vare.Description;
                targetProduct.Length = vare.Length;
                targetProduct.Width = vare.Width;
                targetProduct.Height = vare.Height;

                DataContext.SubmitChanges();

                //Sletter alle relaterede farve, materiale og greb valg i databasen.
                DataContext.Product_Colours.DeleteAllOnSubmit(targetProduct.Product_Colours);
                DataContext.Product_Materials.DeleteAllOnSubmit(targetProduct.Product_Materials);
                DataContext.Product_Grips.DeleteAllOnSubmit(targetProduct.Product_Grips);
                DataContext.SubmitChanges();

                //opretter nye referencer i junction tabellerne som relaterer til farver, materialer og greb.
                foreach  (Model.KitchenColor color in vare.AvailableColors)
                {
                    Database.Product_Colour colorReference = new Database.Product_Colour();
                    colorReference.Product_Id = targetProduct.Product_Id;
                    colorReference.Colour_Id = color.Color_Id;
                    DataContext.Product_Colours.InsertOnSubmit(colorReference);
                    DataContext.SubmitChanges();
                }

                foreach (Model.Material material in vare.AvailableMaterials)
                {
                    Database.Product_Material materialReference = new Database.Product_Material();
                    materialReference.Product_Id = targetProduct.Product_Id;
                    materialReference.Material_Id = material.Material_Id;
                    DataContext.Product_Materials.InsertOnSubmit(materialReference);
                    DataContext.SubmitChanges();
                }

                foreach (Model.Grip grip in vare.AvailableGrips)
                {
                    Database.Product_Grip gripReference = new Database.Product_Grip();
                    gripReference.Product_Id = targetProduct.Product_Id;
                    gripReference.Grip_Id = grip.Grip_Id;
                    DataContext.Product_Grips.InsertOnSubmit(gripReference);
                    DataContext.SubmitChanges();
                }
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
                    DataContext.Product_Colours.DeleteAllOnSubmit(targetProduct.Product_Colours);
                    DataContext.Product_Materials.DeleteAllOnSubmit(targetProduct.Product_Materials);
                    DataContext.Product_Grips.DeleteAllOnSubmit(targetProduct.Product_Grips);
                    DataContext.SubmitChanges();
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(vare));
            }
        }

        public List<KitchenColor> ListAllColors()
        {
            List<KitchenColor> result = new List<KitchenColor>();

            var allDbColors = DataContext.Colours;
            foreach (var dbColor in allDbColors)
            {
                KitchenColor color = new KitchenColor();
                color.Color_Id = dbColor.Colour_Id;
                color.Color_Name = dbColor.Colour_Name;
                result.Add(color);
            }
            return result;
        }

        public List<Model.Material> ListAllMaterials()
        {
            List<Model.Material> result = new List<Model.Material>();

            var allDbMaterials = DataContext.Materials;
            foreach (var dbMaterial in allDbMaterials)
            {
                Model.Material material = new Model.Material();
                material.Material_Id = dbMaterial.Material_Id;
                material.MaterialName = dbMaterial.Material_Name;
                result.Add(material);
            }
            return result;
        }

        public List<Model.Grip> ListAllGrips()
        {
            List<Model.Grip> result = new List<Model.Grip>();

            var allDbGrips = DataContext.Grips;
            foreach (var dbGrip in allDbGrips)
            {
                Model.Grip grip = new Model.Grip();
                grip.Grip_Id = dbGrip.Grip_Id;
                grip.Grip_Name = dbGrip.Grip_Name;
                result.Add(grip);
            }
            return result;
        }
    }
}