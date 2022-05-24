using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.Write("CHOICES 1.Addition,2.Subtraction,3.Multi,4.Division ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Choice is " + choice);

            if (choice > 4)
            {
                Console.WriteLine("INVALID select other choice");
            }
            else
            {
                Console.Write("Enter Number 1 : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number 2 : ");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("ADDITION IS " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("SUBTRACTION IS " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("MULTIPLICATION IS " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("DIVISION IS " + (a / b));
                        break;
                }
            }
        }
    }
}
