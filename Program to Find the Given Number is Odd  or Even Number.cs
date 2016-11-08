using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the given number is odd or even");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("The Given number is an Even Number={0}", num);
            }
            else
            {
                Console.WriteLine("The given number is an Odd Number={0}", num);
            }
            Console.ReadLine();
        }
    }
}
