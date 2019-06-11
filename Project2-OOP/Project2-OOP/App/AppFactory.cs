using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    static class AppFactory
    {
        public static Hotel BuildHotel(string name, string city, int numberofstars, string type)
        {
            switch (type)
            {
                case "BoutiqueHotel":
                    return new BoutiqueHotel(name, city, numberofstars);
                case "BusinessHotel":
                    return new BusinessHotel(name, city, numberofstars);
                case "LuxuryHotel":
                    return new LuxuryHotel(name, city, numberofstars);
                case "ResortHotel":
                    return new ResortHotel(name, city, numberofstars);
                case "SuiteHotel":
                    return new SuiteHotel(name, city, numberofstars);
            }

            return null;
        }

        public static Room BuildRoom(int no, int capacity, int price, bool hasAC, bool hasBalcony, bool hasSeaView, bool hasTV, bool hasMinibar, string type)
        {
            switch (type)
            {
                case "SingleRoom":
                    return new SingleRoom(no, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar);
                case "DoubleRoom":
                    return new DoubleRoom(no, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar);
                case "TwinRoom":
                    return new TwinRoom(no, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar);
                case "TripleRoom":
                    return new TripleRoom(no, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar);
                case "KingRoom":
                    return new KingRoom(no, capacity, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar);
            }

            return null;
        }
    }
}
