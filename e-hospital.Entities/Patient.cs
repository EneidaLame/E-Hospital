using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_hospital.Entities
{
    public class Patient
    {
        public Patient(int id, string firstName, string lastName, int age, DateTime entryDate, DateTime exitDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            EntryDate = entryDate;
            ExitDate = exitDate;
           
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public void Output()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-30}{5,-30}", Id, FirstName, LastName, Age, EntryDate, ExitDate);
        }
        public void OutputPerRoom()
        {
            Console.WriteLine("{0,-20}{1,-20}", FirstName, LastName );
        }
        public void OutputPerDoctor()
        {
            Console.WriteLine("{0,-20}{1,-20}", FirstName, LastName);
        }
        



    }
}
