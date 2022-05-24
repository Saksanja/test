using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StarPattern3
    {
        public static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                continue;
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
