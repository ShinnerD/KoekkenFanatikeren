using DataHandling.Model;
using DataManagement.Database;
using System.Collections.Generic;
using System.Linq;

//OrderRepository skrevet og vedligeholdt af Dennis Kempf
namespace DataManagement.Repository
{
    public class OrderRepository
    {
        private KFDataClassesDataContext DataContext { get; set; }

        public OrderRepository()
        {
            DataContext = new KFDataClassesDataContext();
        }

        public List<Model.Order> GetAllOrders() 
        {
            List<Model.Order> result = new List<Model.Order>();

            var dbOrders = DataContext.Orders;
            foreach (var dbOrder in dbOrders)
            {
                Model.Order order = new Model.Order();

                order.Id = dbOrder.Order_Id;
                order.CustomerId = dbOrder.Customer_Id; //These are temporary and should be removed from the Model.
                order.EmployeeId = dbOrder.Employee_Id; //These are temporary and should be removed from the Model.
                order.To_FirstName = dbOrder.To_Firstname;
                order.To_PhoneNumber = dbOrder.To_Phonenumber;
                order.To_Street = dbOrder.To_Street;
                order.To_City = dbOrder.To_City;
                order.To_ZipCode = dbOrder.To_Zipcode;
                order.DateOfSending = dbOrder.DateOfSending;

                var dbCustomer = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == order.CustomerId);
                //INDFØR KODE TIL AT SÆTTE order.Kunde's parametre = dbCustomer's
                //NÅR Model.Kunde er færdig.

                var dbEmployee = DataContext.Employees.FirstOrDefault(i => i.Employee_Id == dbOrder.Employee_Id);
                //INDFØR KODE TIL AT SÆTTE order.Employee parametre = dbEmployee
                //NÅR Model.Employee er færdig.

                order.OrderProducts = new List<Vare>();
                var dbOrderProducts = DataContext.Order_Products.Where(i => i.Order_Id == order.Id).ToList();
                foreach (var dbOrderProduct in dbOrderProducts)
                {
                    Vare product = new Vare();
                    //product.Id = dbOrderProduct.Product_Id;
                    //product.ProductCount = dbOrderProduct.Product_Count;

                    //var dbProduct = DataContext.Products.FirstOrDefault(i => i.Product_Id == product.Id);
                    //product.Name = dbProduct.Name;
                    //product.Price = dbProduct.Price;
                    //product.Material = dbProduct.Material;
                    //product.Colour = dbProduct.Colour;
                    //product.Grip = dbProduct.Grip;

                    //INDFØR KODE TIL AT SÆTTE product.VareGruppe parametre = den korrekte datacontext.VareGruppe
                    //NÅR Model.VareGruppe er færdig.

                    order.OrderProducts.Add(product);
                }

                result.Add(order);
            }
            return result;
        }
    }
}
