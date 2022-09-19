using System;

namespace Employee
{
    class Employee
    {
        private readonly string name;
        private readonly string surname;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        int post;
        int experience;
        public double salary;
        public double tax;

        public void SalaryCalc(string position, double salary)
        {
            this.salary = salary;
            tax = salary * 0.18;
            Console.WriteLine($"Посада: {position} Software Engineer.");
            Console.WriteLine($"Стаж: {experience}рокiв.");
            Console.WriteLine($"Зарплата: {salary}(грн).");
            Console.WriteLine($"Податок: {tax}(грн).");
        }

        public void Salary()
        {
            Console.WriteLine("Виберiть номер посади: ");
            Console.WriteLine("1.Junior Software Engineer;");
            Console.WriteLine("2.Middle Software Engineer;");
            Console.WriteLine("3.Senior Software Engineer.");
            Console.Write("№: ");
            post = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Junior Software Engineer (1-2)роки!");
            Console.WriteLine("2.Middle Software Engineer (3-4)роки!");
            Console.WriteLine("3.Senior Software Engineer (5+)рокiв!");
            Console.Write("Введiть свiй стаж (роки): ");
            experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Iм'я: {name}.");
            Console.WriteLine($"Призвiще: {surname}.");

            if (post == 1 && experience == 1)
            {
                SalaryCalc("Junior", 36424);
            }
            if (post == 1 && experience == 2)
            {
                SalaryCalc("Junior", 38448);
            }
            if (post == 2 && experience == 3)
            {
                SalaryCalc("Middle", 95635);
            }
            if (post == 2 && experience == 4)
            {
                SalaryCalc("Middle", 101179);
            }
            if (post == 3 && experience >= 5)
            {
                SalaryCalc("Senior", 182123);
            }
            else
            {
                Console.WriteLine("Помилка! Неправильно введенi данi!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iм'я: ");
            string a = Console.ReadLine();

            Console.Write("Призвiще: ");
            string b = Console.ReadLine();

            Employee employee = new Employee(a, b);
            employee.Salary();
            Console.ReadKey();
        }
    }
}