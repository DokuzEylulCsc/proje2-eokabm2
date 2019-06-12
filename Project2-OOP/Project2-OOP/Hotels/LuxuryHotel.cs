namespace Project2_OOP
{
    class LuxuryHotel : Hotel
    {
        public LuxuryHotel(string name, string city, int numberOfStars) : base(name, city, numberOfStars) { }

        public override string GetTypeToString()
        {
            return "Luxury";
        }
    }
}
