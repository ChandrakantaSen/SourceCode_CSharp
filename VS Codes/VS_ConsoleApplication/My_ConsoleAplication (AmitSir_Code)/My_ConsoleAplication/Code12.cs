/* Program 12: Call function within function */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Code12
    {
        static int fibo_input()
        {
            int num;
            Console.Write("Enter the range: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void fibo_gen()
        {
            int i, f0 = 0, f1 = 1, f2;
            int rng = fibo_input();

            Console.Write(" "+ f0 +" "+ f1);
            
            for (i = 0; i <= (rng-2); i++)
            {
                f2 = f0 + f1;
                Console.Write(" " + f2);
                f0 = f1;
                f1 = f2;
            }
        }
        public static void Main(string[] args)
        {
            fibo_gen();
            Console.ReadKey();
        }
    }
}
