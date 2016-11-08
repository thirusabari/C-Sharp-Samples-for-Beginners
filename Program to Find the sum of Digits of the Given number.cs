using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the sum of digits of an number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, remainder,N;
            N = num;
            while (num != 0)
            {
                remainder = num % 10;
                sum = sum + remainder;
                num = num / 10;
            }
            Console.WriteLine("The sum of given number is {0}={1}", N, sum);
            Console.ReadLine();
        }
       
    }
}
