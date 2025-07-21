using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class Code_1
    {
        public static void Main(string [] args)
        {
            int i, rng, sum = 0;
            Console.WriteLine("Enter the range: ");
            rng = int.Parse(Console.ReadLine());

            Console.WriteLine("\n=== Series is ===");
            for (i = 0; i < rng; i++)
            {
                if((i % 3) == 0 || (i % 5) == 0)
                {
                    if(i != 0)
                    {
                        Console.Write(" " + i);
                        sum += i;
                    }
                }
            }
            Console.WriteLine("\n\nSum is: " + sum);
            Console.ReadKey();
        }
    }
}
