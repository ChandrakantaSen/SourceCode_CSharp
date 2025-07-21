/* Program 24: Program on Parameterized function using function overloading (Page: 314 Q. No. 11) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Para_Ovrlding
    {
        
        public void num_cal(int num, char ch)
        {
            if (ch == 's')
            {
                Console.WriteLine("Square of number: " + (num * num));
            }
            else 
            {
                Console.WriteLine("Cube of number: " + (num * num * num));
            }
        }

        public void num_cal(int a, int b, char ch)
        {
            if (ch == 'p')
            {
                Console.WriteLine("Product of numbers: " + (a * b));
            }
            else
            {
                Console.WriteLine("Sum of numbers: " + (a + b));
            }
        }

        public void num_cal(string str1, string str2)
        {
            if (str1.Equals(str2))
            {
                Console.WriteLine("Two strings are equal");
            }
            else
            {
                Console.WriteLine("Two strings are not equal");
            }
        }
    }

    class Code24
    {
        public static void Main(string[] args)
        {
            Para_Ovrlding obj = new Para_Ovrlding();

            int choice;
            
            Console.WriteLine("Please enter the choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            { 
                case 1:
                    char x;
                    int y;
                   
                    Console.WriteLine("Enter the character: ");
                    x = char.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the number: ");
                    y = int.Parse(Console.ReadLine());

                    obj.num_cal(y,x);
                    break;
                case 2:
                    break;
                
                default:
                    Console.WriteLine("Wrong User...!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
