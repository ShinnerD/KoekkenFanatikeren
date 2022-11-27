﻿using DataManagement.Database;
using System.Collections.Generic;

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
            //Skrevet af Erik og vedligholdt 
        }
    }
}
