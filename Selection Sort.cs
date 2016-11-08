using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_SOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, min, N,t;
            Console.WriteLine("Implementation of Selection Sort");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the N Elements of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("\n");
            Console.WriteLine("Enter the input Elements of the Array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                min = i;
                for (j = i + 1; j < N; j++)
                {
                    if (a[j] > a[min])
                    {
                        min = j;
                    }
                    t = a[i];
                    a[i] = a[min];
                    a[min] = t;
                   
                }
            }
            Console.WriteLine("Values After the Implementation of Selection SOrt");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();

        }
    }
}
