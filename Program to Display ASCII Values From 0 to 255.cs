using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Print all ASCII Values from 0 to 255");
            int i = 0,n;
            Console.WriteLine("Enter the Maximum Limit");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                Console.Write("{0} ",(char)i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
