using System;

namespace User
{
    class User
    {
        public string Login;
        public string Name;
        public string Surname;
        public int Age;
        public string Date;

        public void Information()
        {
            Console.Write("Логiн: ");
            Login = Console.ReadLine();

            Console.Write("Iм'я: ");
            Name = Console.ReadLine();

            Console.Write("Призвiще: ");
            Surname = Console.ReadLine();

            Console.Write("Скiльки вам рокiв: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Date = DateTime.Now.ToString();

            Console.WriteLine();
            Console.WriteLine($"Ваш логiн: {Login};");
            Console.WriteLine($"Ваше iм'я: {Name} {Surname};");
            Console.WriteLine($"Вiк: {Age};");
            Console.WriteLine($"Дата заповнення анкети: {Date};");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Information();
            Console.ReadKey();
        }
    }
}