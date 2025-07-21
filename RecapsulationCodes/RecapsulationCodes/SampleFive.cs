using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapsulationCodes
{
    class TestArraySwitchClass
    {
        public void ArrayTraversing()
        {
            int size;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int []arrTvr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < arrTvr.Length; i++)
            {
                arrTvr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array elements are: ");
            for (int i = 0; i < arrTvr.Length; i++)
            {
                Console.WriteLine(arrTvr[i] + " ");
            }
        }

        public void MaxMinArrayElement()
        {
            int size,MAX,MIN,MAXloc=0,MINloc=0;

            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arrTvr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < arrTvr.Length; i++)
            {
                arrTvr[i] = int.Parse(Console.ReadLine());
            }

            MAX = arrTvr[0];
            MIN = arrTvr[0];
            for (int i = 0; i < arrTvr.Length; i++)
            {
                if (arrTvr[i] > MAX)
                {
                    MAX = arrTvr[i];
                    MAXloc = (i+1);
                }
                if (arrTvr[i] < MIN)
                {
                    MIN = arrTvr[i];
                    MINloc = (i + 1);
                }
            }
            Console.WriteLine("Max element of the array is: " + MAX + " at the position of: " + MAXloc);
            Console.WriteLine("Min element of the array is: " + MIN + " at the position of: " + MINloc);
        }

        public void ReverseArray()
        {
            int size, start, end;

            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arrTvr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < arrTvr.Length; i++)
            {
                arrTvr[i] = int.Parse(Console.ReadLine());
            }

            start = 0;
            end = (size - 1);
            int temp;
            while (start < end)
            {
                temp = arrTvr[start];
                arrTvr[start] = arrTvr[end];
                arrTvr[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine("-- Reverse Array is --");
            for (int i = 0; i < arrTvr.Length; i++)
            {
                Console.Write(arrTvr[i] + " ");
            }
            Console.WriteLine();
        }

        public void CopyArray()
        {
            int size;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arrTvr = new int[size];
            int[] cpyArr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < arrTvr.Length; i++)
            {
                arrTvr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrTvr.Length; i++)
            {
                cpyArr[i] = arrTvr[i];
            }

            Console.WriteLine("Array elemets are after copy --");
            for (int i = 0; i < cpyArr.Length; i++)
            {
                Console.Write(" " + cpyArr[i]);
            }
        }

        public void SwapArray()
        {
            int size;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arrA = new int[size];
            int[] arrB = new int[size];
            int[] arrC = new int[size];

            Console.WriteLine("Enter the first array elements: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the second array elements: ");
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrC.Length; i++)
            {
                arrC[i] = arrA[i];
                arrA[i] = arrB[i];
                arrB[i] = arrC[i];
            }

            Console.WriteLine("Values of first array after swapping");
            for (int i = 0; i < arrA.Length; i++) 
            {
                Console.Write(arrA[i] + " ");
            }

            Console.WriteLine();
            
            Console.WriteLine("Values of second array after swapping");
            for (int i = 0; i < arrB.Length; i++)
            {
                Console.Write(arrB[i] + " ");
            }
        }

        public void MergeArray()
        {
            int size,i;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arrA = new int[size];
            int[] arrB = new int[size];
            int[] arrC = new int[size*2];

            Console.WriteLine("Enter the first array elements: ");
            for (i = 0; i < arrA.Length; i++)
            {
                arrA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the second array elements: ");
            for (i = 0; i < arrB.Length; i++)
            {
                arrB[i] = int.Parse(Console.ReadLine());
            }

            int a = 0;
            int b = 0;
            int c = 0;

            while (a < size && b < size)
            {
                if (arrA[a] <= arrB[b])
                {
                    arrC[c] = arrA[a];
                    a++; 
                    c++;
                }
                else
                {
                    arrC[c] = arrB[b];
                    c++;
                    b++;
                }
            }

            while (a < size)
            { 
                arrC[c] = arrA[a];
                a++;
                c++;
            }

            while (b < size)
            {
                arrC[c] = arrB[b];
                c++;
                b++;
            }

            Console.WriteLine();
            Console.WriteLine("Resultant Array is: ");
            for (c = 0; c < arrC.Length; c++)
            {
                Console.Write(arrC[c] + " ");   
            }
        }

        public void SumOfArrayElements()
        {
            int size,i;
            double sum = 0;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the first array elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine();
            Console.Write("Sum of array elements: " + sum);
        }

        public void PrintNegativeElements()
        {
            int size, i;
            
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the first array elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Negative array elements are --");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write(" " + arr[i]);
                }
            }
        }

        public void SecondLargestElements()
        {
            int size, i, j, max = 0;

            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the first array elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    { 
                        max = arr[j];
                        arr[j] = arr[i];
                        arr[i] = max;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Second largest number: " + arr[1]);
        }

        public void FrequencyOfElements()
        {
            int i, j, Count = 0;
            int size, num;

            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                
                for (j = 0; j <= 9; j++)
                {
                    Count = 0;
                    num = arr[i];
                    while (num != 0)
                    {
                        int d = num % 10;
                        if (d == j)
                        {
                            Count++;
                        }
                        num = num / 10;
                    }
                    if (Count != 0)
                    {
                        Console.WriteLine("Frequency of " + j + " is: " + Count);
                    }
                }
                
            }
        }

        public void DuplicateElements()
        {
            int size,i,j;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                for (j = (i+1); j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate Elements are: " + arr[i]);
                    } 
                }
            }
        }

        public void DistinctElements()
        {
            int size, i, j;
            Console.Write("Enter array range: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        break;
                    }
                }
               
                if (i == j)
                {
                  Console.WriteLine("Unique Elements are: " + arr[i]);
                }
            }
        }

        public void InsertElement()
        {
            int size, i;
            int n, position, value;
            
            Console.Write("Enter the size: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.Write("Enter the number of element: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("--- Array Elements are ---");
            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the location to be inserted: ");
            position = int.Parse(Console.ReadLine());

            Console.Write("Enter the element to be inserted: ");
            value = int.Parse(Console.ReadLine());

            for (i = (n - 1); i >= (position - 1); i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[position - 1] = value;

            Console.WriteLine("--- Resultant Array is ---");
            for (i = 0; i <= n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class SampleFive
    {
        public static void Main(string[] args)
        {
            Start:

            int index;
            TestArraySwitchClass ArraySwitchObj = new TestArraySwitchClass();

            Console.WriteLine("-------------- Switch Example ----------------");
            Console.WriteLine("1. Array Traversing");
            Console.WriteLine("2. MAX-MIN element in the array");
            Console.WriteLine("3. Reverse Array");
            Console.WriteLine("4. Copy Array");
            Console.WriteLine("5. Swap Array");
            Console.WriteLine("6. Merge Array");
            Console.WriteLine("7. Sum of Array Elements");
            Console.WriteLine("8. Print Negative Elements");
            Console.WriteLine("9. Second Largest Number");
            Console.WriteLine("10.Frequency of Elements");
            Console.WriteLine("11.Duplicate Elements in the array");
            Console.WriteLine("12.Distinct Elements in the array");
            Console.WriteLine("13.Insert Element at specific position");
            Console.WriteLine("0. Exit");

            while(true)
            {
                Console.WriteLine();
                Console.Write("Enter the choice: ");
                index = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (index)
                {
                    case 0: Environment.Exit(0);                        break;
                    case 1: ArraySwitchObj.ArrayTraversing();           break;
                    case 2: ArraySwitchObj.MaxMinArrayElement();        break;
                    case 3: ArraySwitchObj.ReverseArray();              break;
                    case 4: ArraySwitchObj.CopyArray();                 break;
                    case 5: ArraySwitchObj.SwapArray();                 break;
                    case 6: ArraySwitchObj.MergeArray();                break;
                    case 7: ArraySwitchObj.SumOfArrayElements();        break;
                    case 8: ArraySwitchObj.PrintNegativeElements();     break;
                    case 9: ArraySwitchObj.SecondLargestElements();     break;
                    case 10: ArraySwitchObj.FrequencyOfElements();      break;
                    case 11: ArraySwitchObj.DuplicateElements();        break;
                    case 12: ArraySwitchObj.DistinctElements();         break;
                    case 13: ArraySwitchObj.InsertElement();            break;
                    default: Console.WriteLine("Wrong input...!");      break;
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