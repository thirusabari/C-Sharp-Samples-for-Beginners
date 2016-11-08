using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String27
{
    class Program
    {
        static void Main(string[] args)
        {
            string a; 
            char[] b; string c = string.Empty;
            int i, L;
            Console.WriteLine("Program to Find the String is Palindrome or not");
            Console.WriteLine("ENter the input String");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0,L);
            for (i = L-1; i >=0; i--)
            {
                c = c + b[i];
            }
            Console.WriteLine("\n");
            if (a == c)
            {
                Console.WriteLine("The given string  is an Palindrome");
                Console.WriteLine("{0}={1}", a, c);
            }
            else
            {
                Console.WriteLine("THe given string is not an palindrme");
                Console.WriteLine("{0}={1}", a, c);
            }
            
            Console.ReadLine();
        }
    }
}
