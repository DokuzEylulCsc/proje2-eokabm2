namespace Project2_OOP
{
    class SuiteHotel : Hotel
    {
        public SuiteHotel(string name, string city, int numberOfStars) : base(name, city, numberOfStars) { }

        public override string GetTypeToString()
        {
            return "Suite";
        }
    }
}
