/*Program 6: Find the sum of even digit*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code6
    {
        static void Main(string[] args)
        {
            int rng, sum = 0;
            int d;

            Console.Write("Enter the number: ");
            rng = int.Parse(Console.ReadLine());

            while(rng != 0)
            {
                d = rng % 10;
                if (d % 2 == 0)
                {
                    sum = sum + d;
                }
                rng = rng / 10;
            }

            Console.WriteLine("Sum of digit is: " + sum);
            Console.ReadKey();
        }
    }
}