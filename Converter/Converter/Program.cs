using System;

namespace Converter
{
    class Converter
    {
        private double Hryvnia { get; set; }
        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double USD, double EUR, double RUB)
        {
            this.usd = USD;
            this.eur = EUR;
            this.rub = RUB;
        }

        public void HryvniaToValute(double value, string valute)
        {
            Console.Write($"Enter the conversion amount: ");
            double sum = Convert.ToInt32(Console.ReadLine());
            double r = sum / value;
            Console.WriteLine($"Sum:{Math.Round(r, 2)} {valute}");
        }

        public void ValuteToHryvnia(double value)
        {
            Console.Write("Enter the conversion amount: ");
            double sum = Convert.ToInt32(Console.ReadLine());
            Hryvnia = sum * value;
            Console.WriteLine($"Sum: {Hryvnia} UAN");
        }

        public double Conversion()
        {
            Console.Write("Operation number: ");
            int n = Convert.ToInt32(Console.ReadLine());            

            if (n == 1)
            {
                HryvniaToValute(usd, "USD");
            }
            else if (n == 2)
            {
                HryvniaToValute(eur, "EUR");
            }
            else if (n == 3)
            {
                HryvniaToValute(rub, "RUB");
            }
            else if (n == 4)
            {
                ValuteToHryvnia(usd);
            }
            else if (n == 5)
            {
                ValuteToHryvnia(eur);
            }
            else if (n == 6)
            {
                ValuteToHryvnia(rub);
            }
            else
            {
                Console.Write("Error! Enter the correct transaction number!");
            }
            return Hryvnia;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the operation you want to perform:");
            Console.WriteLine("  1.Convert hryvnia to dollar.");
            Console.WriteLine("  2.Convert hryvnia to euro.");
            Console.WriteLine("  3.Convert hryvnia to ruble.");
            Console.WriteLine("  4.Convert dollar to hryvnia.");
            Console.WriteLine("  5.Convert euro to hryvnia.");
            Console.WriteLine("  6.Convert ruble to hryvnia.");

            Converter convert = new Converter(41, 40.35, 0.3);

            convert.Conversion();
            Console.ReadKey();
        }
    }
}
