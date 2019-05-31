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

        public bool cancel_Reservation()
        {
            return false;
        }
        public void list_Reservations()
        {

        }
        public bool make_Reservation()
        {
            return false;
        }
        public bool update_Reservation()
        {
            return false;
        }

    }
}
