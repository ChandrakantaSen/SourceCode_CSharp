using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Static
{
    public class Account3
    {
        public int accno;
        public String name;
        public static int count = 0;
        public Account3(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name);
        }
    }

    class Code3
    {
        public static void Main(string[] args)
        {
            Account3 a1 = new Account3(101, "Sonoo");
            Account3 a2 = new Account3(102, "Mahesh");
            Account3 a3 = new Account3(103, "Ajeet");
            a1.display();
            a2.display();
            a3.display();
            Console.WriteLine("Total Objects are: " + Account3.count);

            Console.ReadKey(true);
        }
    }
}