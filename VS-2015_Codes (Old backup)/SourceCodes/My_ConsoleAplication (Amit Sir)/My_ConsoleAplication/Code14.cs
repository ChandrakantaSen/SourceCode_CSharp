/* Program 13: Jagged Array */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cc = System.Console;

namespace My_ConsoleAplication
{
    class Code14
    {
        public static void Main(string[] args)
        {
            int std_nos;
            int r,c,ch;
            cc.WriteLine("Enter the number of Students: ");
            std_nos = int.Parse(Console.ReadLine());
            
            int [][]m = new int[std_nos][];
            int []sum = new int[std_nos];
            int []nos = new int[std_nos];
            for (r = 0; r < std_nos; r++)
            {
                cc.WriteLine("details of student"+(r+1));
                cc.Write("Enter the number of subjects");
                ch = int.Parse(cc.ReadLine());
                nos[r] = ch;
                m[r] = new int[ch];
                sum[r]=0;
                for (c = 0; c < ch; c++)
                {
                    cc.Write("enter the marks: ");
                    m[r][c] = int.Parse(cc.ReadLine());
                    sum[r] = sum[r] + m[r][c];
                }
            }
            for (r = 0; r < std_nos; r++)
            {
                cc.WriteLine("Student number: " + (r + 1) + " Subject number: " + nos[r] + " Total number: " + sum[r]);
            }
            cc.ReadLine();
        }
    }
}