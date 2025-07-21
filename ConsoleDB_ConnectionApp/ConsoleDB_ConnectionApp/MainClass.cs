using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDB_ConnectionApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int index;
            DBConnect dbConObj = new DBConnect();

            Console.WriteLine("--- Contents ---");
            Console.WriteLine("0. Exit from the Application");
            Console.WriteLine("1. Establish Database Connection");
            Console.WriteLine("2. Create a new table in the database");
            Console.WriteLine("3. Insert data to the table");
            Console.WriteLine("4. View all data of the table");
            Console.WriteLine("5. View particular data of the table");
            Console.WriteLine("6. Delete data of the table");
            Console.WriteLine("7. Search particular data from the table");
            Console.WriteLine("8. Update particular data of the table");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter the choice: ");
                index = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (index)
                {
                    case 0: Environment.Exit(0); break;
                    case 1: dbConObj.getCon(); break;
                    case 2: dbConObj.crtTable(); break;
                    case 3: dbConObj.insrtDataTable(); break;
                    case 4: dbConObj.viewAllDataTable(); break;
                    case 5: dbConObj.viewDataTable(); break;
                    case 6: dbConObj.deleteDataTable(); break;
                    case 7: dbConObj.searchDataTable(); break;
                    case 8: dbConObj.updateDataTable(); break;
                    default: Console.WriteLine("Wrong input...!"); break;
                }
                Console.WriteLine("Please any key to continue...!");
                Console.ReadKey(true);
                //Console.Clear();
            }
        }
    }
}
