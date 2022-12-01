using DataManagement.Database;
using DataManagement.Model;
using System;
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

        /// <summary>
        /// Retrieves a full list of all orders from the Database.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Retrieves a list of all orders belonging to the customer with the given ID.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns one complete order matching the Order ID given.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Order GetOrderFromOrderId(int id)
        {
            var result = new Model.Order();
            var dbOrder = DataContext.Orders.FirstOrDefault(i => i.Order_Id.Equals(id));

            result.Id = dbOrder.Order_Id;
            result.EmployeeId = dbOrder.Employee_Id;
            result.CustomerId = dbOrder.Customer_Id;
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
            result.Kunde.Email = dbCustomer.Email;

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

                nyVare.OdreListe_ID = dbOrderProduct.Junction_Id;
                nyVare.Count = dbOrderProduct.Product_Count;

                nyVare.ChosenColor = new KitchenColor();
                nyVare.ChosenColor.Color_Id = dbOrderProduct.Product_Colour;
                nyVare.ChosenColor.Color_Name = DataContext.Colours.FirstOrDefault(i => i.Colour_Id == dbOrderProduct.Product_Colour).Colour_Name;

                nyVare.ChosenGrip = new Model.Grip();
                nyVare.ChosenGrip.Grip_Id = dbOrderProduct.Product_Grip;
                nyVare.ChosenGrip.Grip_Name = DataContext.Grips.FirstOrDefault(i => i.Grip_Id == dbOrderProduct.Product_Grip).Grip_Name;

                nyVare.ChosenMaterial = new Model.Material();
                nyVare.ChosenMaterial.Material_Id = dbOrderProduct.Product_Material;
                nyVare.ChosenMaterial.MaterialName = DataContext.Materials.FirstOrDefault(i => i.Material_Id == dbOrderProduct.Product_Material).Material_Name;

                result.OrderProducts.Add(nyVare);
            }
            return result;
        }

        /// <summary>
        /// Deletes the Given Order from the Orders Table in the database.
        /// Also deletes the rows associated with the order's Id in the Order_Products table.
        /// </summary>
        /// <param name="order"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void DeleteOrder(Model.Order order)
        {
            if (order != null)
            {
                var targetOrder = DataContext.Orders.FirstOrDefault(i => i.Order_Id == order.Id);

                if (targetOrder != null)
                {
                    DataContext.Orders.DeleteOnSubmit(targetOrder);
                    DataContext.Order_Products.DeleteAllOnSubmit(targetOrder.Order_Products);

                    DataContext.SubmitChanges();
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(order));
            }
        }

        public void SaveOrder(Model.Order order)
        {
            if (order != null) //Hvis order ikke er null gem ordren ellers throw argument null exception.
            {
                var targetOrder = DataContext.Orders.FirstOrDefault(i => i.Order_Id == order.Id);
                //Find den order i databasen som skal ændres
                //Hvis den ikke findes bliver targetOrder null.

                if (targetOrder != null) //Hvis targetOrder ikke er null fandtes ordren i forvejen, og vi skal opdaterer dens felter.
                {
                    UpdateOrder(order, targetOrder);
                }
                else //Hvis targetOrder er null fandtes ordren ikke i Databasen i forvejen og skal oprettes fra bunden.
                {
                    var dbOrder = new Database.Order();

                    dbOrder.Customer_Id = order.CustomerId;
                    dbOrder.Employee_Id = order.EmployeeId;
                    dbOrder.To_Firstname = order.To_FirstName;
                    dbOrder.To_Lastname = order.To_LastName;
                    dbOrder.To_Phonenumber = order.To_PhoneNumber;
                    dbOrder.To_Street = order.To_Street;
                    dbOrder.To_City = order.To_City;
                    dbOrder.To_Zipcode = order.To_ZipCode;
                    dbOrder.Order_Comment = order.Order_Comment;
                    dbOrder.DateOfSending = order.DateOfSending;

                    DataContext.Orders.InsertOnSubmit(dbOrder);
                    DataContext.SubmitChanges();

                    foreach (Vare vare in order.OrderProducts)
                    {
                        var nyVare = new Database.Order_Product();
                        nyVare.Order_Id = order.Id; //skal have fat i det nyligt genererede ordre id,
                                                    //regner med det er opdateret her efter Submitchanges.
                        nyVare.Product_Id = vare.Product_ID;
                        nyVare.Product_Colour = vare.ChosenColor.Color_Id;
                        nyVare.Product_Material = vare.ChosenMaterial.Material_Id;
                        nyVare.Product_Grip = vare.ChosenGrip.Grip_Id;
                        nyVare.Product_Count = vare.Count;
                        DataContext.Order_Products.InsertOnSubmit(nyVare);
                        DataContext.SubmitChanges();
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(order));
            }
        }

        /// <summary>
        /// Updater en Order i databasen under antagelse af at den findes i forvejen.
        /// </summary>
        /// <param name="order">Den Model.Order som skal opdateres.</param>
        /// <param name="targetOrder">Den række i databasens Order Tabel som skal opdateres.</param>
        private void UpdateOrder(Model.Order order, Database.Order targetOrder)
        {
            //Databasens kolonner sættes lig den Model.Order vi arbejder med.
            targetOrder.Customer_Id = order.CustomerId;
            targetOrder.Employee_Id = order.EmployeeId;
            targetOrder.To_Firstname = order.To_FirstName;
            targetOrder.To_Lastname = order.To_LastName;
            targetOrder.To_Phonenumber = order.To_PhoneNumber;
            targetOrder.To_Street = order.To_Street;
            targetOrder.To_City = order.To_City;
            targetOrder.To_Zipcode = order.To_ZipCode;
            targetOrder.Order_Comment = order.Order_Comment;
            targetOrder.DateOfSending = order.DateOfSending;

            DataContext.SubmitChanges();

            //Der udtrækkes en liste af de Order_Products som ligger i databasen, men som ikke er i nuværende ordres vareliste.
            //Disse slettes.
            List<int> currentOrderProductIDs = order.OrderProducts.Select(i => i.OdreListe_ID).ToList();
            var deletedOrders = targetOrder.Order_Products.Where(i => currentOrderProductIDs.Contains(i.Junction_Id)).ToList();
            DataContext.Order_Products.DeleteAllOnSubmit(deletedOrders);
            DataContext.SubmitChanges();

            foreach (Model.Vare vare in order.OrderProducts) //Herefter køres et foreach loop for hver Vare som er i ordrens vareliste.
            {
                if (vare.OdreListe_ID == 0) //Hvis OrdreListe_ID er 0 (dvs varen er ny på ordren/findes ikke i databasen endnu),
                {                           //opretter vi en ny vare som databasen kan forstå. Den ser varer på en ordreliste
                                            //som referencer fra Order_Products tabellen.
                    var newVare = new Database.Order_Product();
                    newVare.Order_Id = order.Id;
                    newVare.Product_Id = vare.Product_ID;
                    newVare.Product_Colour = vare.ChosenColor.Color_Id;
                    newVare.Product_Grip = vare.ChosenGrip.Grip_Id;
                    newVare.Product_Material = vare.ChosenMaterial.Material_Id;
                    newVare.Product_Count = vare.Count;
                    DataContext.Order_Products.InsertOnSubmit(newVare);
                    DataContext.SubmitChanges();
                }
                else //Hvis ikke OdreListe_ID er 0 fandtes varen på Order_Products tabellen i forvejen og vi opdaterer dets felter.
                {
                    var targetOrderProduct = targetOrder.Order_Products.FirstOrDefault(i => i.Junction_Id == vare.OdreListe_ID);
                    targetOrderProduct.Product_Id = vare.Product_ID;
                    targetOrderProduct.Product_Grip = vare.ChosenGrip.Grip_Id;
                    targetOrderProduct.Product_Colour = vare.ChosenColor.Color_Id;
                    targetOrderProduct.Product_Material = vare.ChosenMaterial.Material_Id;
                    targetOrderProduct.Product_Count = vare.Count;
                    DataContext.SubmitChanges();
                }
            }
        }
    }
}
