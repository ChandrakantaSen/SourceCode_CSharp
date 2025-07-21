/* Pogramme 16: Multi class Parameterized function */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cc = System.Console;

namespace My_ConsoleAplication
{
    class Addition
    {
        int cn1, cn2, sum = 0;

        public void add(int tn1, int tn2)
        {
            cn1 = tn1;
            cn2 = tn2;
            sum = cn1 + cn2;
        }
        public void show()
        {
            cc.WriteLine("required Sum is: "+sum);
            cc.ReadKey();
        }
    }
    class Code16
    {
        public static void Main(string[] args)
        {
            int no1, no2;
            cc.WriteLine("Enter the number1: ");
            no1 = int.Parse(cc.ReadLine());

            cc.WriteLine("Enter the number1: ");
            no2 = int.Parse(cc.ReadLine());

            Addition obj = new Addition();
            obj.add(no1, no2);
            obj.show();
        }
    }
}
