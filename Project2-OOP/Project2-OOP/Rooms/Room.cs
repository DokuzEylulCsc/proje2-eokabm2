using System;
using System.Collections.Generic;

namespace Project2_OOP
{
    abstract internal class Room : IReservation
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
        private static AppDate appDate = AppDate.GetInstance();

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

        internal bool isBookable(DateTime checkIn, DateTime checkOut, bool hasAc, bool hasBalcony, bool hasSeaView, bool hasTv, bool hasMinibar)
        {
            if(Reservations.Count != 0)
            {
                foreach (Reservation r in Reservations)
                {
                    if (checkOut >= r.CheckIn && checkIn <= r.CheckOut)
                    {
                        return false;
                    }
                }
                if (this.HasAC == hasAc && this.HasBalcony == hasBalcony && this.HasSeaView == hasSeaView && this.HasTV == hasTv && this.HasMinibar == hasMinibar)
                {
                    return true;
                }
            }
            
            return true;
        }

        public void Add_Reservation(Reservation r)
        {
            this.reservations.Add(r);
        }

        public Reservation Make_Reservation(string hotelName , int roomNo, DateTime checkIn, DateTime checkOut)
        {
            Reservation reservation = new Reservation(hotelName, roomNo, checkIn, checkOut);
            Reservations.Add(reservation);
            return reservation;
        }
        public void Cancel_Reservation(Reservation r)
        {
            Reservations.Remove(r);
        }

        public Reservation Update_Reservation()
        {
            throw new NotImplementedException();
        }

        public Reservation Make_Reservation()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Type: " + this.GetTypeToString() + " No: " + this.No + " Price: " + this.Price + " Capacity: " + this.Capacity + " " + hasAC + " " + hasBalcony + " " + hasSeaView + " " + hasTV + " " + hasMinibar;

        }

        public abstract string GetTypeToString();

        
    }
}
