using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_hospital.Entities
{
    public class Room
    {
        public Room(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void Output()
        {
            Console.WriteLine("{0,-5}{1,-5}", Id, Title);
        }

    }
}
