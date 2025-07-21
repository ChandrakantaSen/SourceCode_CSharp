/* Program 17: Input & print array elements */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cc = System.Console;

namespace My_ConsoleAplication
{
    class Code17
    {
        public static void Main(string[] args)
        { 
            int []arr = new int [5];
            int i;

            for (i = 0; i < 5; i++)
            {
                cc.Write("Enter the elements: ");
                arr[i] = int.Parse(cc.ReadLine());
            }

            cc.WriteLine("Array elements are: ");
            for (i = 0; i < 5; i++)
            {
                cc.Write(" "+arr[i]);
            }
            cc.ReadKey();
        }
    }
}
