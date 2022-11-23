using DataHandling.Model;
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
        public string To_PhoneNumber { get; set; }
        public string To_Street { get; set; }
        public string To_City { get; set; }
        public string To_ZipCode { get; set; }
        public DateTime DateOfSending { get; set; }

        public List<Vare> OrderProducts { get; set; }
        public Kunde Kunde { get; set; }
    }
}

//Order class model skrevet og vedligeholdt af Dennis Kempf