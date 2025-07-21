/* Program 20: Default Constructor example */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Add
    {
        int n1, n2;
        double sum;

        public void get()
        {
            n1 = 10;
            n2 = 20;
        }

        public void add()
        {
            sum = n1 + n2;
        }
        public void show()
        {
            Console.WriteLine("First number is: "+n1);
            Console.WriteLine("Second number is: "+n2);
            Console.WriteLine("Sum is: " + sum);
        }
    }

    class Code20
    {
        public static void Main(string[] args)
        {
            Add obj = new Add();
            //obj.get();
            obj.add();
            obj.show();
            Console.ReadKey();
        }
    }
}
