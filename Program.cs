using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_hospital.Entities;
using e_hospital.Services;

namespace E_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            TableMenu();
            Options();
        }
        public static void TableMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose a table");
            Console.WriteLine("----------------------");
            Console.WriteLine("Tables");
            Console.WriteLine("----------------------");
            Console.WriteLine("1.Doctors");
            Console.WriteLine("2.Addresses");
            Console.WriteLine("3.Patients");
            Console.WriteLine("4.Rooms");
            Console.WriteLine("5.Patients Per Room");
            Console.WriteLine("6.Patients Per Doctor");
            Console.WriteLine("7.Patients Per Addresses");
            Console.WriteLine("8.Addresses Per Patients");
            Console.WriteLine("9.Exit");
            Console.WriteLine("10.Search Button");
            Console.ForegroundColor = ConsoleColor.White;
        }
       
        public static string InputString()
        {
            return Console.ReadLine();
        }
        
        public static void Options()
        {
            string choice = InputString();
            if (choice == "1")
            {
                Printer prtr = new Printer();
                prtr.PrintAllDoctors();
            }
            else if (choice == "2")
            {
                Printer prtr = new Printer();
                prtr.PrintAllAddresses();
            }
            else if (choice == "3")
            {
                Printer prtr = new Printer();
                prtr.PrintAllPatients();
            }
            else if (choice == "4")
            {
                Printer prtr = new Printer();
                prtr.PrintAllRooms();
            }
            else if (choice == "5")
            {
                Printer prtr = new Printer();
                prtr.PrintPatientsPerRoom();
            }
            else if (choice == "6")
            {
                Printer prtr = new Printer();
                prtr.PrintPatientsPerDoctors();
            }
            else if (choice == "7")
            {
                Printer prtr = new Printer();
                prtr.PrintPatientsPerAddresses();
            }
            else if (choice == "8")
            {
                Printer prtr = new Printer();
                prtr.PrintAddressesPerPatients();
            }           
            else if (choice == "9")
            {
                Printer prtr = new Printer();
                prtr.LeaveTheTable();
            }
            else if (choice == "10")
            {
                Printer prtr = new Printer();
                prtr.TableofSeach();
                
            }
        }
      
    }
    public class Printer
    {

        public void PrintAllDoctors()
        {
            DoctorRepository repo = new DoctorRepository();
            var doctors = repo.GetDoctors();
            View.DoctorsView(doctors);
        }
        public void PrintAllAddresses()
        {
            AddressRepository repo = new AddressRepository();
            var addresses = repo.GetAddresses();
            View.AddressView(addresses);
        }
        public void PrintAllPatients()
        {
            PatientRepository repo = new PatientRepository();
            var patients = repo.GetPatients();
            View.PatiendsView(patients);
        }
        public void PrintAllRooms()
        {
            RoomRepository repo = new RoomRepository();
            var rooms = repo.GetRooms();
            View.RoomsView(rooms);
        }
        public void PrintPatientsPerRoom()
        {
            PatientRepository service = new PatientRepository();
            var patients = service.GetPatients();

            foreach (var patient in patients)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(patient.FirstName + patient.LastName);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var rooms in patient.Rooms)
                {
                    Console.WriteLine("\t{0}", rooms.Title);
                }
            }
        }
        public void PrintPatientsPerDoctors()
        {
            PatientRepository service = new PatientRepository();
            var patients = service.GetPatients();

            foreach (var patient in patients)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(patient.FirstName + patient.LastName);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var doctors in patient.Doctors)
                {
                    Console.WriteLine("\t{0}{1}", doctors.FirstName, doctors.LastName);
                }
            }

        }
        public void PrintPatientsPerAddresses()
        {
            PatientRepository service = new PatientRepository();
            var patients = service.GetPatients();
            foreach (var patient in patients)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(patient.FirstName + patient.LastName);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var addresses in patient.Addresses)
                {
                    Console.WriteLine("\t{0}", addresses.Name);
                }
            }

        }
        public void PrintAddressesPerPatients()
        {
            AddressRepository service = new AddressRepository();
            var addresses = service.GetAddresses();
            foreach (var address in addresses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(address.Name);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var patients in address.Patients)
                {
                    Console.WriteLine("\t{0}{1}", patients.FirstName, patients.LastName);
                }
            }

        }
        public void LeaveTheTable()
        {
            Console.WriteLine("GoodBye");
            Environment.Exit(0);
        }
        public void TableofSeach()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Search For Addresses");
            Console.WriteLine("1.Search For Doctors");
            Console.WriteLine("1.Search For Patients");
            Console.WriteLine("1.Search For Rooms");
            Console.ForegroundColor = ConsoleColor.White;

        }


        public class View
        {
            public static void DoctorsView(List<Doctor> doctors)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-20}", "Id", "FirstName", "LastName", "Age", "Salary");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var doctor in doctors)
                {
                    doctor.Output();
                }
            }
            public static void AddressView(List<Address> addresses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-20}", "Id", "Name", "Country", "City", "PostalCode");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var address in addresses)
                {
                    address.Output();
                }
            }
            public static void PatiendsView(List<Patient> patients)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-8}{4,-30}{5,-30}", "Id", "FirstName", "LastName", "Age", "EntryDate", "ExitDate");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var patient in patients)
                {
                    patient.Output();
                }
            }
            public static void RoomsView(List<Room> rooms)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0,-5}{1,-10}", "Id", "Title");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var room in rooms)
                {
                    room.Output();
                }
            }

        }
    }
}
        

    
















