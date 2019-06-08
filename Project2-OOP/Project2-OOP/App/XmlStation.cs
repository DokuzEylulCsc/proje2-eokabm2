using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Project2_OOP
{
    class XmlStation
    {
        List<Hotel> hotels;
        List<User> users;
        
        public bool FileExist(string curFile)
        {
            bool a=false;
            if (File.Exists(curFile)) a = true;
            return a;
        }
        //https://docs.microsoft.com/tr-tr/dotnet/api/system.io.file.exists?view=netframework-4.8
        public void CreateHotelXML()
        {
            string curFile = @"Hotel.xml";
            if (File.Exists(curFile))
            {

            }
        }
        public void CreateUserXML()
        {
            string curFile = @"User.xml";
            if (File.Exists(curFile))
            {

            }
        }


        public void saveXmlHotel()
        {
            XDocument xDoc = XDocument.Load(@"Hotel.xml");
        }


        public List<Hotel> SetHotels()
        {
            hotels = new List<Hotel>();
            
            return hotels;
        }
    }
}
