using System;
using System.Collections;
using System.Collections.Generic;

namespace Project2_OOP
{
    internal class ElTuristiko: IEnumerable
    {
        private ElTuristiko() { } 
        private static ElTuristiko elTuristiko = new ElTuristiko();
        private List<Hotel> hotels = new List<Hotel> { };
        private List<User> users = new List<User> { };
        
        internal List<User> Users { get => users; set => users = value; }

        internal static ElTuristiko GetInstance()
        {
            return elTuristiko;
        }

        public List<string> GetCities() //tüm otellerin şehirlerini liste olarak geri döndürüyor.
        {
            List<string> cities = new List<string> { };
            foreach(Hotel h in this.hotels)
            {
                if (!cities.Contains(h.City))
                {
                    cities.Add(h.City);
                }
            }
            return cities;
        }

        //Hotels
        internal void AddHotel(Hotel hotel) 
        {
            this.hotels.Add(hotel);
        }

        internal bool HasSameHotel(string name) //ismi aynı olan otel varsa false döndürür
        {
            foreach(Hotel hotel in this.hotels)
            {
                if (hotel.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;

        }

        internal List<string[]> SearchRooms(string cityName, DateTime checkIn, DateTime checkOut, string roomType, bool hasAc, bool hasBalcony, bool hasSeaView, bool hasTv, bool hasMinibar)
        {
            //Aramaya uygun olan odaları customer forma liste olarak geri gönderiyor.
            List<string[]> searches = new List<string[]> { };

            foreach(Hotel hotel in this.hotels)
            {
                if (hotel.City.Equals(cityName))
                {
                    string[] s = hotel.SearchRooms(hotel.Name, hotel.GetTypeToString(), cityName, hotel.NumberOfStars, checkIn, checkOut, roomType, hasAc, hasBalcony, hasSeaView, hasTv, hasMinibar);
                    if (s != null)
                    {
                        searches.Add(s);
                    }                   
                }
            }

            return searches;
        }


        //Users
        internal void AddUser(User user) 
        {
            this.Users.Add(user);
        }

        internal bool AddCustomer(string userId, string password, string fullName, string address, string phone) // aynı id ye sahip kullanıcı varsa false döndürür
        {
            foreach(User user in Users)
            {
                if (user.UserId.Equals(userId))
                {
                    return false;
                }
            }
            this.Users.Add(new Customer(userId, password, fullName, address, phone));
            return true;
        }

        internal User VerifyLogin(String id, String password) //doğru giriş yapıldıysa o kullanıcıya ait instance döndürür.
        {
            foreach(User user in Users)
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
