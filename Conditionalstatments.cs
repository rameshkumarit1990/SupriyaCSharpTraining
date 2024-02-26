using System;

public class ConditionalStatment
{
	public static void IFStatements()
	{
		Console.WriteLine("Please enter a number");
		
	int UserNumber =int.Parse(Console.ReadLine());

		if (UserNumber == 1) 
		{
			Console.WriteLine("Your number is one");
		}
		if (UserNumber == 2)
		{
			Console.WriteLine("Your number is two");
		}
	}
}
