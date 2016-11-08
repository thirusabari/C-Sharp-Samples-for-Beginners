using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the L.C.M of 2 numbers:");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            int x, y,v=0;
            x = a;
            y = b;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                    v = (x * y) / a;
                }
                else
                {
                    b = b - a;
                    v = (x * y) / b;
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("The Lcm of 2 numbers is={0}", v);
            Console.ReadLine();
        }
    }
}
