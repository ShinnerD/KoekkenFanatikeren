using DataManagement.Database;
using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

//Customer Repository made by Erik

//Skrevet og vedligeholdt af Erik

namespace DataManagement.Repository
{
    public class KundeRepository
    {
        private KFDataClassesDataContext DataContext { get; set; }

        public KundeRepository()
        {
            DataContext = new KFDataClassesDataContext();
        }

        //Retrieve a list of customer from the Database

        public List<Kunde> GetAllKunder()
        {
            List<Kunde> result = new List<Kunde>();

            var dbKundes = DataContext.Customers;
            foreach (var dbKunde in dbKundes)
            {
                Kunde kunde = new Kunde();

                kunde.KundeID = dbKunde.Customer_Id;
                kunde.FirstName = dbKunde.FirstName;
                kunde.LastName = dbKunde.LastName;
                kunde.Street = dbKunde.Streetname;
                kunde.City = dbKunde.City;
                kunde.Zipcode = dbKunde.Zipcode;
                kunde.PhoneNumber = dbKunde.Phonenumber;
                kunde.Email = dbKunde.Email;

                result.Add(kunde);
            }
            return result;
        }

        //Getting a Customer from Database
        public Kunde GetKunde(int kundeId)
        {
            Kunde kunde = new Kunde();

            var dbKunde = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == kundeId);

            kunde.KundeID = dbKunde.Customer_Id;
            kunde.FirstName = dbKunde.FirstName;
            kunde.LastName = dbKunde.LastName;
            kunde.Street = dbKunde.Streetname;
            kunde.City = dbKunde.City;
            kunde.Zipcode = dbKunde.Zipcode;
            kunde.PhoneNumber = dbKunde.Phonenumber;
            kunde.Email = dbKunde.Email;

            return kunde;
        }

        //Saving customer / making a new customer

        public void SaveNewKunde(Kunde kunde)
        {
            Database.Customer newCustomer = new Database.Customer();

            newCustomer.FirstName = kunde.FirstName;
            newCustomer.LastName = kunde.LastName;
            newCustomer.Streetname = kunde.Street;
            newCustomer.City = kunde.City;
            newCustomer.Zipcode = kunde.Zipcode;
            newCustomer.Phonenumber = kunde.PhoneNumber;
            newCustomer.Email = kunde.Email;

            DataContext.Customers.InsertOnSubmit(newCustomer);
            DataContext.SubmitChanges();
        }

        //Making a edit funktion that can edit fx Phonenumber or City

        public void EditKunde(Kunde kunde)
        {
            var targetKunde = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == kunde.KundeID);

            if (targetKunde != null)
            {
                targetKunde.FirstName = kunde.FirstName;
                targetKunde.LastName = kunde.LastName;
                targetKunde.Phonenumber = kunde.PhoneNumber;
                targetKunde.Streetname = kunde.Street;
                targetKunde.City = kunde.City;
                targetKunde.Zipcode = kunde.Zipcode;
                targetKunde.Email = kunde.Email;

                DataContext.SubmitChanges();
            }
        }

        // a delete funktion in the Database

        public void DeleteKunde(Kunde kunde)
        {
            if (kunde != null)
            {
                var targetKunde = DataContext.Customers.FirstOrDefault(i => i.Customer_Id == kunde.KundeID);

                if (targetKunde != null)
                {
                    DataContext.Customers.DeleteOnSubmit(targetKunde);
                    DataContext.SubmitChanges();
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(kunde));
            }
        }
    }
}