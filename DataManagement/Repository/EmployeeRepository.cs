using DataManagement.Database;
using System.Collections.Generic;
using System.Linq;

//Skrevet af Erik og vedligholdt 
namespace DataManagement.Repository
{
    public class EmployeeRepository
    {
        private KFDataClassesDataContext DataContext { get; set; }

        public EmployeeRepository()
        {
            DataContext = new KFDataClassesDataContext();
        }

        public List<Model.Employee> GetAllEmployee()
        {
            List<Model.Employee> result = new List<Model.Employee>();

            var dbEmployees = DataContext.Employees;
            foreach (var dbEmployee in dbEmployees)
            {
                Model.Employee Employee = new Model.Employee();



                Employee.EmployeeID = dbEmployee.Employee_Id;
                Employee.FirstName = dbEmployee.FirstName;
                Employee.LastName = dbEmployee.LastName;
                Employee.PhoneNumber = dbEmployee.Phonenumber;
                Employee.Address = dbEmployee.Address;
                Employee.Salary = dbEmployee.Salary;

                result.Add(Employee);
            }
            return result;
        }

        public Model.Employee GetEmployee(int employeeId)
        {
            Model.Employee result = new Model.Employee();

            var dbEmployee = DataContext.Employees.FirstOrDefault(i => i.Employee_Id == employeeId);

            result.EmployeeID = dbEmployee.Employee_Id;
            result.FirstName = dbEmployee.FirstName;
            result.LastName = dbEmployee.LastName;
            result.PhoneNumber = dbEmployee.Phonenumber;
            result.Address = dbEmployee.Address;
            result.Salary = dbEmployee.Salary;

            return result;
        }

    }
}
