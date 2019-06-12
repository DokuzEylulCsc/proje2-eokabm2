namespace Project2_OOP
{
    class ResortHotel : Hotel
    {
        public ResortHotel(string name, string city, int numberOfStars) : base(name, city, numberOfStars) { }

        public override string GetTypeToString()
        {
            return "Resort";
        }
    }
}
