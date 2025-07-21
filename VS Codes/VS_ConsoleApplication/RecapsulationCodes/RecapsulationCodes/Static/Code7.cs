using System;

namespace RecapsulationCodes.Static
{
    public struct RectangleCode7
    {
        public int width, height;

        public RectangleCode7(int w, int h)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangleCode7()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }
    public class Code7
    {
        public static void Main()
        {
            RectangleCode7 r = new RectangleCode7(5, 6);
            r.areaOfRectangleCode7();

            Console.ReadKey(true);
        }
    }
}