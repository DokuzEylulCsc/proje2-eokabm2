using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class Reservation
    {
        private DateTime checkIn;
        private DateTime checkOut;

        public Reservation(DateTime checkIn, DateTime checkOut)
        {
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }

    }
}
