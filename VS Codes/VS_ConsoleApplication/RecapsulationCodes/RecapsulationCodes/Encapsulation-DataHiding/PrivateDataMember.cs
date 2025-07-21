using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Encapsulation_DataHiding
{
    class Encapsulation
    {
        private int x, y, z;

        public void getValue()
	    {
		    Console.Write("Enter the vlaue of x: ");
		    x = int.Parse(Console.ReadLine());

            Console.Write("Enter the vlaue of y: ");
            y = int.Parse(Console.ReadLine());
	    }

	    public void addition()
	    {
		    z = (x + y);
	    }

	    public void display()
	    {
            Console.WriteLine();
            Console.WriteLine("Sum is: " + z);
	    }
    }
    
    class PrivateDataMember
    {
        public static void Main(string[] args)
        {
            Encapsulation obj = new Encapsulation();

            obj.getValue();
            obj.addition();
            obj.display();

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
