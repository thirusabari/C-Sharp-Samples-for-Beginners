using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Input Values to the Array");
            int[] a = new int[N];
            int[] even = new int[N];
            int[] odd = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Input Elements are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Finding of Even and odd Values in the given array and store them as separate arrays");
            for (i = 0; i < N; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[i] = a[i];
                }
                else
                {
                    odd[i] = a[i];
                }
            }
            Console.WriteLine("The even values are:");
            for (i = 0; i < even.Length; i++)
            {
                if (even[i] == 0)
                {
                    Console.Write("");
                }
                else
                Console.WriteLine(even[i]);
            }
            Console.WriteLine("The odd values are");
            for (i = 0; i < odd.Length; i++)
            {
                if (odd[i] == 0)
                {
                    Console.Write("");
                }
                else
                Console.WriteLine(odd[i]);
            }
            Console.ReadLine();
        }
    }
}
