using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (a >= b)
            {
                a = a - b;
                i++;
            }
            Console.WriteLine("Quotient={0} and Remainder={1}", i, a);
            Console.ReadLine();
            
        }
    }
}
