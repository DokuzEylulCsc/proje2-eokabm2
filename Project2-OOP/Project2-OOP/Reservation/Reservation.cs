using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class Reservation
    {
        private int id;
        private string hotelName;
        private int roomNo;
        private DateTime checkIn;
        private DateTime checkOut;
        private static int resId = 0;

        public Reservation(string hotelName, int roomNo, DateTime checkIn, DateTime checkOut)
        {
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.HotelName = hotelName;
            this.RoomNo = roomNo;
            resId++;
            this.id = resId;
        }

        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public string HotelName { get => hotelName; set => hotelName = value; }
        public int RoomNo { get => roomNo; set => roomNo = value; }
    }
}
