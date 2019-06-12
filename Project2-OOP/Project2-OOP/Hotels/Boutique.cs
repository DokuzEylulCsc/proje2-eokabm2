namespace Project2_OOP
{
    class BoutiqueHotel : Hotel
    {
        public BoutiqueHotel(string name, string city, int numberOfStars) : base(name, city, numberOfStars) { }

        public override string GetTypeToString()
        {
            return "Boutique";
        }
    }
}
