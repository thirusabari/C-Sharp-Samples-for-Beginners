using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Match two strings and print the result");
            Console.WriteLine("Entert the first string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the second string:");
            string s2 = Console.ReadLine();
            Console.WriteLine("\n");
            int i, j, L1, L2;
            L1 = s1.Length;
            L2 = s2.Length;
            Console.Write("The Filtered Characters are:");
            Console.WriteLine("\n");
            for (i = 0; i < L2; i++)
            {
                for (j = 0; j < L1; j++)
                {
                    if (s2[i] == s1[j])
                    {
                        Console.Write("{0}", s1[j]);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
