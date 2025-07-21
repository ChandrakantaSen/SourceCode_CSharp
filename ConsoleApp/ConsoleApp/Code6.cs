/* Find out the example of multiple class */
using System;

namespace ConsoleApp
{
	class Sample
	{
		int a,b,c,max=0;
		
		public void input()
		{
			Console.Write("Enter the number1: ");
			a = int.Parse(Console.ReadLine());			
			Console.Write("Enter the number2: ");
			b = int.Parse(Console.ReadLine());	
			Console.Write("Enter the number3: ");
			c = int.Parse(Console.ReadLine());			
		}
		
		public void calculate()
		{
			if(a>=b && a>=c)
			{
				if(b>=c)
				{
					max = b;
				}
				else
				{
					max = c;
				}
			}
			else if(b>=a && b>=c)
			{
				if(a>=c)
				{
					max = a;
				}
				else
				{
					max = c;
				}
			}
			else if(a>=b)
			{
				max = a;
			}
			else
			{
				max = b;
			}
		}
		
		public void display()
		{
			Console.WriteLine();
			Console.WriteLine("Second highest number is: " + max);
			Console.WriteLine();
		}
	}
	
	public class Code6
	{
		public static void Main(string[] args)
		{
			Sample obj = new Sample();
			obj.input();
			obj.calculate();
			obj.display();
			
			Console.WriteLine("Please enter to continue...!");
			Console.ReadKey(true);
		}
	}
}
