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
        public string ProductName { get; set; }
        public int Price { get; set; }
        public List<Material> AvailableMaterials { get; set; }
        public List<KitchenColor> AvailableColors { get; set; }
        public List<Grip> AvailableGrips { get; set; }
        public Varegruppe Varegruppe { get; set; }
        public string Description { get; set; }
        public string VaregruppeNavn { get { return this.Varegruppe.ProductGroupName; } }
    }
}
