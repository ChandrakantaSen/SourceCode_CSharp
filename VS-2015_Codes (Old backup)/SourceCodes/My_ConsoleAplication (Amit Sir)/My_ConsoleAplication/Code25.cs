/*Programme 26: Problem on Inheritence with protected variable using Function Overriding*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_ConsoleAplication
{
    class Emp
    { 
        private string emp_no, emp_name;
        protected double bsal, pf, gsal;
        
        public virtual void get()
        {
            Console.WriteLine("Enter the emp no: ");
            emp_no = Console.ReadLine();

            Console.WriteLine("Enter the emp name: ");
            emp_name = Console.ReadLine();

            Console.WriteLine("Enter the basic salary: ");
            bsal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the provident fund: ");
            pf = double.Parse(Console.ReadLine());
        }

        public virtual void show()
        {
            Console.WriteLine();
            Console.WriteLine("``````````````Employee Details````````````````");
            Console.WriteLine("the emp no: "+emp_no);
            Console.WriteLine("the emp name: "+emp_name);
            Console.WriteLine("the basic salary: "+bsal);
            Console.WriteLine("the provident fund: " + pf);
        }
    }

    class Sales : Emp
    {
        public double incntive, comm, allowncs;

        public override void get()
        {
            base.get();
            Console.WriteLine("Enter the incentive: ");
            incntive = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Commission: ");
            comm = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the allowences: ");
            allowncs = double.Parse(Console.ReadLine());
        }

        public void cal_sal()
        {
           gsal = (bsal + incntive + comm + allowncs) - pf;
        }

        //public void show()
        //{
        //    base.show();
        //    Console.WriteLine("Gross Salary is: "+gsal);
        
        //}

        public override void show()
        {
            base.show();
            Console.WriteLine("Gross Salary is: " + gsal);
        }
    }
    class Code25
    {
        public static void Main(string[] args)
        {
            Sales obj = new Sales();

            obj.get();
            obj.cal_sal();
            obj.show();

            Console.ReadLine();
        }
    }
}
