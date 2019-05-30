using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    internal class ElTuristiko
    {
        private ElTuristiko(){}
        private static ElTuristiko elTuristiko = new ElTuristiko();
        public List<Hotel> hotels = new List<Hotel> { }; //private

        internal static ElTuristiko getInstance()
        {
            return elTuristiko;
        }

        internal void AddHotel(Hotel hotel)
        {
            this.hotels.Add(hotel);
        }


    }
}
