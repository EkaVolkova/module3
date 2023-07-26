using System;

namespace module3._2
{
    class main
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Как вас зовут?");
			string myName = Console.ReadLine();
			Console.WriteLine("Сколько вам лет?");
			byte age = byte.Parse(Console.ReadLine());
			Console.WriteLine("Если ли у вас питомец?");
			bool isHavePet = bool.Parse(Console.ReadLine());
			Console.WriteLine("Какой у вас размер ноги?");
			float shoeSize = float.Parse(Console.ReadLine());

			Console.WriteLine($"My name is {myName}");
			Console.WriteLine($"My age is {age}");
			Console.WriteLine($"Do I have a pet? {isHavePet}");
			Console.WriteLine($"My shoe size is {shoeSize}");

			Console.ReadKey();
		}
    }
}
