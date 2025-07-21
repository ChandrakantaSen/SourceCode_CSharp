/* Example: How to pass output parameter as a method parameter */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class OutputParams
    {
        public void Square(int x, out int y)
        {
            y = x * x;
        }
    }

    class CodeFile3
    {
        public static void Main(string[] args)
        {
            int result1;
            OutputParams outObj = new OutputParams();

            outObj.Square(10, out result1);
            Console.WriteLine("Output Value is: " + result1);

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}