/* Program 22: Parameterized (or Overloaded) Constructor example */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Multi
    {
        int n1, n2;
        double calc;

        public Multi(int x,int y)
        {
            n1 = x;
            n2 = y;
        }

        public void multi()
        {
            calc = n1 * n2;
        }

        public void show()
        {
            Console.WriteLine("First number is: " + n1);
            Console.WriteLine("Second number is: " + n2);
            Console.WriteLine("calcerence is: " + calc);
        }
    }

    class Code22
    {
        public static void Main(string[] args)
        {
            Multi obj = new Multi(2,8);
            obj.multi();
            obj.show();
            Console.ReadKey();
        }
    }
}
