using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Static
{
    public class Account
    {
        public int accno;
        public String name;
        public static float rateOfInterest = 8.8f;
        public Account(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }

    class Code1
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();

            Console.ReadKey(true);
        }
    }
}