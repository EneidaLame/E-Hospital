using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_hospital.Database;
using e_hospital.Entities;

namespace e_hospital.Services
{
    public class RoomRepository
    {
        MyDatabase db = new MyDatabase();
        public List<Room> GetRooms()
        {
            return db.Rooms;
        }
    }
}
