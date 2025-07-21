/* Example: How to pass array as a method parameter */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class ArrMethod
    {
        public int avrg(int []x, int size)
        {
            int j,sum = 0;
            for (j = 0; j < size; j++)
            { 
                sum = sum + x[j];
            }
            return sum;
        }
    }

    class CodeFile2
    {
        public static void Main(string[] args)
        {
            ArrMethod amtd = new ArrMethod();
            int[] arr = new int[5];
            int i,result;

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the elements: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            result = amtd.avrg(arr,5);
            Console.WriteLine("Value of sum is: " + result);

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}