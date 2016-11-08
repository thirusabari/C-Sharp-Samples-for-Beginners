using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication70
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k=0, N,M;
            Console.WriteLine("Merging of 2 arrays:");
            Console.WriteLine("Enter the Maximum of Ranges of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            M = N + N;
            int[] a = new int[N];
            int[] b = new int[N];
            int[] merge = new int[M];
            Console.WriteLine("Enter the values for the first element of the array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Values entered for first array is:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the input values for the second array:");
            for (j = 0; j < N; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Second Array Contains");
            for (j = 0; j < N; j++)
            {
                Console.Write("{0} ", b[j]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                merge[k++] = a[i];
            }
            for (j =0; j < N; j++)
            {
                
                merge[k++] = b[j];
                
            }
            for (k = 0; k < M; k++)
            {
                Console.Write("{0} ", merge[k]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
