using DataManagement.Model;
using System.Collections.Generic;

namespace DataManagement.Service
{//Service for the Employee too make a response too the Repository where it retrieves and return new information
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