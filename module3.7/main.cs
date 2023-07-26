using System;

namespace module3._7
{
    partial class main
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day? ");
            Days day = checked((Days)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Your favorite day is {day}");
            Console.ReadKey();
        }
    }
}
