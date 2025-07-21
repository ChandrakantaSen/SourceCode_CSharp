using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class TestClass
    {
        public void fun()
        {
            Console.WriteLine("Inside of fun()...");
            Console.ReadKey(true);
        }
    }
    
    class SampleThree
    {
        public static void Main()
        {
            TestClass obj = new TestClass();
            obj.fun();
        }
    }
}
