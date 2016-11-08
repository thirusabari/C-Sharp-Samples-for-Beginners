using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N,sum=0;
            Console.WriteLine("Sum of N even numbers");
            Console.WriteLine("Enter the Maximum Range");
            N = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                Console.Write("{0}   ", 2 * i);
                sum = sum + 2 * i;

            }
            Console.WriteLine("The sum of {0} even Numbers is={1}", N, sum);
            Console.ReadLine();
        }
    }
}
