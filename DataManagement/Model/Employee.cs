using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Employee Model
//Skrevet af Erik 
namespace DataManagement.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int Salary { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
