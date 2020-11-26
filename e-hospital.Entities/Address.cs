using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_hospital.Entities
{
   public class Address
    {
        public Address(int id, string name, string country, string city, string postalCode)
        {
            Id = id;
            Name = name;
            Country = country;
            City = city;
            PostalCode = postalCode;       
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string  City { get; set; }
        public string PostalCode { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void Output()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-20}", Id, Name, Country, City, PostalCode);
        }
        public void OutputPerRooms()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-20}", Id, Name, Country, City, PostalCode);
        }
    }
}
