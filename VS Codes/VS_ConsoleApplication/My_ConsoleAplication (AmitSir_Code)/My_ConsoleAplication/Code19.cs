/* Program 19: Example on function overloading */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Product
    {
        string pc;
        double price;

        public void get(string tpc, double tprice)
        {
            pc = tpc;
            price = tprice;
        }

        public void get(string tpc, double tprice, double tdisc)
        {
            pc = tpc;
            price = tprice - ((tprice * tdisc) / 100);
        }

        public void show()
        {
            Console.WriteLine("Product Code is: "+pc);
            Console.WriteLine("Product Price is: "+price);
        }
    }
    class Code19
    {
        public static void Main(string[] args)
        {
            int ch,p,d;
            string c;

            Product obj = new Product();
            
            Console.WriteLine("Enter the product code: ");
            c = Console.ReadLine();
            
            Console.WriteLine("Enter the product price: ");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the choice: ");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            { 
                case 1:
                    Console.WriteLine("``````````NORMAL CATAGORY```````````");
                    //obj.input();
                    obj.get(c,p);
                    obj.show();
                    break;
                case 2:
                    Console.WriteLine("``````````SPECIAL CATAGORY```````````");
                    //obj.input();
                    Console.WriteLine("Enter the product discount: ");
                    d = int.Parse(Console.ReadLine());
                    obj.get(c, p, d);
                    obj.show();
                    break;
                default:
                    Console.WriteLine("Wrong Choice...!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
