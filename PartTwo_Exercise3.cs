using System;

public class Program
{

	public static void Main()
	{
		Console.WriteLine("Please enter a number between 1 and 10 and get the factorial of it");


		int a = int.Parse(Console.ReadLine());

		int result = 1;

		for (int i = a; i > 0; i--)
		{
			result = result * i;

		}

		//5 ==> 5*4*3*2*1
		Console.WriteLine(result);

	}

}

