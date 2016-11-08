using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, n,N, sum = 0, remainder;
            Console.WriteLine("Program to Find the Armsstrong Numbers between 1  to 500");
            Console.WriteLine("Enter the Maximum N Value:");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                N = i;
                sum = 0;
                   while (N != 0)
                    {
                        remainder =N % 10;
                        sum = sum + remainder * remainder * remainder;
                        N = N / 10;
                    }
                    if (sum == i)
                    {
                        Console.WriteLine("The Given Number {0} is an Armstrong Number={1}", i, sum);
                    }
                    i++;
            }
            Console.ReadLine();

        }
    }
}
