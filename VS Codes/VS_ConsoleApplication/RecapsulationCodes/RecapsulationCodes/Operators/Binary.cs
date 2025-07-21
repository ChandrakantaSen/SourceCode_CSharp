using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Operators
{
    class Binary
    {
        public static void Main()
        {
            int x, y, result;
            float floatResult;

            x = 7;
            y = 5;

            result = x + y;
            Console.WriteLine("x+y: {0}", result);

            result = x - y;
            Console.WriteLine("x-y: {0}", result);

            result = x * y;
            Console.WriteLine("x*y: {0}", result);

            result = x / y;
            Console.WriteLine("x/y: {0}", result);

            floatResult = (float)x / (float)y;
            Console.WriteLine("x/y: {0}", floatResult);

            result = x % y;
            Console.WriteLine("x%y: {0}", result);

            result += x;
            Console.WriteLine("result+=x: {0}", result);

            Console.ReadKey(true);
        }
    }
}