using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    interface IReservation
    {
        bool make_Reservation();
        bool cancel_Reservation();
        void list_Reservations();
        bool update_Reservation();

    }
}
