using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class Customer : User, IReservation
    {
        private string name;
        private string address;
        private string phoneNumber;
        private List<Reservation> reservations;

        public Customer(string userId, string password, string name, string address, string phoneNumber) : base(userId, password)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Reservations = new List<Reservation> { };
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        internal List<Reservation> Reservations { get => reservations; set => reservations = value; }

        public void Cancel_Reservation(Reservation r)
        {
            reservations.Remove(r);
        }

        public bool Cancel_Reservation()
        {
            throw new NotImplementedException();
        }

        public void List_Reservations()
        {

        }
        public void Make_Reservation(Reservation r)
        {
            this.reservations.Add(r);
        }

        public Reservation Make_Reservation()
        {
            throw new NotImplementedException();
        }

        public bool Update_Reservation()
        {
            return false;
        }

        internal bool isBookable(DateTime checkIn, DateTime checkOut)
        {
            if (reservations.Count != 0)
            {
                foreach (Reservation r in reservations)
                {
                    if (checkOut >= r.CheckIn && checkIn <= r.CheckOut)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}
