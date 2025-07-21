/*Program 7: Find the sum of factorials of the digits of a number */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code7
    {
        public static void Main(string[] args)
        {
            int n,sum = 0,i,f=1;
            int d, p;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            
            p = n;

            while(p!=0)
            {
                d = p % 10;
                f = 1;
                for(i = 1; i<=d; i++)
                {
                    f = f * i;
                }
                sum = sum + f;
                p = p / 10;
            }
            Console.Write("Sum is: "+sum);
            Console.ReadKey();

        }
    }
}
