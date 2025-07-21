/*Program 5: Find maximum between 3 nos.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code5
    {
        public static void Main(string[] args)
        {
            int no1, no2, no3;

            Console.Write("Enter the number1: ");
            no1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number2: ");
            no2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number3: ");
            no3 = int.Parse(Console.ReadLine());

            if (no1 > no2 && no1 > no3)
            {
                Console.WriteLine();
                Console.WriteLine("Maximum is: " + no1);    
            }
            else if (no2 > no3 && no2 > no1)
            {
                Console.WriteLine();
                Console.WriteLine("Maximum is: " + no2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Maximum is: " + no3);
            }
            Console.ReadKey();
        }
    }
}