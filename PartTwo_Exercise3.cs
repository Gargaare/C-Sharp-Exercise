//Write a program and ask the user to enter a number. Compute the 
//factorial of the number and print it on the console. For example, 
//if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

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

