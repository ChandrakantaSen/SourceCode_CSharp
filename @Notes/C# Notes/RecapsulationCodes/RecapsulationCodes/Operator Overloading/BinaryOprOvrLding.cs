/* Binary Operator Overloading */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Operator_Overloading
{
    class Student1
    {
        int total;

        public void get()
        {
            Console.WriteLine("Enter the number: ");
            total = int.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine("Total number is: " + total);
        }

        public static int operator +(Student1 reff1, Student1 reff2)
        {
            int fs;
            fs = reff1.total + reff2.total;

            return fs;
        }
    }

    class BinaryOprOvrLding
    {
        public static void Main(string[] args)
        {
            Student1 obj1 = new Student1();
            Student1 obj2 = new Student1();


            obj1.get();
            obj2.get();

            int result = obj1 + obj2;

            Console.WriteLine("Result is: " + result);
            Console.ReadLine();
        }
    }
}