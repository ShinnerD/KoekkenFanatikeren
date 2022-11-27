using System;
using System.Collections.Generic;

namespace DataManagement.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string To_FirstName { get; set; }
        public string To_LastName { get; set; }
        public int To_PhoneNumber { get; set; }
        public string To_Street { get; set; }
        public string To_City { get; set; }
        public int To_ZipCode { get; set; }
        public DateTime DateOfSending { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AnsvarligEmployeeName
        {
            get
            {
                return this.Employee.FirstName + " " + this.Employee.LastName;
            }
        }

        public List<Vare> OrderProducts { get; set; }
        public Kunde Kunde { get; set; }
        public Employee Employee { get; set; }
    }
}

//Order class model skrevet og vedligeholdt af Dennis Kempf