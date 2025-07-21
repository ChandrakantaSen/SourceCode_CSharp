using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Array
{
    class ArrayCode4
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}  