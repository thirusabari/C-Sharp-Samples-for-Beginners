using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication94
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum = 0,n,i;
            Console.WriteLine("The sum of n numbers of fibonacci series");
            Console.WriteLine("Enter the n number:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum = a + b;
                Console.Write("{0} ", a);
                a = b;
                b = sum;
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum of  {0} of series is={1}", n, sum);
            Console.ReadLine();
        }
    }
}
