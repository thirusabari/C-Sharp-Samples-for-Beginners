using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Searching an element to the array:");
            int i, index, search, N;
            Console.WriteLine("Enter the Maximum Range of ther Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the element to be Searched");
            search = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                if (search== a[i])
                {
                    index = i;
                    Console.WriteLine("The Searched element {0} found at {1} position", search, index);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
