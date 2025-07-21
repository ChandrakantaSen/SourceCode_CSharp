/* Calculate the Emoployee Gross Pay */

using System;

namespace ConsoleApp
{
	public class Code3
	{
		public Code3()
		{
		}
		
		public static void Main(string[] args)
		{
			double basicSal = 0;
			double da,hra,pf;
			double grossPay = 0,netPay = 0;
			String str = "";
			
			Console.Write("Enter the Employee Name: ");
			str = Console.ReadLine();
			Console.Write("Enter the Basic Salary: ");
			basicSal = double.Parse(Console.ReadLine());
			Console.WriteLine();
			
			da = (basicSal * 25)/100;
			hra = (basicSal * 15)/100;
			pf = (basicSal * 8.33)/100;
			
			grossPay = (basicSal + da + hra);
			netPay = (grossPay - pf);
			
			Console.WriteLine("Employee Name: " + str);
			Console.WriteLine("Basic Salary: " + basicSal);
			Console.WriteLine("DA: " + da);
			Console.WriteLine("HRA: " + hra);
			Console.WriteLine("PF: " + pf);
			Console.WriteLine();
			Console.WriteLine("Gross Pay: " + grossPay);
			Console.WriteLine("Net Pay: " + netPay);
			
			Console.WriteLine();
			Console.WriteLine("Please enter to continue...!");
			Console.ReadKey(true);
		}
	}
}