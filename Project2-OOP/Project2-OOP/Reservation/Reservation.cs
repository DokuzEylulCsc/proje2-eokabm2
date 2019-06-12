using System;

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
            this.Id = resId;
        }

        public Reservation(int id, string hotelName, int roomNo, DateTime checkIn, DateTime checkOut)
        {
            this.Id = id;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.HotelName = hotelName;
            this.RoomNo = roomNo;
            resId = id;
        }

        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public string HotelName { get => hotelName; set => hotelName = value; }
        public int RoomNo { get => roomNo; set => roomNo = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return hotelName + "\t" + roomNo + "\t" + checkIn.ToShortDateString() + "\t" + checkOut.ToShortDateString(); 
        }

    }
}
