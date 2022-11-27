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
    }

}
