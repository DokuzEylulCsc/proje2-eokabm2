using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class DoubleRoom : Room
    {
        public DoubleRoom(int no, int price, bool hasAC, bool hasBalcony, bool hasSeaView, bool hasTV, bool hasMinibar) : base(no, 2, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar) { }

        public override string GetTypeToString()
        {
            return "Double Room";
        }
    }
}
