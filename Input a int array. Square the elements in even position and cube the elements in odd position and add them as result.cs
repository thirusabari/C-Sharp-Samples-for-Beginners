using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication113
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum=0, N;
            Console.WriteLine("Enter the Maximum Length of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + a[i] * a[i];
                }
                else
                {
                    sum = sum + a[i] * a[i] * a[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum value is={0}", sum);
            Console.ReadLine();

        }
    }
}
