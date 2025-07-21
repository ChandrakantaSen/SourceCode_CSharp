/* Example: Base Class and Child Class */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Inheritence
{
    class Square
    {
        protected int side;
        public Square(int s)
        {
            side = s;
        }
        public int GetArea()
        {
            return side * side;
        }
        public void Display()
        {
            Console.WriteLine("Side is: {0}", side);
            Console.WriteLine("The area is: {0}", GetArea());
        }
    }

    class Screen : Square
    {
        private int price;
        public Screen(int s): base(s)
        {
        }
        public int GetPrice()
        {
            int price;
            price = GetArea() * 10;
            return price;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("The price is: {0}", GetPrice());
        }
    }

    class Code1
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            Screen s = new Screen(num);
            s.Display();
            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
