using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            int a, b, c, d;
            for(int i=1;i<=n;i++)
            {
                a = i % 10;
                b = i / 10;
                c = b % 10;
                d = b / 10;
                sum = (a * a * a) + (c * c * c) + (d * d * d);
                if (sum == i)
                {
                    Console.WriteLine("The Given number {0} is an Armstrong Number={1}", i, sum);
                }
                 
            }
            Console.ReadKey();
        }
    }

}