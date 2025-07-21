using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes.Encapsulation_DataHiding
{
    class Employee
    {
        private int empId;
        private string empName;
    }

    class DataHidingExp
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
		    //emp1.empName = "abc";

		    Employee emp2 = new Employee();
		    //emp2.empName = "efg";

		    //Console.WriteLine("Value of Object-1: " + emp1.empName);
		    //Console.WriteLine("Value of Object-2: " + emp2.empName);
        }
    }
}
