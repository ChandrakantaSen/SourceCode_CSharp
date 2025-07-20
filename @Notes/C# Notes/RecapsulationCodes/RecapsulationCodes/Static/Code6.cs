using System;

namespace RecapsulationCodes.Static
{
    public struct RectangleCode6
    {
        public int width, height;

    }
    public class Code6
    {
        public static void Main()
        {
            RectangleCode6 r = new RectangleCode6();
            r.width = 4;
            r.height = 5;
            Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));

            Console.ReadKey(true);
        }
    }
}