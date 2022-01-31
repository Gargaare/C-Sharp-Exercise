using System;

public class Solutions
{

	public static void SolutionOne()
	{
		Console.WriteLine("Write a number between 1 and 10");
		var input = Console.ReadLine();
		var number = Convert.ToInt32(input);
		if (number <= 10)

		{
			Console.WriteLine("Valid");
		}
		else
		{
			Console.WriteLine("Invalid");

		}
		//Console.WriteLine((number >= 1 && number <= 10) ? "Valid" : "Invalid");
	}

public static void SolutionTwo()
	{
		Console.WriteLine("Write the first number!");
		var numberOne = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Write the second number!");
		var numberTwo = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine((numberOne > numberTwo) ? "First number is greater than second: " + numberOne : "Second number is greater: " + numberTwo);
	}

	public static void SolutionThree()
	{
		Console.WriteLine("Write the width of the image!");
		var width = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Write the height of the image!");
		var height = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine((width > height) ? "The image is landscape" : "The image is portrait");
	}

	public static void SolutionFour()
	{
		Console.WriteLine("Write the Speed Limit in km/h:");
		var speedLimit = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("What was the car speed?");
		var carSpeed = Convert.ToInt32(Console.ReadLine());

		if (carSpeed <= speedLimit)
			Console.WriteLine("Ok");
		else
		{
			var demeritPoints = (carSpeed - speedLimit) / 5;
			if (demeritPoints > 12)
				Console.WriteLine("License suspended!");
			else
				Console.WriteLine("Car got {0} demerit points", demeritPoints);
		}
	}
}

public class Program
{

	public static void Main()
	{
		Solutions.SolutionOne();
		//Solutions.SolutionTwo();
		//Solutions.SolutionThree();
		//Solutions.SolutionFour();
	}
}
