using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    abstract internal class Hotel : IReservation, IEnumerable
    {
        private int id;
        private string name;
        private string city;
        private int numberOfRooms;
        private int numberOfStars;
        private int totalCapacity;
        private List<Room> rooms;
        private static int hotelId = 0;

        public List<Room> Rooms { get => rooms; }

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

        internal bool AddRoom(int no, int capacity, int price, bool hasAc, bool hasBalcony, bool hasSeaView, bool hasTv, bool hasMinibar, int t)
        {
            foreach(Room r in rooms)
            {
                if(r.No == no)
                {
                    return false;
                }
            }

            switch (t)
            {
                case 1:
                    AddRoom(new SingleRoom(no, price, hasAc, hasBalcony, hasSeaView, hasTv, hasMinibar));
                    break;
                case 2:
                    AddRoom(new DoubleRoom(no, price, hasAc, hasBalcony, hasSeaView, hasTv, hasMinibar));
                    break;
                case 3:
                    AddRoom(new TwinRoom(no, price, hasAc, hasBalcony, hasSeaView, hasTv, hasMinibar));
                    break;
                case 4:
                    AddRoom(new TripleRoom(no, price, hasAc, hasBalcony, hasSeaView, hasTv, hasMinibar));
                    break;
                case 5:
                    AddRoom(new KingRoom(no, capacity, price, hasAc, hasBalcony, hasSeaView, hasTv, hasMinibar));
                    break;
            }

            return true;
                
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

        //IEnumarable  
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public RoomEnum GetEnumerator()
        {
            return new RoomEnum(rooms);
        }

        public class RoomEnum : IEnumerator
        {
            List<Room> rooms;

            int position = -1;

            public RoomEnum(List<Room> list)
            {
                rooms = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < rooms.Count);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public Room Current
            {
                get
                {
                    try
                    {
                        return rooms[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}  -->  City: {1}  -->  Stars: {2}", name, city, numberOfStars);
        }
    }
}
