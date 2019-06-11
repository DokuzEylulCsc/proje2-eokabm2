using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class SingleRoom : Room
    {
        public SingleRoom(int no, int price, bool hasAC, bool hasBalcony, bool hasSeaView, bool hasTV, bool hasMinibar) : base(no, 1, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar) { }

        public override string GetTypeToString()
        {
            return "Single Room";
        }
    }
}
