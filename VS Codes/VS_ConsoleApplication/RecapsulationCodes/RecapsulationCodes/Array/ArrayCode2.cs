using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Array
{
    class ArrayCode2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            //traversing array  
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}