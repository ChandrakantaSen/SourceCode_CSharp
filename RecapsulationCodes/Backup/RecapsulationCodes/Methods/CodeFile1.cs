/* Example: Type of Methods */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class MethodExample
    {
        public void addition()
        {
            int a, b, c;

            Console.WriteLine("Enter the first value: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            b = int.Parse(Console.ReadLine());
            
            c = (a + b);
            Console.WriteLine("Sum is: " + c);
        }

        public void subtraction(int x, int y)
        {
            int z = (x - y);
            Console.WriteLine("Subtraction is: " + z);
        }

        public int multiplication()
        { 
            int a,b,c;

            Console.WriteLine("Enter the first value: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            b = int.Parse(Console.ReadLine());

            c = (a * b);
            return c;
        }

        public int division(int x, int y)
        {
            int z = (x / y);
            return z;
        }
    }

    class CodeFile1
    {
        public static void Main(string[]args)
        {
            int ch;
            MethodExample mExp = new MethodExample();

            Console.Write("Enter the choice: ");
            ch = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (ch)
            {
                case 1: mExp.addition();                                            
                        break;
                case 2:
                        int p, q;
                        Console.WriteLine("Enter the first value: ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second value: ");
                        q = int.Parse(Console.ReadLine());

                        mExp.subtraction(p,q);                                      
                        break;
                case 3: 
                        int result;
                        result = mExp.multiplication();
                        Console.WriteLine("\nMultiplication is: " + result);        
                        break;
                case 4:
                        int result1, p1, q1;
                        Console.WriteLine("Enter the first value: ");
                        p1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second value: ");
                        q1 = int.Parse(Console.ReadLine());

                        result1 = mExp.division(p1,q1);
                        Console.WriteLine("\nDivision is: " + result1);
                        break;

                default: Console.WriteLine("Wrong Input...!");                      
                         break;
            }
            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}