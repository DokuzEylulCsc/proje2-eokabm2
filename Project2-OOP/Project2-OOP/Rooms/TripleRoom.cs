using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class TripleRoom : Room
    {
        public TripleRoom(int no, int price, bool hasAC, bool hasBalcony, bool hasSeaView, bool hasTV, bool hasMinibar) : base(no, 3, price, hasAC, hasBalcony, hasSeaView, hasTV, hasMinibar) { }

        public override string GetTypeToString()
        {
            return "Triple Room";
        }
    }
}
