/* Program 22: Parameterized (or Overloaded) Constructor example */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Div
    {
        int n1, n2;
        double calc;

        public Div(int x, int y)
        {
            n1 = x;
            n2 = y;
        }
        
        public Div(Div refobj)
        {
            n1 = refobj.n1;
            n2 = refobj.n2;
        }

        public void div()
        {
            calc = n1 / n2;
        }

        public void show()
        {
            Console.WriteLine("First number is: " + n1);
            Console.WriteLine("Second number is: " + n2);
            Console.WriteLine("calcerence is: " + calc);
        }
    }

    class Code23
    {
        public static void Main(string[] args)
        {
            Div obj = new Div(16, 8);
            Div obj_1 = new Div(obj);
            
            obj_1.div();
            obj_1.show();

            Console.ReadKey();
        }
    }
}
