/* Program 21: Zero Level Constructor example */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Sub
    {
        int n1, n2;
        double diff;
        
        public Sub()
        {
            n1 = 10;
            n2 = 20;
        }
        
        /*public void get()
        {
            n1 = 10;
            n2 = 20;
        }*/

        public void sub()
        {
            diff = n1 - n2;
        }

        public void show()
        {
            Console.WriteLine("First number is: " + n1);
            Console.WriteLine("Second number is: " + n2);
            Console.WriteLine("Difference is: " + diff);
        }
    }

    class Code21
    {
        public static void Main(string[] args)
        {
            Sub obj = new Sub();
            //obj.get();
            obj.sub();
            obj.show();
            Console.ReadKey();
        }
    }
}
