using DataManagement.Database;
using DataManagement.Model;
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
                result.Add(GetOrderFromOrderId(dbOrder.Order_Id));
            }
            return result;
        }

        public List<Model.Order> GetOrdersFromCustomer(int customerId)
        {
            List<Model.Order> result = new List<Model.Order>();

            var dbOrders = DataContext.Orders.Where(i => i.Customer_Id == customerId).ToList();
            foreach (var dbOrder in dbOrders)
            {
                result.Add(GetOrderFromOrderId(dbOrder.Order_Id));
            }
            return result;
        }

        public Model.Order GetOrderFromOrderId(int id)
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
            result.Order_Comment = dbOrder.Order_Comment;

            var dbCustomer = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == dbOrder.Customer_Id);
            result.Kunde = new Kunde();
            result.Kunde.KundeID = dbCustomer.Customer_Id;
            result.Kunde.FirstName = dbCustomer.FirstName;
            result.Kunde.LastName = dbCustomer.LastName;
            result.Kunde.Street = dbCustomer.Streetname;
            result.Kunde.City = dbCustomer.City;
            result.Kunde.Zipcode = dbCustomer.Zipcode;
            result.Kunde.PhoneNumber = dbCustomer.Phonenumber;

            var dbEmployee = DataContext.Employees.FirstOrDefault(i => i.Employee_Id == dbOrder.Employee_Id);
            result.Employee = new Model.Employee();
            result.Employee.EmployeeID = dbEmployee.Employee_Id;
            result.Employee.FirstName = dbEmployee.FirstName;
            result.Employee.LastName = dbEmployee.LastName;
            result.Employee.PhoneNumber = dbEmployee.Phonenumber;
            result.Employee.Address = dbEmployee.Address;
            result.Employee.Salary = dbEmployee.Salary;

            var dbOrderProducts = DataContext.Order_Products.Where(i => i.Order_Id == dbOrder.Order_Id).ToList();
            result.OrderProducts = new List<Vare>();
            VareRepository vareRepository = new VareRepository();
            foreach (var dbOrderProduct in dbOrderProducts)
            {
                Model.Vare nyVare = vareRepository.GetOneVare(dbOrderProduct.Product_Id);
                
                nyVare.ChosenColor = new KitchenColor();
                nyVare.ChosenColor.Color_Id = dbOrderProduct.Product_Colour;
                nyVare.ChosenColor.Color_Name = DataContext.Colours.FirstOrDefault(i => i.Colour_Id == dbOrderProduct.Product_Colour).Colour_Name;

                nyVare.ChosenGrip = new Model.Grip();
                nyVare.ChosenGrip.Grip_Id = dbOrderProduct.Product_Grip;
                nyVare.ChosenGrip.Grip_Name = DataContext.Grips.FirstOrDefault(i => i.Grip_Id == dbOrderProduct.Product_Grip).Grip_Name;

                nyVare.ChosenMaterial = new Model.Material();
                nyVare.ChosenMaterial.Material_Id= dbOrderProduct.Product_Material;
                nyVare.ChosenMaterial.MaterialName = DataContext.Materials.FirstOrDefault(i => i.Material_Id == dbOrderProduct.Product_Material).Material_Name;

                result.OrderProducts.Add(nyVare);
            }
            return result;
        }
    }
}
