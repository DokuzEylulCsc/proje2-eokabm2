using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    interface IReservation
    {
        Reservation Make_Reservation();
        void Cancel_Reservation(Reservation r);
        Reservation Update_Reservation();
    
    }
}
