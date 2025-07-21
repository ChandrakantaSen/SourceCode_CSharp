/* Program 12: 2D array */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cc = System.Console;

namespace My_ConsoleAplication
{
    class Code13
    {
        public static void Main(string[] args)
        {
            int[,] m = new int[3, 5];
            int[] s = new int[3];
            int r,c;

            for (r = 0; r <= 2; r++)
            {
                s[r] = 0;
                cc.WriteLine("Enter the marks for student" + (r + 1) + ":");        
                for (c = 0; c <= 4; c++)
                {
                    Console.WriteLine("Enter the marks: ");
                    m[r, c] = int.Parse(Console.ReadLine());
                    s[r] = s[r] + m[r, c];
                }
            }

            for (r = 0; r <= 2; r++)
            {
               Console.Write(s[r]+" ");
            }
            //Environment.Exit();
            Console.ReadLine();
        }
    }
}
