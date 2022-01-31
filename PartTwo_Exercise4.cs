using System;

public class Program
{
	public static void Main()
	{
		
		var randomNumber = (new Random()).Next(10);
		Console.WriteLine("Random number: {0}", "?");
		for (var i = 1; i <= 4; i++)
		{
			Console.Write("Guess my number between 1 and 10: ");
			var input = Convert.ToInt32(Console.ReadLine());
			if (input == randomNumber)
			{
				Console.WriteLine("You Won!");
				break;
			}
			else if (i == 4)
			{
				Console.WriteLine("You Lost!");
			}
		}
		Console.ReadLine();

	}
}
