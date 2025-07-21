using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Properties_AccessorMethod
{
    class Property
    {
        private int number;
        public int Anumber
        {
            get 
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
    
    class PropertyTest
    {
        public static void Main(string[] args)
        {
            Property propOBJ = new Property();

            propOBJ.Anumber = 555;
            int m = propOBJ.Anumber;

            Console.WriteLine("Value of Number: " + m);

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
