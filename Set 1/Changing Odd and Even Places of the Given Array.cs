using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j=0, N;
            Console.WriteLine("Changing the even places and odd places of the input array");
            Console.WriteLine("Enter the Maximum Range");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N-1; i++)
            {
                j = a[i];
                a[i] = a[i + 1];
                a[i + 1] = j;
            }
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
