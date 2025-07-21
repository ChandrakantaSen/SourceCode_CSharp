/* Find the size of all datatypes using sizeOf operator */
using System;

namespace ConsoleApp
{
	class Sample1
	{
		int size1 = sizeof(int);
        int size2 = 0; 
        int size3= sizeof(decimal);
        int size4= sizeof(char);
        int size5= sizeof(bool);
        int size6= sizeof(byte);
        int size7= sizeof(Int16); 
        int size8 = sizeof(Int32);
        int size9 = sizeof(Int64);
		int size10 = sizeof(float);
		int size9 = sizeof(double);
		
		void check()
		{
			int SizeOf_Int = sizeof(a);
			Console.Write("\nSize of Integer is: " + SizeOf_Int);
		}
	}
	
	class Code7
	{
		public static void Main(string[] args)
		{
			Sample1 obj = new Sample1();
			obj.check();
		}
	}
}