/* Find area, perimeter, diagonal of rectangle */

using System;

namespace ConsoleApp
{
	class Code2
	{
		public static void Main(string[] args)
		{
			float length, breadth;
			double perimeter, area, diagonal;
			
			Console.Write("Enter the length: ");
			length = float.Parse(Console.ReadLine());
			
			Console.Write("Enter the breadth: ");
			breadth = float.Parse(Console.ReadLine());
			
			perimeter = Math.Round((2*(length + breadth)),2);
			area = Math.Round(length * breadth);
			diagonal = Math.Round(Math.Sqrt((length * length) + (breadth * breadth)));
			
			Console.WriteLine();
			Console.WriteLine("Required Perimeter: "+ perimeter);
			Console.WriteLine("Required Area: "+ area);
			Console.WriteLine("Required Diagonal: "+ diagonal);
			
			Console.WriteLine();
			Console.WriteLine("Please enter to continue...!");
			Console.ReadKey(true);
		}
	}
}