using System;

class MainClass
{
	public static void Main(string[] args)
	{

		const string myName = "Kate";

		Console.WriteLine(myName);

        Console.WriteLine($"\t\tПривет, мир\n\t\tМне 26 лет\n\t\tMy name is\n{myName}");
		Console.ReadKey();
	}
}