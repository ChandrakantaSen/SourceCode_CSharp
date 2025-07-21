/*Program 4: Sum of 3 digit no. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code4
    {
        static void Main(string[] args)
        {
            int rng;
            int a, b, c, sum = 0;

            Console.WriteLine("Enter the number: ");
            rng = int.Parse(Console.ReadLine());

            a = rng % 10;
            b = (rng / 10) % 10;
            c = rng / 100;
            sum = (a + b + c);

            Console.WriteLine("Sum of digit is: " + sum);
            Console.ReadKey();
        }
    }
}