using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArrayMultiplication
    {
        public static void Main()
        {

            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            

            //Input from arr1
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for arr1[" + row + "," + col + "]: ");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Input from arr2
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for arr2[" + row + "," + col + "]: ");
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Output
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write((arr1[row, col] *arr2[row, col]) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
