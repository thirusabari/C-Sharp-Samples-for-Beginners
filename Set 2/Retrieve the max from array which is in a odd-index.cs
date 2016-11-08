using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication131
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N,max=0;
            Console.WriteLine("Enter the Maximum Range of the array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i < N; i = i + 2)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The Maximum Values of odd index position in the given array is={0}", max);
            Console.ReadLine();
        }
    }
}
