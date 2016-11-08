using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication185
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first string:");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter the second string:");
            string n2 = Console.ReadLine();
            Console.WriteLine("\n");
            long num1 = (long)Convert.ToInt64(n1);
            long num2 = (long)Convert.ToInt64(n2);
            long mul;
            mul = num1 * num2;
            Console.WriteLine(mul.ToString());
            Console.WriteLine("\n");
            Console.ReadLine();
           
        }
    }
}
