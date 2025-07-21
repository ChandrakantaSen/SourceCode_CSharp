/* Accessing Private Data using Accessor Methods */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Properties_AccessorMethod
{
    class Number
    {
        private int number;
        public void SetNumber(int x)
        {
            number = x;
        }

        public int GetNumber()
        {
            return number;
        }
    }
    
    class NumberTest
    {
        public static void Main(string[] args)
        {
            Number numOBJ = new Number();
            numOBJ.SetNumber(100);
            Console.WriteLine("Number is: " + numOBJ.GetNumber());

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
