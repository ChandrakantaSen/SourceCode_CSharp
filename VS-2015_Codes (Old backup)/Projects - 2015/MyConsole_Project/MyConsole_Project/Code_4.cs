using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class Code_4
    {
        public static void Main(string[]args)
        {
            int num, i;
            int[] arr = new int[10];
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    int c = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if(i % j == 0)
                        {
                            c++;
                        }
                    }
                    if(c == 2)
                    {
                        Console.Write(" " + i);
                        /*for(int k = 0; k <= arr.Length; k++)
                        {
                            arr[k] = i;
                        }*/
                    }
                }
            }
            /*for (int k = 0; k <= arr.Length; k++)
            {
                Console.Write(" " + arr[k]);
            }*/
            Console.ReadKey();
        }
    }
}