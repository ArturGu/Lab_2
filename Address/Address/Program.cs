using System;

namespace Address
{
    class Address
    {

        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public void Print()
        {
            Console.WriteLine($"Index: {index};");
            Console.WriteLine($"Country: {country};");
            Console.WriteLine($"City: {city};");
            Console.WriteLine($"Street: {street};");
            Console.WriteLine($"House: {house};");
            Console.WriteLine($"Apartment: №{apartment}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "02000";
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Lobachevsky";
            address.House = "23";
            address.Apartment = "423";
            address.Print();

            Console.ReadKey();
        }
    }
}
