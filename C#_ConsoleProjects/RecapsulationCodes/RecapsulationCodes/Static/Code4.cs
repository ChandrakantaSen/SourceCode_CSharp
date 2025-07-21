using System;

namespace RecapsulationCodes.Static
{
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int n) 
        { 
            return n * n * n; 
        }
    }
 
    class Code4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is: " + MyMath.PI);
            Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));

            Console.ReadKey(true);
        }
    }
}