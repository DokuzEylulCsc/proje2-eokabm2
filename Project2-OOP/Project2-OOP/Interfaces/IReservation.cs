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
        bool Cancel_Reservation();
        void List_Reservations();
        bool Update_Reservation();
    
    }
}
