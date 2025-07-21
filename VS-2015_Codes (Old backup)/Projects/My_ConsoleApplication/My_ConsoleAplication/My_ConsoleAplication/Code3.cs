/*Program 3: Sum of 2 nos. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code3
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Int32.Parse(Console.ReadLine());

            c = (a + b);
            Console.WriteLine("Sum is: " + c);
            Console.ReadKey();
        }
    }
}
