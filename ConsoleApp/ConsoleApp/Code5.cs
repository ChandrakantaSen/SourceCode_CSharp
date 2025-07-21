using System;

namespace ConsoleApp
{
	public class Code5
	{
		public Code5()
		{
		}
		
		public static void Main(string[] args)
		{
			double totCost = 0;
			double disc = 0, netPay = 0;
			
			Console.Write("Enter the number: ");
			totCost = int.Parse(Console.ReadLine());
			
			if(totCost <= 2000) {
				disc = (totCost * 5)/100;
			}
			else if(totCost > 2000 && totCost <= 5000) {
				disc = (totCost * 25)/100;
			}
			else if(totCost > 5000 && totCost <= 10000) {
				disc = (totCost * 35)/100;
			}
			else {
				disc = (totCost * 50)/100;
			}
			
			netPay = (totCost - disc);
			
			Console.WriteLine("Total Cost: " + totCost);
			Console.WriteLine("Discount: " + disc);
			Console.WriteLine("Net Pay: " + netPay);
			
			Console.WriteLine();
			Console.WriteLine("Please enter to continue...!");
			Console.ReadKey(true);
		}
	}
}
