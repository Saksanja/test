using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SecondHighestNoArray
    {
        public static void Main(string[] args)
        {
            int M1, M2;
            int[] arr = { 12, 20, 8, 35, 1, 90, 74 };
            Console.Write("Array Elements are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            M1 = M2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > M1)
                {
                    M2 = M1;
                    M1 = arr[i];
                }
                else if (arr[i] > M2)
                {
                    M2 = arr[i];
                }
                else if (arr[i] < M2 && M1 == M2)
                {
                    M2 = arr[i];
                }
            }
            Console.WriteLine("\nSecond Highest Number is " + M2);
            Console.ReadLine();
        }
    }
}
