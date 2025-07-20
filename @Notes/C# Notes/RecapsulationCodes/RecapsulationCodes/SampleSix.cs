using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class Rectangle
    {
        public int length, breadth;

        public void getData()
        {
            int num1, num2;

            Console.Write("Enter number1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number2: ");
            num2 = int.Parse(Console.ReadLine());

            calData(num1, num2);
        }

        public void calData(int x, int y)
        {
            int result;
            length = x;
            breadth = y;

            result = rectArea();
            Console.WriteLine();
            Console.Write("Required result is: " + result);
        }

        public int rectArea()
        {
            int area = (length * breadth);
            return area;
        }
    }
    
    class SampleSix
    {
        public static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();

            obj.getData();

            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}
