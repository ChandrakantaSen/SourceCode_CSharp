using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Product1
    {
        public int price;

        public void get()
        {
            Console.WriteLine("Enter the product price: ");
            price = int.Parse(Console.ReadLine());
        }

        /*public static int operator --(Product1 reff)
        {
            reff.price = reff.price - ((reff.price * 5) / 100);

            return reff.price;
        }
        public static int operator ++(Product1 reff)
        {
            return 0;
        }*/

        public void show()
        {
            Console.WriteLine("Product price: "+price);
            Console.ReadLine();
        }
    }

    class Code26
    {
        public static void Main(string[]args)
        {
            Product1 obj = new Product1();

            obj.get();
            //--obj;
            obj.show();
        }
    }
}
