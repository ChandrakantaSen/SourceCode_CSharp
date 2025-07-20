using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class Sample
    {
        public string param1, param2;
        //parameterized constructor
        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;
        }
        public Sample(Sample obj)     // Copy Constructor
        {
            param1 = obj.param1;
            param2 = obj.param2;
        }
    }
    
    class SampleTen
    {
        static void Main(string[] args)
        {
            // Create instance to class Sample
            Sample objz = new Sample("Parameter-1", "Parameter-2");
            // Here obj details will copied to obj1
            Sample obj1=new Sample(objz);

            Console.WriteLine(obj1.param1 +" to " + obj1.param2);
            Console.ReadLine();
        }
    }
}
