using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amicable  Numbers");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number");
            Console.WriteLine("\n");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0,i=0,j=0,sum1=0;
            for (i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    sum = sum + i;
                }
            }
            for (j = 1; j < sum; j++)
            {
                if (sum % j == 0)
                {
                    sum1 = sum1 + j;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            if (N == sum1)
            {
                Console.WriteLine("The given numbers {0}  and {1} are amicable numbers ", N, sum);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
