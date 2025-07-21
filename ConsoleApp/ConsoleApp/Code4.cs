
using System;

namespace ConsoleApp
{
	public class Code4
	{
		public Code4()
		{
		}
		
		public static void Main (string[] args)
		{
			int num1;
			
			Console.Write("Enter the number: ");
			num1 = int.Parse(Console.ReadLine());
			
			if (num1 % 2 == 0) {
				Console.WriteLine("Even Number...!");
			}
			else {
				Console.WriteLine("Odd Number...!");	
			}

			Console.WriteLine();
			Console.WriteLine("Please enter to continue...!");
			Console.ReadKey(true);			
		}
	}
}
