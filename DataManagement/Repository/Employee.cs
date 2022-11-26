using DataManagement.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

               
               
                Employee.EmployeeID = dbEmployee.;
                Employee.FirstName = dbEmployee.;
                Employee.LastName = dbEmployee.;
                Employee.PhoneNumber = dbEmployee.;
                Employee.Address = dbEmployee.;
                Employee.Salary = dbEmployee.;
                

            }
            return result;
        }
    }
}
