/* Program 15: Programe for multi-classes*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cc = System.Console;

namespace My_ConsoleAplication
{
    class student
    {
        private int roll;
        private string name;

        public void get()
        {
            cc.WriteLine("Enter the roll");
            roll = int.Parse(cc.ReadLine());

            cc.WriteLine("Enter the name");
            name = cc.ReadLine();
        }

        public void show()
        {
            cc.WriteLine("Student Roll is: " + roll);
            cc.WriteLine("Student Name is: " + name);
            cc.ReadLine();
        }
    }
    class Code15
    {
        public static void Main(string[] args)
        {
            student obj = new student();
            obj.get();
            obj.show();
        }
    }
}
