using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Model
{
    public class Vare
    {
        public int Product_ID { get; set; }
        public int ProductGroup_ID { get; set; }
        public int OdreListe_ID { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public string VaregruppeNavn { get { return this.Varegruppe.ProductGroupName; } }

        public List<Material> AvailableMaterials { get; set; }
        public List<KitchenColor> AvailableColors { get; set; }
        public List<Grip> AvailableGrips { get; set; }
        public Varegruppe Varegruppe { get; set; }

        public Material ChosenMaterial { get; set; }
        public string ChosenMaterialString { get { return ChosenMaterial.MaterialName; } }

        public KitchenColor ChosenColor { get; set; }
        public string ChosenColorString { get { return ChosenColor.Color_Name; } }

        public Grip ChosenGrip { get; set; }
        public string ChosenGripString { get { return ChosenGrip.Grip_Name; } }

    }
}
