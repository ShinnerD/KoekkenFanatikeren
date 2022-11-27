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

        public Model.Order GetOrderFromId(int id)
        {
            var result = new Model.Order();
            var dbOrder = DataContext.Orders.FirstOrDefault(i => i.Order_Id.Equals(id));

            result.Id = dbOrder.Order_Id;
            result.To_FirstName = dbOrder.To_Firstname;
            result.To_LastName = dbOrder.To_Lastname;
            result.To_PhoneNumber = dbOrder.To_Phonenumber;
            result.To_Street = dbOrder.To_Street;
            result.To_City = dbOrder.To_City;
            result.To_ZipCode = dbOrder.To_Zipcode;
            result.DateOfSending = dbOrder.DateOfSending;

            var dbCustomer = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == dbOrder.Customer_Id);
            result.Kunde = new Kunde();
            result.Kunde.KundeId = dbCustomer.Customer_Id;
            //osv... når modellen er færdig.

            var dbEmployee = DataContext.Employees.FirstOrDefault(i => i.Employee_Id == dbOrder.Employee_Id);
            //indfør Employee Kode når modellen er færdig og Employee class er indført i Model.Order

            var dbOrderProducts = DataContext.Order_Products.Where(i => i.Order_Id == dbOrder.Order_Id).ToList();
            result.OrderProducts = new List<Vare>();
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

                result.OrderProducts.Add(product);
            }

            return result;
        }
    }
}
