/* Program 11: With return type & with parameters */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code11
    {
        static int add(int a, int b)
        {
            int result = (a + b);
            return result;
        }
        public static void Main(string[] args)
        {
            int num1, num2, sum = 0;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            sum = add(num1, num2);

            Console.WriteLine("Required Sum is: " + sum);
            Console.ReadKey();
        }
    }
}
