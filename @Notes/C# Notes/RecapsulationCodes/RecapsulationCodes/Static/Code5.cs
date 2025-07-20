using System;

namespace RecapsulationCodes.Static
{
    public class Account4
    {
        public int id;
        public String name;
        public static float rateOfInterest;
        public Account4(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static Account4()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
    class Code5
    {
        public static void Main(string[] args)
        {
            Account4 a1 = new Account4(101, "Sonoo");
            Account4 a2 = new Account4(102, "Mahesh");
            a1.display();
            a2.display();

            Console.ReadKey(true);
        }
    }
}