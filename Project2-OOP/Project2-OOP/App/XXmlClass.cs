﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project2_OOP
{
    internal class XXmlClass
    {
        private ElTuristiko elTuristiko = ElTuristiko.GetInstance();

        internal void xWriteUser(List<User> users)
        {
            XDocument xDoc = XDocument.Load(@"Users.xml");
            XElement rootElement = xDoc.Root;
            rootElement.RemoveAll();
            foreach(User user in users)
            {
                XElement User = new XElement("User");
                XAttribute idUser = new XAttribute("userid", user.UserId);
                XAttribute type = new XAttribute("usertype", user.GetType().Name.ToString());
                XAttribute password = new XAttribute("password", user.Password);
                if (user is Customer Customer)
                {

                    XElement name = new XElement("name", Customer.Name);
                    XElement adress = new XElement("adress", Customer.Address);
                    XElement phoneNumber = new XElement("PhoneNumber", Customer.PhoneNumber);
                    XElement Reservations = new XElement("Reservations");
                    
                    foreach (Reservation reservation in Customer.Reservations)
                    {
                        XElement Reservation = new XElement("Reservation");
                        XAttribute id = new XAttribute("id", reservation.Id.ToString());
                        XElement hotelname = new XElement("Hotelname", reservation.HotelName);
                        XElement roomno = new XElement("Roomno", reservation.RoomNo.ToString());
                        XElement checkin = new XElement("Checkin", reservation.CheckIn.ToShortDateString());
                        XElement checkout = new XElement("Checkout", reservation.CheckOut.ToShortDateString());
                        Reservation.Add(id, hotelname, roomno, checkin, checkout);
                        Reservations.Add(reservation);
                    }
                    User.Add(name, adress, phoneNumber,Reservations);
                }
                User.Add(idUser, type);
                rootElement.Add(User);
                //rootElement.Add(User);
            }
            //rootElement.Add(Use);
            xDoc.Save(@"Users.xml");
        }
        internal void xWriteHotel()
        {
            XDocument xDoc = XDocument.Load(@"Hotels.xml");
            XElement rootElement = xDoc.Root;
            rootElement.RemoveAll();
            XElement newElement = new XElement("Hotel");

            IEnumerator enumeratorH = elTuristiko.GetEnumerator();

            while (enumeratorH.MoveNext())
            {
                Hotel hotel = (Hotel)enumeratorH.Current;

                XElement Hotel = new XElement("Hotel");
                XAttribute idHotel = new XAttribute("id", hotel.Id.ToString());
                XAttribute typeHotel = new XAttribute("type", hotel.GetType().Name);
                XElement nameHotel = new XElement("name", hotel.Name);
                XElement city = new XElement("city", hotel.City);
                XElement numberofStars = new XElement("Stars", hotel.NumberOfStars.ToString());
                XElement RoomRoot = new XElement("Rooms");

                IEnumerator enumeratorR = hotel.GetEnumerator();

                while (enumeratorR.MoveNext())
                {
                    Room room = (Room)enumeratorR.Current;

                    XElement Room = new XElement("Room");
                    XAttribute idRoom = new XAttribute("No", room.No);
                    XAttribute typeroom = new XAttribute("Type", room.GetType().Name);
                    XElement capacity = new XElement("Capacity", room.Capacity.ToString());
                    XElement Price = new XElement("Price", room.Price.ToString());
                    XElement hasAC = new XElement("hasAC", room.HasAC.ToString());
                    XElement hasBalcony = new XElement("hasBalcony", room.HasBalcony.ToString());
                    XElement hasSea = new XElement("hasSeaView", room.HasSeaView.ToString());
                    XElement hasTV = new XElement("hasTV", room.HasTV.ToString());
                    XElement hasMinibar = new XElement("hasMinibar", room.HasMinibar.ToString());
                    XElement Reservations = new XElement("Reservations");

                    foreach (Reservation reservation in room.Reservations)
                    {
                        XElement Reservation = new XElement("Reservation");
                        XAttribute id = new XAttribute("id", reservation.Id.ToString());
                        XElement hotelname = new XElement("Hotelname", reservation.HotelName);
                        XElement roomno = new XElement("Roomno", reservation.RoomNo.ToString());
                        XElement checkin = new XElement("Checkin", reservation.CheckIn.ToShortDateString());
                        XElement checkout = new XElement("Checkout", reservation.CheckOut.ToShortDateString());
                        Reservation.Add(id, hotelname, roomno, checkin, checkout);
                        Reservations.Add(reservation);
                    }
                    Room.Add(idRoom,typeroom, capacity, Price, hasAC, hasBalcony, hasSea, hasTV, hasMinibar , Reservations);
                    RoomRoot.Add(Room);
                }
                Hotel.Add(idHotel, typeHotel, nameHotel, city, numberofStars,RoomRoot);
                rootElement.Add(Hotel);
            }
            
                             
            xDoc.Save(@"Hotels.xml");
        }
        
        internal void xReadHotel()
        {
            XDocument xDoc = null;
            try
            {
                xDoc = XDocument.Load(@"Hotels.xml");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
             

            XElement Root = xDoc.Root;

            String id,typename,hotelname,city,stars;
            String roomn , type , capacity, price, hasAC, hasBalcony, hasSea, hasTV, hasMinibar;
            foreach (XElement elHotel in Root.Elements())
            {
                id = elHotel.Attribute("id").Value;
                typename = elHotel.Attribute("type").Value;
                hotelname = elHotel.Element("name").Value;
                city = elHotel.Element("city").Value;
                stars = elHotel.Element("Stars").Value;

                //Console.WriteLine("id: " + id + " Hotelname: " + hotelname + " Typename: " + typename + " City: " + city + " Stars: " + stars);

                Hotel hotel = AppFactory.BuildHotel(hotelname, city, Int32.Parse(stars), typename);
                elTuristiko.AddHotel(hotel);
                //
                Console.WriteLine(hotel.ToString());
                //

                foreach(XElement elRooms in elHotel.Descendants("Rooms"))
                {
                    foreach(XElement ell in elRooms.Descendants("Room"))
                    {

                        roomn = ell.Attribute("No").Value;
                        type = ell.Attribute("Type").Value;
                        capacity = ell.Element("Capacity").Value;
                        price = ell.Element("Price").Value;
                        hasAC = ell.Element("hasAC").Value;
                        hasBalcony = ell.Element("hasBalcony").Value;
                        hasSea = ell.Element("hasSeaView").Value;
                        hasTV = ell.Element("hasTV").Value;
                        hasMinibar = ell.Element("hasMinibar").Value;


                        Room room = null;
                        room = AppFactory.BuildRoom(Int32.Parse(roomn), Int32.Parse(capacity), Int32.Parse(price), Boolean.Parse(hasAC), Boolean.Parse(hasBalcony), 
                            Boolean.Parse(hasSea), Boolean.Parse(hasTV), Boolean.Parse(hasMinibar), type);
                        hotel.AddRoom(room);
                        //
                        Console.WriteLine(room.ToString());
                        //

                    }

                }
                
            }

        }

        internal void xReadUsers(List<User> users)
        {
            XDocument xDoc = null;
            try
            {
                xDoc = XDocument.Load(@"Users.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            XElement Root = xDoc.Root;

            String id, typename, password, username, adress, phone;
            String resid, reshotel, resroom, rescheckin, rescheckout;

            foreach (XElement elUser in Root.Elements())
            {
                id = elUser.Attribute("userid").Value;
                typename = elUser.Attribute("usertype").Value;
                password = elUser.Attribute("password").Value;
                if (typename == "Administrator")
                {

                }
                else if (typename == "Customer")
                {
                    username = elUser.Element("name").Value;
                    adress = elUser.Element("adress").Value;
                    phone = elUser.Element("PhoneNumber").Value;
                }

                foreach (XElement elRooms in elUser.Descendants("Reservations"))
                {
                    foreach (XElement ell in elRooms.Descendants("Reservation"))
                    {
                        resid = ell.Attribute("id").Value;
                        reshotel = ell.Element("Hotelname").Value;
                        resroom = ell.Element("RoomNo").Value;
                        rescheckin = ell.Element("Checkin").Value;
                        rescheckout = ell.Element("Checkout").Value;

                        Console.WriteLine("Reservation: ");
                        Console.WriteLine("Id: {0}  Hotel: {1}  Room: {2}  CheckIn: {3}  CheckOut: {4}", resid, reshotel, resroom, rescheckin, rescheckout);

                    }

                }

            }
        }
    } 
}