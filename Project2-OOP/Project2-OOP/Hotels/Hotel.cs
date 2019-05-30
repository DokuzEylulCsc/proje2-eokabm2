using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    abstract class Hotel : IReservation
    {
        private int numberOfRooms;
        private int totalCapacity;
        private int numberOfStars;
        private List<Room> rooms;

        public Hotel(int numberOfRooms, int totalCapacity, int numberOfStars)
        {
            this.NumberOfRooms = numberOfRooms;
            this.TotalCapacity = totalCapacity;
            this.numberOfStars = numberOfStars;
            this.Rooms = new List<Room> { };
        }

        public int NumberOfRooms { get => numberOfRooms; set => numberOfRooms = value; }
        public int TotalCapacity { get => totalCapacity; set => totalCapacity = value; }
        public int NumberOfStars { get => numberOfStars; set => numberOfStars = value; }
        internal List<Room> Rooms { get => rooms; set => rooms = value; }

        public bool cancel_Reservation()
        {
            return false;
        }
        public void list_Reservations()
        {
            
        }
        public bool make_Reservation()
        {
            return false;
        }
        public bool update_Reservation()
        {
            return false;
        }
    }
}
