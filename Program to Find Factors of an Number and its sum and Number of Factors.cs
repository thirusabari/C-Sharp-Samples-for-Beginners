using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the factors of given number and its sum,how many number of factors are:");
            int i, sum=0, n,count=0;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factors and its sum");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("{0} ", i);
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum of Factors={0}", sum);
            Console.WriteLine("the number of factors are={0}", count);
            Console.ReadLine();
        }
    }
}
