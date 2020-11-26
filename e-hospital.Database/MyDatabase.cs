using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_hospital.Entities;

namespace e_hospital.Database
{
    public class MyDatabase
    {
        public List<Doctor> Doctors { get; set; }
        public List<Address> Addresses { get; set; } 
        public List<Patient> Patients { get; set; }
        public List<Room> Rooms { get; set; }
       

        public MyDatabase()
        {
            Doctor d1 = new Doctor(1, "Marios", " Papadopoulos", 33, 800);
            Doctor d2 = new Doctor(2, "Sofia", " Xrisoy", 43, 1100);
            Doctor d3 = new Doctor(3, "Maria", " Konstantinou", 55, 1200);
            Doctor d4 = new Doctor(4, "Xristos", " Afentiou", 34, 800);
            Doctor d5 = new Doctor(5, "Alexis", " Spiropoulos",32, 800);
            Doctor d6 = new Doctor(6, "Hlias", " Xristou", 46, 1100);
            Doctor d7 = new Doctor(7, "Eleni", " Papadopoulou", 41, 1000);
            Doctor d8 = new Doctor(8, "Sidi", " Rrapaj", 32, 1000);
            Doctor d9 = new Doctor(9, "Renia", " Rrapaj", 28, 1000);
            Doctor d10 = new Doctor(10, "Kleio", " Drosou", 20, 800);

            Address a1 = new Address(1, "Ampelokipi", "Greece", "Athens", "11527");
            Address a2 = new Address(2, "Panormou", "Greece", "Athens", "11427");
            Address a3 = new Address(3, "Syntagma", "Greece", "Athens", "11352");
            Address a4 = new Address(4, "Kalithea", "Greece", "Athens", "11247");
            Address a5 = new Address(5, "Porto Rafti", "Greece", "Athens", "10104");
            Address a6 = new Address(6, "Marousi", "Greece", "Athens", "11436");
            Address a7 = new Address(7, "Pagkrati", "Greece", "Athens", "17542");
            Address a8 = new Address(8, "Zografou", "Greece", "Athens", "18173");
            Address a9 = new Address(9, "Omonia", "Greece", "Athens", "18642");
            Address a10 = new Address(10, "Peristeri", "Greece", "Athens", "10982");
            Address a11 = new Address(11, "Kavouri", "Greece", "Athens", "24564");
            Address a12 = new Address(12, "Victoria", "Greece", "Athens", "97642");
            Address a13 = new Address(13, "Glifada", "Greece", "Athens", "56824");
            Address a14 = new Address(14, "Eksarxia", "Greece", "Athens", "56833");
            Address a15 = new Address(15, "Kolonaki", "Greece", "Athens", "32942");

            Patient p1 = new Patient(1, "Georgia", " Kara", 41, new DateTime(2020, 3, 9), new DateTime(2020, 3, 11));
            Patient p2 = new Patient(2, "Zois", " Spirou", 40, new DateTime(2020, 6, 4), new DateTime(2020, 6, 11));
            Patient p3 = new Patient(3, "Aleksandros", " Spirou", 45, new DateTime(2020, 10, 19), new DateTime(2020, 10, 21));
            Patient p4 = new Patient(4, "Vaggelis", " Spirou", 50, new DateTime(2020, 11, 28), new DateTime(2020, 12, 11));
            Patient p5 = new Patient(5, "Dimitra", " Apostolou", 35, new DateTime(2020, 5, 17), new DateTime(2020, 5, 19));
            Patient p6 = new Patient(6, "Anastasia", " Balli", 46, new DateTime(2020, 1, 8), new DateTime(2020, 10, 11));
            Patient p7 = new Patient(7, "Aleksandra", " Oikonomou", 95, new DateTime(2020, 8, 3), new DateTime(2020, 10, 11));
            Patient p8 = new Patient(8, "Marianna", " Galani", 99, new DateTime(2020, 4, 10), new DateTime(2020, 10, 11));
            Patient p9 = new Patient(9, "Ioanna", " Panagopoulos", 57, new DateTime(2020, 4, 29), new DateTime(2020, 5, 11));
            Patient p10 = new Patient(10, "Angela", " Papa", 62, new DateTime(2020, 7, 13), new DateTime(2020, 8, 11));
            Patient p11 = new Patient(11, "Maria", " Alexopoulou", 55, new DateTime(2019, 12, 7), new DateTime(2020, 1, 4));
            Patient p12 = new Patient(12, "Angelos", " Athanasiou", 81, new DateTime(2020, 7, 16), new DateTime(2020, 8, 2));
            Patient p13 = new Patient(13, "Chronis", " Christodoulopoulos", 60, new DateTime(2020, 9, 27), new DateTime(2020, 9, 29));
            Patient p14 = new Patient(14, "Diamadis", " Doukas", 72, new DateTime(2020, 4, 10), new DateTime(2020, 4, 15));
            Patient p15 = new Patient(15, "Dionisis", " Germanos", 99, new DateTime(2020, 10, 29), new DateTime(2020, 11, 2));

            Room r1 = new Room(1, "4.2");
            Room r2 = new Room(2, "5.2");
            Room r3 = new Room(3, "9.2");
            Room r4 = new Room(4, "5.6");
            Room r5 = new Room(5, "7.2");
            Room r6 = new Room(6, "1.4");
            Room r7 = new Room(7, "2.6");
            Room r8 = new Room(8, "4.7");
            Room r9 = new Room(9, "5.7");
            Room r10 = new Room(10, "1.4");
            Room r11 = new Room(11, "2.6");
            Room r12 = new Room(12, "6.3");
            Room r13 = new Room(13, "5.8");
            Room r14 = new Room(14, "1.9");
            Room r15 = new Room(15, "4.5");

            //doctors with patients
            d1.Patients.Add(p4);
            d1.Patients.Add(p2);
            d2.Patients.Add(p7);
            d1.Patients.Add(p8);
            d3.Patients.Add(p13);
            d4.Patients.Add(p6);
            d1.Patients.Add(p9);
            d5.Patients.Add(p10);
            d1.Patients.Add(p14);
            d6.Patients.Add(p12);
            d7.Patients.Add(p11);
            d8.Patients.Add(p3);
            d9.Patients.Add(p5);
            d10.Patients.Add(p1);
            d10.Patients.Add(p15);

            //patients with doctors
            p1.Doctors.Add(d1);
            p2.Doctors.Add(d10);
            p3.Doctors.Add(d8);
            p4.Doctors.Add(d9);
            p5.Doctors.Add(d1);
            p6.Doctors.Add(d4);
            p7.Doctors.Add(d2);
            p8.Doctors.Add(d1);
            p9.Doctors.Add(d1);
            p10.Doctors.Add(d5);
            p11.Doctors.Add(d7);
            p12.Doctors.Add(d6);
            p13.Doctors.Add(d3);
            p14.Doctors.Add(d1);
            p15.Doctors.Add(d1);

            //patients addressees
            p1.Addresses.Add(a8);
            p2.Addresses.Add(a4);
            p3.Addresses.Add(a6);
            p4.Addresses.Add(a13);
            p5.Addresses.Add(a9);
            p6.Addresses.Add(a3);
            p7.Addresses.Add(a5);
            p8.Addresses.Add(a1);
            p9.Addresses.Add(a11);
            p10.Addresses.Add(a12);
            p11.Addresses.Add(a15);
            p12.Addresses.Add(a2);
            p13.Addresses.Add(a7);
            p14.Addresses.Add(a14);
            p15.Addresses.Add(a10);

            //patients address
            a1.Patients.Add(p8);
            a2.Patients.Add(p12);
            a3.Patients.Add(p6);
            a4.Patients.Add(p2);
            a5.Patients.Add(p7);
            a6.Patients.Add(p3);
            a7.Patients.Add(p13);
            a8.Patients.Add(p1);
            a9.Patients.Add(p5);
            a10.Patients.Add(p15);
            a11.Patients.Add(p9);
            a12.Patients.Add(p10);
            a13.Patients.Add(p7);
            a14.Patients.Add(p14);
            a15.Patients.Add(p11);

            //patients room
            p1.Rooms.Add(r6);
            p2.Rooms.Add(r14);
            p3.Rooms.Add(r7);
            p4.Rooms.Add(r9);
            p5.Rooms.Add(r12);
            p6.Rooms.Add(r3);
            p7.Rooms.Add(r8);
            p8.Rooms.Add(r2);
            p9.Rooms.Add(r4);
            p10.Rooms.Add(r11);
            p11.Rooms.Add(r13);
            p12.Rooms.Add(r15);
            p13.Rooms.Add(r5);
            p14.Rooms.Add(r10);
            p15.Rooms.Add(r1);

            //the room of the patient
            r1.Patients.Add(p15);
            r2.Patients.Add(p8);
            r3.Patients.Add(p6);
            r4.Patients.Add(p9);
            r5.Patients.Add(p13);
            r6.Patients.Add(p1);
            r7.Patients.Add(p3);
            r8.Patients.Add(p7);
            r9.Patients.Add(p4);
            r10.Patients.Add(p14);
            r11.Patients.Add(p10);
            r12.Patients.Add(p5);
            r13.Patients.Add(p11);
            r14.Patients.Add(p2);
            r15.Patients.Add(p12);

            Doctors = new List<Doctor>() { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 };
            Addresses = new List<Address>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15 };
            Patients = new List<Patient>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15 };
            Rooms = new List<Room>() { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15 };


        }
    }
}
