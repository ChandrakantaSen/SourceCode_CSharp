using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Array
{
    public class ArrayCode1
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

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
