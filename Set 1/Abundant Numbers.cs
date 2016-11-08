using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abundant Number:");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number to be process");
            int M = Convert.ToInt32(Console.ReadLine());
            int i, n,sum=0;
            n = M;
            for (i = 1; i < n; i++)
            {
                if (M % i == 0)
                {
                    sum = sum + i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            if (sum > M)
            {
                Console.WriteLine("The Given Number is {0} an Abundant Number ={1}",M,sum);
            }
            else
            {
                Console.WriteLine("The Abundant Number is not an Abundant Number");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
