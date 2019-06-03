using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    internal class ElTuristiko: IEnumerable
    {
        private ElTuristiko() { } 
        private static ElTuristiko elTuristiko = new ElTuristiko();
        private List<Hotel> hotels = new List<Hotel> { };
        private List<User> users = new List<User> { };

        internal static ElTuristiko getInstance()
        {
            return elTuristiko;
        }


        //Hotels
        internal void AddHotel(Hotel hotel) 
        {
            this.hotels.Add(hotel);
        }

        internal bool AddHotel(string name, string city, int stars, int t) //ismi aynı olan otel varsa false döndürür
        {
            foreach(Hotel hotel in hotels)
            {
                if (hotel.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) //büyük küçük harfleri görmezden gelir
                {
                    return false;
                }
            }

            switch (t)
            {
                case 0:
                    hotels.Add(new BoutiqueHotel(name, city, stars));
                    break;
                case 1:
                    hotels.Add(new BusinessHotel(name, city, stars));
                    break;
                case 2:
                    hotels.Add(new LuxuryHotel(name, city, stars));
                    break;
                case 3:
                    hotels.Add(new ResortHotel(name, city, stars));
                    break;
                case 4:
                    hotels.Add(new SuiteHotel(name, city, stars));
                    break;
            }

            return true;
        }


        //Users
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

        //IEnumarable  https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.ienumerable?view=netframework-4.8
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public HotelEnum GetEnumerator()
        {
            return new HotelEnum(hotels);
        }

        public class HotelEnum : IEnumerator
        {
            List<Hotel> hotels;

            int position = -1;

            public HotelEnum(List<Hotel> list)
            {
                hotels = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < hotels.Count);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public Hotel Current
            {
                get
                {
                    try
                    {
                        return hotels[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }


    }
}
