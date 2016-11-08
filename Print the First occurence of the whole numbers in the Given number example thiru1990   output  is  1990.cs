using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the first occurence of whole numbers in the given string");
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            int i, j,L;
            L = s.Length;
            char[] a = s.ToCharArray(0,L);
            for (i = 0; i < L; i++)
            {
                if ((char)a[i]>=48&&(char)a[i]<=57)
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
