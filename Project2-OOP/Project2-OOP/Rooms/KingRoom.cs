using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class KingRoom : Room
    {
        public KingRoom(int no, int capacity, int price, bool hasAC, bool hasBalcony, bool hasSeaView, bool hasTV, bool hasMinibar) : base(no, capacity, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar) { }

        public override string GetTypeToString()
        {
            return "King Room";
        }
    }
}
