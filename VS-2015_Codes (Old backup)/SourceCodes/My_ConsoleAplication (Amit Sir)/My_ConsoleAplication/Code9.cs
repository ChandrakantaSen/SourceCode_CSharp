/* Program 9: Without return type & with parameters */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code9
    {
        static void add(int a, int b)
        {
            int result = (a + b);
            Console.WriteLine("Sum is: "+result);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            add(num1, num2);
        }
    }
}
