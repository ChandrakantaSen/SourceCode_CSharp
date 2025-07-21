using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class TestSwitchClass
    {
        public void add()
        {
            int num1, num2;
            double sum = 0;

            Console.Write("Enter the number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number 2: ");
            num2 = int.Parse(Console.ReadLine());

            sum = (num1 + num2);
            Console.WriteLine("Sum of 2 numbers: " + sum);
        }

        public void sumOFnos()
        {
            int num;
            double sum = 0;

            Console.Write("Enter the range: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the numbers: " + sum);
        }

        public void sumOFevennos()
        {
            int num;
            double sum = 0;

            Console.Write("Enter the range: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the even numbers: " + sum);
        }

        public void sumOFfactorial()
        {
            int num, fact = 1;
            double sum = 0;
            
            Console.Write("Enter the range: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the factorials: " + sum);
        }

        public void fibogen()
        {
            int f0 = 0, f1 = 1, f2;
            int range;

            Console.Write("Enter the range: ");
            range = int.Parse(Console.ReadLine());

            Console.Write(f0 + " " + f1);
            for (int i = 2; i <= range; i++)
            {
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;
                Console.Write(" " + f2);
            }
        }

        public void sumDigit()
        {
            int num;
            int d, sum = 0;

            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            
            while (num != 0)
            {
                d = num % 10;
                sum = sum + d;
                num = num / 10;
            }
            Console.WriteLine("Sum of digit: " + sum);
        }

        public void revDigit()
        {
            int num,cpynum;
            int d, rev = 0;

            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            cpynum = num;
            while (num != 0)
            {
                d = num % 10;
                rev = rev * 10 + d;
                num = num / 10;
            }
            Console.WriteLine("Reverse of digit: " + rev);
            if (cpynum == rev)
            {
                Console.WriteLine("It is a Palindrome Number...!");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome Number...!");         
            }
        }

        public void swapping()
        {
            int num1, num2, swap;

            Console.Write("Enter the number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number 2: ");
            num2 = int.Parse(Console.ReadLine());

            swap = num1;
            num1 = num2;
            num2 = swap;

            Console.WriteLine("After swapping num 1: " + num1);
            Console.WriteLine("After swapping num 2: " + num2);
        }

        public void leapYear()
        {
            int leapYear;

            Console.Write("Enter the year: ");
            leapYear = int.Parse(Console.ReadLine());

            if (leapYear % 400 == 0)
            {
                if (leapYear % 100 == 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not Leap Year");
                }
            }
            else
            {
                if (leapYear % 4 == 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not Leap Year");
                }
            }
        }

        public void armstrongCheck()
        {
            int num;
            int sum = 0, kount = 0;

            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            int temp = num;

            while(num != 0)
            {
                int d = num % 10;
                kount++;
                num = num / 10;
            }
            num = temp;
            while(temp != 0)
            {
                int d = temp % 10;
                int power = (int)Math.Pow(d, kount);
                sum = sum + power;
                temp = temp / 10;
            }

            if (num == sum)
            {
                Console.WriteLine("It is an Armstrong number");
            }
            else
            {
                Console.WriteLine("It is not an Armstrong number");
            }
        }

        public void supersix()
        {
            int num, c = 0, d;

            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                d = num % 10;
                if (d == 6)
                {
                    c++;
                }
                num = num / 10;
            }
            if (c >= 2)
            {
                Console.WriteLine("It is a supersix number");
            }
            else
            {
                Console.WriteLine("It is not a supersix number");
            }
        }

        public void frequencyNos()
        {
            int num, c = 0;

            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                int t = num;
                while (t > 0)
                {
                    int d = t % 10;
                    if (d == i)
                    {
                        c++;
                    }
                    t = t / 10;
                }
                if (c != 0)
                {
                    Console.WriteLine("Frequency of " + i + " is: " + c);
                }
                c = 0;
            }
        }

        public void primeCheckSeries()
        {
            int range, c = 0, i;

            Console.Write("Enter the range: ");
            range = int.Parse(Console.ReadLine());

            Console.WriteLine("Required Prime Series is -- ");
            for (int x = 1; x <= range; x++)
            {
                for (i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        c++;
                    }
                }

                if (c == 2)
                {
                    Console.Write(x + " ");
                }
                c = 0;
            }
        }
    }
    class SampleFour
    {
        public static void Main(string[] args)
        {
            Start:
            int index;
            TestSwitchClass switchobj = new TestSwitchClass();

            Console.WriteLine("-------------- Switch Example ----------------");
            Console.WriteLine("1. Sum of two numbers");
            Console.WriteLine("2. Sum of numbers");
            Console.WriteLine("3. Sum of even numbers");
            Console.WriteLine("4. Sum of factorials");
            Console.WriteLine("5. Even Fibonacci Series");
            Console.WriteLine("6. Sum of Digit of a number");
            Console.WriteLine("7. Reverse of a number");
            Console.WriteLine("8. Swapping of two numbers");
            Console.WriteLine("9. Check LeapYear or not");
            Console.WriteLine("10. Check Armstrong number");
            Console.WriteLine("11. Check Supersix number");
            Console.WriteLine("12. Find frequency of number");
            Console.WriteLine("13. Prime Check Series");
            Console.WriteLine("0. Exit from application");

            while(true)
            {
                Console.WriteLine();
                Console.Write("Enter the choice: ");
                index = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (index)
                {
                    case 0: Environment.Exit(0);                   break;
                    case 1: switchobj.add();                       break;
                    case 2: switchobj.sumOFnos();                  break;
                    case 3: switchobj.sumOFevennos();              break;
                    case 4: switchobj.sumOFfactorial();            break;
                    case 5: switchobj.fibogen();                   break;
                    case 6: switchobj.sumDigit();                  break;
                    case 7: switchobj.revDigit();                  break;
                    case 8: switchobj.swapping();                  break;
                    case 9: switchobj.leapYear();                  break;
                    case 10: switchobj.armstrongCheck();           break;
                    case 11: switchobj.supersix();                 break;
                    case 12: switchobj.frequencyNos();             break;
                    case 13: switchobj.primeCheckSeries();         break;
                    default: Console.WriteLine("Wrong input...!"); break;
                }
                Console.WriteLine();
                Console.WriteLine("Please any key to continue...!");
                Console.ReadKey(true);
                Console.Clear();
                goto Start;
            }
        }
    }
}