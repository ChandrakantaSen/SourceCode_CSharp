using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class Code_3
    {
        public static void Main(string[]args)
        {
            int num, j, k;
            Console.Write("\nEnter the number: ");
            num = int.Parse(Console.ReadLine());
            int i = 1;

            while(i<=num)
            {
                k = 0;
                if (num % i == 0)
                {
                    j = 1;
                    while(j<=i)
                    {
                        if(i%j==0)
                        {
                            k++;
                        }
                        j++;
                    }
                    if(k==2)
                    {
                        Console.WriteLine(i + "is the prime factor");    
                    }
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
