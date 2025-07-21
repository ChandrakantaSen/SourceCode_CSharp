/** Check a number is prime or not **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class Code_5
    {
        public static void Main(string[]args)
        {
            int num, c = 0;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    c++;
                }
            }
            if(c == 2)
            {
                Console.WriteLine(num + " is prime...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(num + " is composite...");
                Console.ReadKey();
            }
        }      
    }
}
