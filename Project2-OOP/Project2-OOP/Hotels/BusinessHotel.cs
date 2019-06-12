namespace Project2_OOP
{
    class BusinessHotel : Hotel
    {
        public BusinessHotel(string name, string city, int numberOfStars) : base(name, city, numberOfStars) { }

        public override string GetTypeToString()
        {
            return "Business";
        }
    }
}
