using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class MathOperation
    {
        public static void add()
        {
            double num1, num2, result = 0;
            Console.Write("Enter the number-1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number-2: ");
            num2 = double.Parse(Console.ReadLine());

            result = (num1 + num2);
            Console.WriteLine();
            Console.Write("Result is: " + result);
        }
    }
    
    class SampleEight
    {
        public static void Main(string[] args)
        {
            MathOperation.add();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
