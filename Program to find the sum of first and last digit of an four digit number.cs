using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the first and last digit sum of given number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, remainder,N;
            if (num > 0)
            {
                remainder = num % 10;
                N = num / 1000;
                sum = sum + remainder + N;
            }
            Console.WriteLine("The sum values is={0}",sum);
            Console.ReadLine();
        }
    }
}
