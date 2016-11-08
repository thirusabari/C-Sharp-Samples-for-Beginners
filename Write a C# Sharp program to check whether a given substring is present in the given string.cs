using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String15
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            bool m;
            Console.WriteLine("Program to check the substring existing in given string or not");
            Console.WriteLine("Enter the Existing String");
            a = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Substring");
            b = Console.ReadLine();
            m = a.Contains(b);
            if (m)
                Console.WriteLine("The Substring  in Existing string");
            else
                Console.WriteLine("The Substring not exist in Given string");
            Console.ReadLine();


        }
    }
}
