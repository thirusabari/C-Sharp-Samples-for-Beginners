using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Check whether the given string is balanced or unbalanced string:");
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            char[] b = input.ToCharArray();
            int i, count=0,count1=0, L;
            L = b.Length;
            for (i = 0; i < L; i++)
            {
                if (b[i] == '[')
                {
                    count++;
                }
                if (b[i] == ']')
                {
                    count1++;
                }
                
            }
            if (count1==count)
            {
                Console.WriteLine("The Given string is an Balanced string:={0}",input);
            }
            else
            {
                Console.WriteLine("The given string is an UNBalanced string:={0}",input);
            }
            Console.ReadLine();
        }
    }
}
