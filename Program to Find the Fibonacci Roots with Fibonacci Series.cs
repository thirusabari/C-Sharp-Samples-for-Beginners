using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b=1,i,A;
            int sum = 0, n;
            Console.WriteLine("Program to Find the Fibonacci Roots");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the N value of the fibonacci series");
            n = Convert.ToInt32(Console.ReadLine());
            A = a;
            Console.WriteLine("The Fibonacci series of {0} is", n);
            Console.WriteLine("\n\n");
            for (i = 0; i <= n+1; i++)
            {
                
                sum = A + b;
                A = b;
                b = sum;
                if (sum >= n + 1)
                {
                    Console.Write("{0} {1} ", n,sum);
                    break;
                }
            }
            Console.ReadLine();


        }
    }
}
