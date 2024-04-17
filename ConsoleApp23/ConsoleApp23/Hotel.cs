using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Hotel
    {
        List<Hotel> hotels = new List<Hotel>();
        public string Name { get; set; }
        public int Id { get; set; }
        private int _id;
        private List<Room> Rooms { get; set; } = new List<Room>();
        public Hotel()
        {
            Id = ++_id;
        }

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public List<Hotel> Findhotel(int id)
        {
            return hotels.FindAll(x => x.Id == id);
        }
        public void ShowAllHotel()
        {
            Console.WriteLine($"name{Name} id{Id}");
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("bele otaq yoxdur");
            }

            Rooms.Find(r => r.Id == roomId);
            Room room = Rooms.Find(r => r.Id == roomId);



        }
    }
}
