using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    abstract internal class Room: IReservation
    {
        private int no;
        private int capacity;
        private int price;
        private bool hasAC;
        private bool hasBalcony;
        private bool hasSeaView;
        private bool hasTV;
        private bool hasMinibar;
        private List<Reservation> reservations;

        internal Room(int no, int capacity, int price, bool hasAC, bool hasBalcony, bool hasSeaView, bool hasTV, bool hasMinibar)
        {
            this.No = no;
            this.Capacity = capacity;
            this.Price = price;
            this.HasAC = hasAC;
            this.HasBalcony = hasBalcony;
            this.HasSeaView = hasSeaView;
            this.HasTV = hasTV;
            this.HasMinibar = hasMinibar;
            this.Reservations = new List<Reservation> { };
        }

        public int No { get => no; set => no = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Price { get => price; set => price = value; }
        public bool HasAC { get => hasAC; set => hasAC = value; }
        public bool HasBalcony { get => hasBalcony; set => hasBalcony = value; }
        public bool HasSeaView { get => hasSeaView; set => hasSeaView = value; }
        public bool HasTV { get => hasTV; set => hasTV = value; }
        public bool HasMinibar { get => hasMinibar; set => hasMinibar = value; }     
        internal List<Reservation> Reservations { get => reservations; set => reservations = value; }

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
