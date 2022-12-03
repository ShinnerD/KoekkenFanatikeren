using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Service
{
    /// <summary>
    /// det skal indeholde EmployeeID, FirstName, LastName, Address, PhoneNumber, Salary 
    /// </summary>
    public class EmployeeService
    {
        public List<Employee> GetEmployees()
        {
            return new Repository.EmployeeRepository().GetAllEmployee();
        }
        public void SaveNewEmployee(Model.Employee employee)
        {
            new Repository.EmployeeRepository().SaveNewEmployee(employee);
        }
        public void EditEmployee(Model.Employee employee)
        {
            new Repository.EmployeeRepository().EditEmployee(employee);
        }
        public void DeleteEmployee(Model.Employee employee)
        {
            new Repository.EmployeeRepository().DeleteEmployee(employee);
        }
    }
}
       

     
