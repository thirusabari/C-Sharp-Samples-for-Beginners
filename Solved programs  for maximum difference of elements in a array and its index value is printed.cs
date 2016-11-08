using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication77
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j=0, N, count = 0,d=0,max=0;
            Console.WriteLine("Enter the Maximum Range of the array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] D = new int[N];
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    D[d] = a[i] - a[i + 1];
                    d++;
                    count++;
                }
                else
                {
                    D[d] = a[i + 1] - a[i];
                    d++;
                    count++;
                }
            }
            for (d = 0; d <= count; d++)
            {
                for (i = 0; i < count - 1; i++)
                {
                    if (D[i] > max)
                    {
                        max = D[i];
                        j++;


                    }
                }
            }
            for (i = 0; i < N; i++)
            {
                if (i == j)
                {
                    Console.WriteLine("The index value={0} and the value is={1}", i, a[i]); 
                }
            }
            Console.ReadLine();

        }
    }
}
