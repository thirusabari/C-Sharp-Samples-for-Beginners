using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication111
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k=0, count = 0, N,m=0,p=0;
            Console.WriteLine("Enter the Maximum Length of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            int[] common = new int[N];
            int[] pos = new int[N];
            Console.WriteLine("Enter the first array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the Second array:");
            for (j = 0; j < N; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (a[i] == b[j])
                    {
                        count = count + 2;
                        common[k] = a[i];
                        pos[p] = i;
                        p++;
                        pos[p] = j;
                        p++;
                        k = k + 2;
                        common[k] = b[j];
                        k = k - 1; ;
                    }
                }
            }
            Console.WriteLine("The Common Elements are:");
            Console.Write("Length={0}  ", count);
            for (k = 0; k < N; k++)
            {
                for (p = 0; p < N; p++)
                {
                    if (pos[p] == k)
                    {
                        Console.Write("{0} ", common[k]);
                    }
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
