/* Sum of two numbers */

using System;

namespace ConsoleApp
{
	class Code1
	{
		public static void Main(string[] args)
		{
			int num1, num2;
			float sum = 0;
			
			Console.Write("Enter the first number: ");
			num1 = int.Parse(Console.ReadLine());
			
			Console.Write("Enter the second number: ");
			num2 = int.Parse(Console.ReadLine());
			
			sum = num1 + num2;
			
			Console.WriteLine("Sum is: "+sum);
			Console.ReadKey(true);
		}
	}
}