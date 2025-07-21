/* Program 18: Program on a Multi-Class (Pg: 343, Ques: 3) */

using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Sample
    {
        String str;
        int hr, rt;
        double wgs;

        public void get()
        {
            Console.Write("Enter the store name: ");
            str = Console.ReadLine();

            Console.Write("Enter the number of hours: ");
            hr = int.Parse(Console.ReadLine());

            Console.Write("Enter the store rate of wages: ");
            rt = int.Parse(Console.ReadLine());
        }
        public void calwage()
        {
            if (hr <= 40)
            {
                wgs = rt * hr;
            }
            else if (hr > 40 && hr <= 60)
            {
                wgs = 40 * 1 * rt + (hr - 40) * 1.5 * rt;
            }
            else if (hr > 60 && hr <= 80)
            {
                wgs = 40 * 1 * rt + 20 * 1.5 * rt + (hr - 60) * 2 * rt;
            }
            else
            {
                Console.WriteLine("Out of range...!");
            }
        }
        public void display()
        {
            Console.WriteLine("Store Name: "+str);
            Console.WriteLine("Number of Hours: "+hr);
            Console.WriteLine("Store rate of Wages: "+rt);
            Console.ReadKey();
        }
    }

    class Code18
    {
        public static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.get();
            obj.calwage();
            Console.WriteLine();
            Console.WriteLine();
            obj.display();
        }
    }
}