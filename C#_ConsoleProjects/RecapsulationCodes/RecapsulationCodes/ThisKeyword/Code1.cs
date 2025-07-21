using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.ThisKeyword
{
    class Demo
    {
       int age;
       string name;

       public Demo(int age, string name)
       {
            this.age = age;
            this.name = name; 
       }

       public void Show()
       {
           Console.WriteLine();
           Console.WriteLine("Your age is: " + age.ToString());
           Console.WriteLine("Your name is: " + name);
       }
    }


    class Code1
    {
        static void Main(string[] args)
        {
            int _age;
            string _name;

            Console.Write("Enter your age: ");
            _age=Int32.Parse(Console.ReadLine());

            Console.Write("Enter your name: ");
            _name=Console.ReadLine();

            Demo obj = new Demo(_age, _name);
            obj.Show();
            Console.WriteLine();
            Console.WriteLine("Please any key to continue...!");
            Console.ReadKey(true);
        }
    }
}