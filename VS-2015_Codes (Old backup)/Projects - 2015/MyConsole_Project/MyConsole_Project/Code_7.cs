using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_Project
{
    class BookLibrary
    {
        public int bId, num;
        public string bName, bAuthName;

        public void declaration()
        {
            Console.Write("Enter the number of books: ");
            num = int.Parse(Console.ReadLine());
            string[,] BookArr = new string[num, num];
        }

        public void addBooks()
        {
            declaration();

            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    Console.Write("Enter Book Name: ");
                    bName = Console.ReadLine();

                    Console.Write("Enter Book Author: ");
                    bAuthName = Console.ReadLine();
                }
            }
        }

        public void displayBooks()
        {
            Console.WriteLine("--- Book Details ---");
            Console.WriteLine(bId + " " + bName + " " + bAuthName);
        }
    }

    class Code_7
    {
        public static void Main(string []args)
        {
            int ch;
            // object created
            BookLibrary obj = new BookLibrary();

            while (true)
            {
                Console.WriteLine("**** Menu Driven Program ****");
                Console.WriteLine("Press 1: Add Books");
                Console.WriteLine("Press 2: Delete Books");
                Console.WriteLine("Press 3: Display Books");

                Console.Write("Enter your Choice: ");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        obj.addBooks();
           break;
                }
            }
            

            obj.displayBooks();
            Console.ReadKey();
        }
    }
}
