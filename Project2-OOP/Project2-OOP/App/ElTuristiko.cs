using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    internal class ElTuristiko
    {
        private ElTuristiko() { }
        private static ElTuristiko elTuristiko = new ElTuristiko();
        private List<Hotel> hotels = new List<Hotel> { };
        private List<User> users = new List<User> { };

        internal static ElTuristiko getInstance()
        {
            return elTuristiko;
        }

        internal bool AddHotel(Hotel hotel) //ismi ve şehri aynı olan otel varsa false döndürür
        {
            this.hotels.Add(hotel);
            return true;
        }

        internal void AddUser(User user) 
        {
            this.users.Add(user);
        }

        internal bool AddCustomer(string userId, string password, string fullName, string address, string phone) // aynı id ye sahip kullanıcı varsa false döndürür
        {
            foreach(User user in users)
            {
                if (user.UserId.Equals(userId))
                {
                    return false;
                }
            }
            this.users.Add(new Customer(userId, password, fullName, address, phone));
            return true;
        }

        internal User VerifyLogin(String id, String password) //doğru giriş yapıldıysa o kullanıcıya ait instance döndürür.
        {
            foreach(User user in users)
            {
                if(user.UserId.Equals(id) && user.Password.Equals(password))
                {
                    return user;
                }
            }
            return null;
        }

  
    }
}
