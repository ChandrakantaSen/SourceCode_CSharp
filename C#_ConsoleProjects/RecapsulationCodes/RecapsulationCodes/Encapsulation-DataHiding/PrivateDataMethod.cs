using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Encapsulation_DataHiding
{
    class Encapsul
    {
        private int a, b, c;
        
        private void getVal()
	    {
		    Console.Write("Enter the vlaue of a: ");
		    a = int.Parse(Console.ReadLine());

		    Console.Write("Enter the vlaue of b: ");
		    b = int.Parse(Console.ReadLine());
	    }

	    public void multiplication()
	    {
		    getVal();
		    c = (a * b);
	    }

	    public void disp()
	    {
		    Console.WriteLine("Multiplication is: " + c);
	    }
    }

    class PrivateDataMethod
    {
        public static void Main(string[] args)
        {
            Encapsul enObj = new Encapsul();

            enObj.multiplication();
            enObj.disp();

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
