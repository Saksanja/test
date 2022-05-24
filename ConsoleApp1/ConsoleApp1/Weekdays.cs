using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Weekdays
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THRUSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("INVALID");
                    break;

            }
        }
     }
}
