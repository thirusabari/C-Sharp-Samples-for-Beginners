using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication174
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum67 Program from coding bat.com");
            Console.WriteLine("\n");
            int N, i, sum=0, count = 0;
            Console.WriteLine("enter the maximum range of the array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("\n");
            Console.WriteLine("ENter the values");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                if (a[i] == 6 || a[i] == 7)
                {
                    count++;
                    continue;
                }
                if (count == 1)
                {
                    continue;
                }
                else
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(sum);
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
