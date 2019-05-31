using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    abstract internal class Hotel : IReservation
    {
        private int id;
        private string name;
        private string city;
        private int numberOfRooms;
        private int numberOfStars;
        private int totalCapacity;
        private List<Room> rooms;
        private static int hotelId = 0;

        internal Hotel(string name, string city, int numberOfStars)
        {
            this.Name = name;
            this.City = city;
            this.NumberOfStars = numberOfStars;
            this.NumberOfRooms = 0;
            this.totalCapacity = 0;
            hotelId++;
            this.Id = hotelId;
            this.rooms = new List<Room> { };
        }

        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public int NumberOfStars { get => numberOfStars; set => numberOfStars = value; }
        public int NumberOfRooms { get => numberOfRooms; set => numberOfRooms = value; }
        public int Id { get => id; set => id = value; }

        internal void AddRoom(Room room)
        {
            rooms.Add(room);
            this.numberOfRooms++;
            this.totalCapacity += room.Capacity;
        }

        public bool make_Reservation()
        {
            throw new NotImplementedException();
        }

        public bool cancel_Reservation()
        {
            throw new NotImplementedException();
        }

        public void list_Reservations()
        {
            throw new NotImplementedException();
        }

        public bool update_Reservation()
        {
            throw new NotImplementedException();
        }
    }
}
