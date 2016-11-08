using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program to Find that the Given Year is Leap Year or not");
            int Year = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0) && (Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine("The Given Year is an Leap Year={0}", Year);
            }
            else
            {
                Console.WriteLine("The Given Year is not an Leap Year={0}", Year);
            }
            Console.ReadLine();
        }
    }
}
