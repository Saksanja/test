using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vote
    {
        static void Main(string[] args)
        {
            int age = 60;
            if (age >= 18 && age < 60)
            {
                Console.WriteLine(" This Person is ELIGIBLE to vote");
            }
            else if (age<18)
            {
                Console.WriteLine(" This Person is NOT ELIGIBLE to vote");
            }
            if (age >= 60)
            {
                Console.WriteLine(" This Person is ELIGIBLE to vote and is a SENIOR CITIZEN");
            }
        }
    }
}
