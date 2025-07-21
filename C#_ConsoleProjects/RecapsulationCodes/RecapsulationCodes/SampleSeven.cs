/* Example: Appication of Constructors */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class RectangleCons
    {
        public int length, breadth;
        public RectangleCons(int x, int y)
        {
            length = x;
            breadth = y;
        }
        public int RectArea()
        {
            return (length * breadth);
        }
    }

    class SampleSeven
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            
            Console.Write("Enter number1: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter number2: ");
            num2 = int.Parse(Console.ReadLine());


            RectangleCons obj = new RectangleCons(num1, num2);
            int area = obj.RectArea();
            Console.WriteLine("Result is: " + area);

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
