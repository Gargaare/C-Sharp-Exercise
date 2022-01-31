// Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
//The following loop will run until the code hits a break command. We could also potentially make maximum of 5 entries before hitting break.

using System;

public class Program
{
	public static void Main()
	{
		
		var sum = 0;
		while (true)
		{
			Console.WriteLine("Please enter a number or OK to see a sum of entered numbers");
			var input = Console.ReadLine();
			if (input.ToLower() == "ok")
			{
				Console.WriteLine("Sum of entered numbers is " + sum);
				break;
			}
			else
				sum = sum + Convert.ToInt32(input);
			Console.WriteLine("Total: " + sum);
		}
	}
}
