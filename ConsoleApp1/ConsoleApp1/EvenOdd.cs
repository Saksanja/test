using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EvenOdd
    {
         static void Main(string[] args)
        {
            int n = 20;
            if (n%2==0)
            {
                Console.WriteLine(n+" is an EVEN Number");
            }
            else
            {
                Console.WriteLine(n + " is an ODD Number");
            }
        }
    }
}
