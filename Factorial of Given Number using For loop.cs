using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1, i;
            Console.WriteLine("The Factorial of Given Number using for loop");
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The Factorial of Given number {0} is={1}", n, fact);
            Console.ReadLine();
        }
    }
}
