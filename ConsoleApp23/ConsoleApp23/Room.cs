using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Room
    {

        private static int _id = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable = true;

        public Room(string name, int price, int capacity)
        {
            Id = ++_id;
            Name = name;
            Price = price;
            Capacity = capacity;
        }

        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, PersonCapacity: {Capacity}, IsAvailable: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }


    }
}
