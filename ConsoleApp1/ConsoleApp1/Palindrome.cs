using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            string s1 = ("MADAM");
            string rev = string.Empty;
            int len = s1.Length - 1;
            while (len >= 0) 
            {
                rev = rev + s1[len];
                len--;
            }
            if (s1 == rev)
            {
                Console.WriteLine(s1 +" String is PALINDROME");
            }
            else
            {
                Console.WriteLine(s1 +" String is NOT PALINDROME");
            }
        }
    }
}
