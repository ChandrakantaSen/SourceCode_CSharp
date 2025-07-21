/* Program 10: With return type & without parameters */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code10
    {
        static int add()
        {
            int a, b, c = 0;
            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            c = (a + b);
            return c;
        }
        public static void Main(string[] args)
        {
            int result;
            result = add();

            Console.WriteLine("Required is: " + result);
            Console.ReadKey();
        }
    }
}
