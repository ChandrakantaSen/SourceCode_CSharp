using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class Code_2
    {
        public static void Main(string [] args)
        {
            int f0 = 0, f1 = 1, f2, rng, sum = 0;
            Console.WriteLine("\nEnter the rnage: ");
            rng = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEven Fibonacci Series");
            for(int i = 2; i <= rng; i++)
            {
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;
                if(f2 % 2 == 0)
                {
                    sum += f2;
                    Console.Write(f2 + " ");
                }
            }
            Console.WriteLine("\n\nEven Fibonacci Series Sum: " + sum);
            Console.ReadKey();
        }
    }
}
