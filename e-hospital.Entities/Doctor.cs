using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_hospital.Entities
{
    public class Doctor
    {
        public Doctor(int id, string firstName, string lastName, int age, int salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void Output()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-20}", Id, FirstName, LastName, Age, Salary);
        }

    }
}
