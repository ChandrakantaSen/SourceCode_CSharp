using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class Code_6
    {
        public static void Main(string []args)
        {
            int num, c = 0;
            Console.Write("\nEnter the number: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is composite number...!");
            }
            else
            {
                for(int i = 2; i <= (num/2); i++)
                {
                    if (num % i == 0)
                    {
                        c = 1; break;
                    }
                }

                if(c == 1)
                {
                    Console.WriteLine(num + " is composite number...!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(num + " is prime number...!");
                    Console.ReadKey();
                }
            }
        }
    }
}
