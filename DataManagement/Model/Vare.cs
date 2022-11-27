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
        public string Material { get; set; }
        public string Colour { get; set; }
        public string Grip { get; set; }
        public Varegruppe Varegruppe { get; set; }
    }
}
