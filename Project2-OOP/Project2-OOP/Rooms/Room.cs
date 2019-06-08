﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.reservations = new List<Reservation> { };
        }

        public int No { get => no; set => no = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Price { get => price; set => price = value; }
        public bool HasAC { get => hasAC; set => hasAC = value; }
        public bool HasBalcony { get => hasBalcony; set => hasBalcony = value; }
        public bool HasSeaView { get => hasSeaView; set => hasSeaView = value; }
        public bool HasTV { get => hasTV; set => hasTV = value; }
        public bool HasMinibar { get => hasMinibar; set => hasMinibar = value; }

        internal bool isBookable(DateTime checkIn, DateTime checkOut, bool hasAc, bool hasBalcony, bool hasSeaView, bool hasTv, bool hasMinibar)
        {
            if(reservations.Count != 0)
            {
                foreach (Reservation r in reservations)
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

        public Reservation Make_Reservation(string hotelName , int roomNo, DateTime checkIn, DateTime checkOut)
        {
            Reservation reservation = new Reservation(hotelName, roomNo, checkIn, checkOut);
            reservations.Add(reservation);
            return reservation;
        }
        public void Cancel_Reservation(Reservation r)
        {
            reservations.Remove(r);
        }
        public void List_Reservations()
        {

        }

        public bool Update_Reservation()
        {
            return false;
        }

        public override string ToString()
        {
            return "No: " + this.No + " Price: " + this.Price;

        }

        public abstract string GetTypeToString();

        public Reservation Make_Reservation()
        {
            throw new NotImplementedException();
        }

        public bool Cancel_Reservation()
        {
            throw new NotImplementedException();
        }
    }
}
