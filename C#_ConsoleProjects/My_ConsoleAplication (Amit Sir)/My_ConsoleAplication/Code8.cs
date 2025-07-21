/* Program 8: Without return type & without parameters */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code8
    {
        
        static void add()
        {
            int a, b, c=0;
            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            c = (a + b);
            Console.WriteLine("Required Sum is: "+c);
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            add();
        }

    }
}
