using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Operator_Overloading
{
    class bank
    {
        int x;
        int y;
        public bank(int a, int b)
        {
            x = a;
            y = b;
        }
        public bank()
        {
        }
        public void display()
        {
            Console.Write(" " + x);
            Console.Write(" " + y);
            Console.WriteLine("\n------------");
            Console.WriteLine("");
        }
        public static bank operator -(bank b)
        {
            b.x = -b.x;
            b.y = -b.y;
            return b;
        }
    }
    class BinaryOprOvrLding_2
    {
        public static void Main()
        {
            bank ba1 = new bank(10, -20);
            ba1.display();
            bank ba2 = new bank();
            ba2.display();
            ba2 = -ba1;
            ba2.display();
            Console.ReadLine();
        }
    }
}