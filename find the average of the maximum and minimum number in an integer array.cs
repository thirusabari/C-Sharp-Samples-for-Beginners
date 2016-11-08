using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication126
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N,max=0,min=1000,Average=0;
            Console.WriteLine("Enter the Maximum Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (i = 0; i < N; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Average = (max + min) / 2;
            Console.WriteLine("\n");
            Console.WriteLine("The Maximum Value in the array={0}", max);
            Console.WriteLine("\n");
            Console.WriteLine("The Minimum Value in the array={0}", min);
            Console.WriteLine("\n");
            Console.WriteLine("The Average value={0}", Average);
            Console.ReadLine();

        }
    }
}
