using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N, j, t;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Array Containing the following Values:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("The Array Sorting in Descending Order");
            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] > a[j])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;

                    }
                }

            }
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();

        }
    }
}
