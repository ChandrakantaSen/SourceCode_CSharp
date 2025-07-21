using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Static
{
    public class Account1
    {
        public int accno;
        public String name;
        public static float rateOfInterest = 8.8f;
        public Account1(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    class Code2
    {
        public static void Main(string[] args)
        {
            Account1.rateOfInterest = 10.5f;//changing value  
            Account1 a1 = new Account1(101, "Sonoo");
            Account1 a2 = new Account1(102, "Mahesh");
            a1.display();
            a2.display();

            Console.ReadKey(true);
        }
    }
}